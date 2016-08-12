using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpVk.Example
{
    class Program
    {
        [STAThread]
        public static void Main()
        {
            try
            {
                var instance = Instance.Create(new InstanceCreateInfo
                {
                    ApplicationInfo = new ApplicationInfo
                    {
                        ApplicationName = "Example Application",
                        EngineName = "SharpVK"
                    },
                    EnabledExtensionNames = new[] { "VK_KHR_surface", "VK_KHR_win32_surface" }
                }, null);

                var surfaceForm = new Form
                {
                    ClientSize = new Size(1280, 720)
                };

                var surfaceCreateInfo = new Win32SurfaceCreateInfo
                {
                    Flags = Win32SurfaceCreateFlags.None,
                    Hinstance = IntPtr.Zero,
                    Hwnd = surfaceForm.Handle
                };

                var surface = instance.CreateWin32Surface(surfaceCreateInfo, null);

                var physicalDevice = instance.EnumeratePhysicalDevices().First();

                var surfaceCapabilities = physicalDevice.GetSurfaceCapabilities(surface);

                var queueFamilies = physicalDevice.GetQueueFamilyProperties();

                var presentableQueues = Enumerable.Range(0, queueFamilies.Length)
                                                    .Select(x => (uint)x)
                                                    .Where(x => physicalDevice.GetSurfaceSupport(x, surface))
                                                    .ToArray();

                var graphicsQueues = presentableQueues
                                                .Where(x => queueFamilies[x].QueueFlags.HasFlag(QueueFlags.Graphics))
                                                .ToArray();

                var surfaceFormats = physicalDevice.GetSurfaceFormats(surface);

                var surfaceFormat = surfaceFormats.First();

                var device = physicalDevice.CreateDevice(new DeviceCreateInfo
                {
                    QueueCreateInfos = new[]
                    {
                        new DeviceQueueCreateInfo
                        {
                            QueueFamilyIndex = graphicsQueues.First(),
                            QueuePriorities = new float[] { 1 }
                        }
                    }
                }, null);

                var graphicsQueue = device.GetQueue(graphicsQueues.First(), 0);

                var swapchain = device.CreateSwapchain(new SwapchainCreateInfo
                {
                    Surface = surface,
                    Flags = SwapchainCreateFlags.None,
                    PresentMode = PresentMode.Immediate,
                    MinImageCount = 2,
                    ImageExtent = surfaceCapabilities.CurrentExtent,
                    ImageUsage = ImageUsageFlags.ColorAttachment,
                    PreTransform = surfaceCapabilities.CurrentTransform,
                    ImageArrayLayers = 1,
                    ImageSharingMode = SharingMode.Exclusive,
                    ImageFormat = surfaceFormat.Format,
                    ImageColorSpace = surfaceFormat.ColorSpace,
                    Clipped = true,
                    CompositeAlpha = surfaceCapabilities.SupportedCompositeAlpha
                }, null);

                var images = swapchain.GetImages();

                var imageViews = images.Select(image => device.CreateImageView(new ImageViewCreateInfo
                {
                    Components = ComponentMapping.Identity,
                    Format = surfaceFormat.Format,
                    Image = image,
                    Flags = ImageViewCreateFlags.None,
                    ViewType = ImageViewType.ImageView2d,
                    SubresourceRange = new ImageSubresourceRange
                    {
                        AspectMask = ImageAspectFlags.Color,
                        BaseMipLevel = 0,
                        LevelCount = 1,
                        BaseArrayLayer = 0,
                        LayerCount = 1
                    }
                }, null)).ToArray();

                var renderPass = device.CreateRenderPass(new RenderPassCreateInfo
                {
                    Attachments = new[]
                    {
                        new AttachmentDescription
                        {
                            Format = surfaceFormat.Format,
                            Samples = SampleCountFlags.SampleCount1,
                            LoadOp = AttachmentLoadOp.Clear,
                            StoreOp = AttachmentStoreOp.Store,
                            StencilLoadOp = AttachmentLoadOp.DontCare,
                            StencilStoreOp = AttachmentStoreOp.DontCare,
                            InitialLayout = ImageLayout.Undefined,
                            FinalLayout = ImageLayout.PresentSource
                        }
                    },
                    Subpasses = new[]
                    {
                        new SubpassDescription
                        {
                            PipelineBindPoint = PipelineBindPoint.Graphics,
                            ColorAttachments = new []
                            {
                                new AttachmentReference
                                {
                                    Attachment = 0,
                                    Layout = ImageLayout.ColorAttachmentOptimal
                                }
                            }
                        }
                    },
                    Dependencies = new[]
                    {
                        new SubpassDependency
                        {
                            SourceSubpass = Constants.SubpassExternal,
                            DestinationSubpass = 0,
                            SourceStageMask = PipelineStageFlags.BottomOfPipe,
                            SourceAccessMask = AccessFlags.MemoryRead,
                            DestinationStageMask = PipelineStageFlags.ColorAttachmentOutput,
                            DestinationAccessMask = AccessFlags.ColorAttachmentRead | AccessFlags.ColorAttachmentWrite
                        }
                    }
                }, null);

                int codeSize;
                var vertShaderData = LoadShaderData(@".\Shaders\vert.spv", out codeSize);

                var vertShader = device.CreateShaderModule(new ShaderModuleCreateInfo
                {
                    Code = vertShaderData,
                    CodeSize = (UIntPtr)codeSize
                }, null);

                var fragShaderData = LoadShaderData(@".\Shaders\frag.spv", out codeSize);

                var fragShader = device.CreateShaderModule(new ShaderModuleCreateInfo
                {
                    Code = fragShaderData,
                    CodeSize = (UIntPtr)codeSize
                }, null);

                var pipelineLayout = device.CreatePipelineLayout(new PipelineLayoutCreateInfo(), null);

                var pipeline = device.CreateGraphicsPipelines(null, new[]
                {
                    new GraphicsPipelineCreateInfo
                    {
                        Layout = pipelineLayout,
                        RenderPass = renderPass,
                        Subpass = 0,
                        VertexInputState = new PipelineVertexInputStateCreateInfo(),
                        InputAssemblyState = new PipelineInputAssemblyStateCreateInfo
                        {
                            PrimitiveRestartEnable = false,
                            Topology = PrimitiveTopology.TriangleList
                        },
                        ViewportState = new PipelineViewportStateCreateInfo
                        {
                            Viewports = new[]
                            {
                                new Viewport
                                {
                                    X = 0f,
                                    Y = 0f,
                                    Width = surfaceCapabilities.CurrentExtent.Width,
                                    Height = surfaceCapabilities.CurrentExtent.Height,
                                    MaxDepth = 1,
                                    MinDepth = 0
                                }
                            },
                            Scissors = new[]
                            {
                                new Rect2D
                                {
                                    Offset = new Offset2D(),
                                    Extent= surfaceCapabilities.CurrentExtent
                                }
                            }
                        },
                        RasterizationState = new PipelineRasterizationStateCreateInfo
                        {
                            DepthClampEnable = false,
                            RasterizerDiscardEnable = false,
                            PolygonMode = PolygonMode.Fill,
                            LineWidth = 1,
                            CullMode = CullModeFlags.Back,
                            FrontFace = FrontFace.Clockwise,
                            DepthBiasEnable = false
                        },
                        MultisampleState = new PipelineMultisampleStateCreateInfo
                        {
                            SampleShadingEnable=false,
                            RasterizationSamples = SampleCountFlags.SampleCount1
                        },
                        ColorBlendState = new PipelineColorBlendStateCreateInfo
                        {
                            Attachments = new[]
                            {
                                new PipelineColorBlendAttachmentState
                                {
                                    ColorWriteMask = ColorComponentFlags.R
                                                        | ColorComponentFlags.G
                                                        | ColorComponentFlags.B
                                                        | ColorComponentFlags.A,
                                    BlendEnable = false
                                }
                            },
                            LogicOpEnable = false,
                            LogicOp = LogicOp.Copy,
                            BlendConstants = new float[] {0,0,0,0}
                        },
                        Stages = new[]
                        {
                            new PipelineShaderStageCreateInfo
                            {
                                Stage = ShaderStageFlags.Vertex,
                                Module = vertShader,
                                Name = "main"
                            },
                            new PipelineShaderStageCreateInfo
                            {
                                Stage = ShaderStageFlags.Fragment,
                                Module = fragShader,
                                Name = "main"
                            }
                        }
                    }
                }, null).Single();

                var frameBuffers = imageViews.Select(x => device.CreateFramebuffer(new FramebufferCreateInfo
                {
                    RenderPass = renderPass,
                    Attachments = new[] { x },
                    Layers = 1,
                    Height = surfaceCapabilities.CurrentExtent.Height,
                    Width = surfaceCapabilities.CurrentExtent.Width
                }, null)).ToArray();

                var commandPool = device.CreateCommandPool(new CommandPoolCreateInfo
                {
                    QueueFamilyIndex = graphicsQueues.First()
                }, null);

                var commandBuffers = device.AllocateCommandBuffers(new CommandBufferAllocateInfo
                {
                    CommandBufferCount = (uint)frameBuffers.Length,
                    CommandPool = commandPool,
                    Level = CommandBufferLevel.Primary
                });

                for (int index = 0; index < frameBuffers.Length; index++)
                {
                    var commandBuffer = commandBuffers[index];

                    commandBuffer.Begin(new CommandBufferBeginInfo
                    {
                        Flags = CommandBufferUsageFlags.SimultaneousUse
                    });

                    commandBuffer.BeginRenderPass(new RenderPassBeginInfo
                    {
                        RenderPass = renderPass,
                        Framebuffer = frameBuffers[index],
                        RenderArea = new Rect2D
                        {
                            Offset = new Offset2D(),
                            Extent = surfaceCapabilities.CurrentExtent
                        },
                        ClearValues = new ClearValue[]
                        {
                            new ClearValue()
                            {
                                Color = new ClearColorValue
                                {
                                    Float32_0 = 0,
                                    Float32_1 = 0,
                                    Float32_2 = 0,
                                    Float32_3 = 1
                                }
                            }
                        }
                    }, SubpassContents.Inline);

                    commandBuffer.BindPipeline(PipelineBindPoint.Graphics, pipeline);

                    commandBuffer.Draw(3, 1, 0, 0);

                    commandBuffer.End();
                }

                var imageAvailableSemaphore = device.CreateSemaphore(new SemaphoreCreateInfo(), null);
                var renderFinishedSemaphore = device.CreateSemaphore(new SemaphoreCreateInfo(), null);

                //bool running = true;

                //surfaceForm.ShowDialog();

                //while (running)
                //{
                //    Application.DoEvents();
                //    graphicsQueue.WaitIdle();

                //    uint nextImage = swapchain.AcquireNextImage(uint.MaxValue, imageAvailableSemaphore, null);

                //    graphicsQueue.Submit(new[]
                //    {
                //            new SubmitInfo
                //            {
                //                CommandBuffers = new CommandBuffer[] { commandBuffers[nextImage] },
                //                SignalSemaphores = new[] { renderFinishedSemaphore },
                //                WaitDestinationStageMask = new [] { PipelineStageFlags.ColorAttachmentOutput },
                //                WaitSemaphores = new [] { imageAvailableSemaphore }
                //            }
                //        }, null);

                //    graphicsQueue.Present(new PresentInfo
                //    {
                //        ImageIndices = new uint[] { nextImage },
                //        Results = null,
                //        WaitSemaphores = new[] { renderFinishedSemaphore },
                //        Swapchains = new[] { swapchain }
                //    });
                //}

                //device.WaitIdle();

                //commandPool.FreeCommandBuffers(commandBuffers);

                //commandPool.Destroy(null);

                fragShader.Destroy(null);

                vertShader.Destroy(null);

                //renderPass.Destroy(null);

                //pipelineLayout.Destroy(null);

                //pipeline.Destroy(null);

                foreach (var imageView in imageViews)
                {
                    imageView.Destroy(null);
                }

                foreach (var image in images)
                {
                    image.Destroy(null);
                }

                imageAvailableSemaphore.Destroy(null);
                renderFinishedSemaphore.Destroy(null);

                //swapchain.Destroy(null);

                device.Destroy(null);

                surface.Destroy(null);

                instance.Destroy(null);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private static uint[] LoadShaderData(string filePath, out int codeSize)
        {
            var fileBytes = File.ReadAllBytes(filePath);
            var shaderData = new uint[(int)Math.Ceiling(fileBytes.Length / 4f)];

            System.Buffer.BlockCopy(fileBytes, 0, shaderData, 0, fileBytes.Length);

            codeSize = fileBytes.Length;

            return shaderData;
        }
    }
}
