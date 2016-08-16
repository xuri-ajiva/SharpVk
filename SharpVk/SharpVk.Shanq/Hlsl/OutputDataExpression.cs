using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpVk.Shanq.Hlsl
{
    public class OutputDataExpression
        : IShaderExpression, ILeftHandShaderExpression
    {
        public OutputDataExpression(DataField inputData)
        {
            this.InputData = inputData;
        }

        public DataField InputData
        {
            get;
            private set;
        }

        public ShaderType ShaderType
        {
            get
            {
                return this.InputData.Type;
            }
        }

        public IEnumerable<IShaderExpression> Expressions
        {
            get
            {
                return null;
            }
        }

        public bool IsTrivial
        {
            get
            {
                return true;
            }
        }

        public string Format(IShaderFormatInfo info)
        {
            return info.GetStructureField(DataStructureType.Output, this.InputData);
        }
    }
}