using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public class CommandCache
    {
        private readonly Dictionary<string, object> commands = new Dictionary<string, object>();
        private readonly IProcLookup host;
        private readonly string type;
        private readonly CommandCache parent;

        internal CommandCache(IProcLookup host, string type, CommandCache parent)
        {
            this.host = host;
            this.type = type;
            this.parent = parent;
        }

        /// <summary>
        /// Creates a new instance of CommandCache using the given IProcLookup
        /// instance to load unmanaged Vulkan function pointers.
        /// </summary>
        /// <param name="procLookup">
        /// An implementation of IProcLookup that can load the core Vulkan
        /// commands.
        /// </param>
        public CommandCache(IProcLookup procLookup)
            : this(procLookup, "", null)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public T GetCommandDelegate<T>(string name, string type)
        {
            if (type != this.type)
            {
                if (this.parent != null)
                {
                    return this.parent.GetCommandDelegate<T>(name, type);
                }
                else
                {
                    return default(T);
                }
            }

            lock (this.commands)
            {
                if (this.commands.ContainsKey(name))
                {
                    return (T)this.commands[name];
                }
            }

            T commandDelegate = Marshal.GetDelegateForFunctionPointer<T>(this.host.GetProcedureAddress(name));

            lock (this.commands)
            {
                if (this.commands.ContainsKey(name))
                {
                    return (T)this.commands[name];
                }
                else
                {
                    this.commands[name] = commandDelegate;
                }
            }

            return commandDelegate;
        }
    }
}
