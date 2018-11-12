using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpVk.Tests
{
    [TestClass]
    public unsafe class InstanceTests
    {
        private class MockLookup
            : IProcLookup
        {
            private readonly Dictionary<string, Delegate> procedures = new Dictionary<string, Delegate>();

            public void AddProcedure(string name, Delegate procedure) => this.procedures.Add(name, procedure);

            public IntPtr GetProcedureAddress(string name)
            {
                if (this.procedures.TryGetValue(name, out var procedure))
                {
                    return Marshal.GetFunctionPointerForDelegate(procedure);
                }
                else
                {
                    return IntPtr.Zero;
                }
            }
        }

        [TestMethod]
        public void ShouldEnumerateVersion()
        {
            var mockLookup = new MockLookup();
            var commandCache = new CommandCache(mockLookup);

            int callCount = 0;

            var targetResult = new Version(1, 2, 3);

            Result EnumerateInstanceVersion(uint* version)
            {
                callCount++;

                Assert.IsFalse(version == null);

                *version = (uint)targetResult;

                return Result.Success;
            }

            mockLookup.AddProcedure("vkEnumerateInstanceVersion", new SharpVk.Interop.VkInstanceEnumerateVersionDelegate(EnumerateInstanceVersion));

            var result = Instance.EnumerateVersion(commandCache);

            Assert.AreEqual(1, callCount);
            Assert.AreEqual(targetResult, result);
        }

        [TestMethod]
        public void ShouldEnumerateLayers()
        {
            EnumerateGivenLayers(new LayerProperties[]
                {
                    new LayerProperties
                    {
                        Description = "Layer0 Desc",
                        ImplementationVersion =  new Version(1, 2, 3),
                        SpecVersion =  new Version(1, 2, 3),
                        LayerName = "Layer0"
                    }
                });
        }

        [TestMethod]
        public void ShouldEnumerateZeroLayers()
        {
            EnumerateGivenLayers(new LayerProperties[] { });
        }

        [TestMethod]
        public void ShouldEnumerateExtensions()
        {
            EnumerateGivenExtensions(null, new ExtensionProperties[]
            {
                new ExtensionProperties
                {
                    ExtensionName = "Extension 0",
                    SpecVersion = new Version(1, 2, 3)
                }
            });
        }

        [TestMethod]
        public void ShouldEnumerateZeroExtensions()
        {
            EnumerateGivenExtensions(null, new ExtensionProperties[] { });
        }

        private static void EnumerateGivenExtensions(string layer, ExtensionProperties[] extensions)
        {
            var mockLookup = new MockLookup();
            var commandCache = new CommandCache(mockLookup);

            int callCount = 0;

            Result EnumerateInstanceExtensionProperties(byte* layerName, uint* propertyCount, SharpVk.Interop.ExtensionProperties* properties)
            {
                callCount++;

                Assert.IsFalse(propertyCount == null);

                if (properties == null)
                {
                    *propertyCount = (uint)extensions.Length;
                }
                else
                {
                    Assert.AreEqual((uint)extensions.Length, *propertyCount);

                    for (int index = 0; index < extensions.Length; index++)
                    {
                        WriteFixedLengthString(extensions[index].ExtensionName, properties[index].ExtensionName, Constants.MaxExtensionNameSize);
                        properties[index].SpecVersion = (uint)extensions[index].SpecVersion;
                    }
                }

                return Result.Success;
            }

            mockLookup.AddProcedure("vkEnumerateInstanceExtensionProperties", new SharpVk.Interop.VkInstanceEnumerateExtensionPropertiesDelegate(EnumerateInstanceExtensionProperties));

            var result = Instance.EnumerateExtensionProperties(commandCache, layer);

            Assert.AreEqual(2, callCount);
            if (extensions.Length > 0)
            {
                CollectionAssert.AreEqual(extensions, result);
            }
            else
            {
                Assert.IsNull(result);
            }
        }

        private static void EnumerateGivenLayers(LayerProperties[] layers)
        {
            var mockLookup = new MockLookup();
            var commandCache = new CommandCache(mockLookup);

            int callCount = 0;

            Result EnumerateInstanceLayerProperties(uint* propertyCount, SharpVk.Interop.LayerProperties* properties)
            {
                callCount++;

                Assert.IsFalse(propertyCount == null);

                if (properties == null)
                {
                    *propertyCount = (uint)layers.Length;
                }
                else
                {
                    Assert.AreEqual((uint)layers.Length, *propertyCount);

                    for (int index = 0; index < layers.Length; index++)
                    {
                        WriteFixedLengthString(layers[index].Description, properties[index].Description, Constants.MaxDescriptionSize);
                        WriteFixedLengthString(layers[index].LayerName, properties[index].LayerName, Constants.MaxExtensionNameSize);
                        properties[index].ImplementationVersion = (uint)layers[index].ImplementationVersion;
                        properties[index].SpecVersion = (uint)layers[index].SpecVersion;
                    }
                }

                return Result.Success;
            }

            mockLookup.AddProcedure("vkEnumerateInstanceLayerProperties", new SharpVk.Interop.VkInstanceEnumerateLayerPropertiesDelegate(EnumerateInstanceLayerProperties));

            var result = Instance.EnumerateLayerProperties(commandCache);

            Assert.AreEqual(2, callCount);
            if (layers.Length > 0)
            {
                CollectionAssert.AreEqual(layers, result);
            }
            else
            {
                Assert.IsNull(result);
            }
        }

        private static void WriteFixedLengthString(string value, byte* target, int length)
        {
            Assert.IsFalse(target == null);

            var targetSpan = new Span<byte>(target, length);
            targetSpan.Fill(0);

            Encoding.ASCII.GetBytes(value.AsSpan(), targetSpan);
        }
    }
}
