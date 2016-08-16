using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpVk.Shanq
{
    public interface IShaderPart
    {
        string Format(IShaderFormatInfo info);
    }
}
