using Remotion.Linq.Parsing.Structure;
using SharpVk.Spirv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpVk.Shanq
{
    public static class ShanqShader<TInput>
    {
        public static void Create<TOutput>(ExecutionModel model, Stream outputStream, Func<IQueryable<TInput>, IQueryable<TOutput>> shaderFunction)
        {
            var queryable = new ShanqQueryable<TInput>(QueryParser.CreateDefault(), new ShanqQueryExecutor(model, outputStream));

            shaderFunction(queryable).ToArray();
        }
    }
}
