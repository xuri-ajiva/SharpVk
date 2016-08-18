using Remotion.Linq.Parsing.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpVk.Shanq
{
    public static class ShanqShader<TInput>
    {
        public static void Create<TOutput>(Func<IQueryable<TInput>, IQueryable<TOutput>> shaderFunction)
        {
            var queryable = new ShanqQueryable<TInput>(QueryParser.CreateDefault(), new ShanqQueryExecutor());

            shaderFunction(queryable).ToArray();
        }
    }
}
