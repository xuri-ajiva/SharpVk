using System;

namespace SharpVk.Shanq
{
    public interface IVectorTypeLibrary
    {
        Type GetMatrixRowType(Type value);

        Type GetVectorElementType(Type value);

        int GetVectorLength(Type value);

        int[] GetMatrixDimensions(Type value);

        bool IsVectorType(Type type);

        bool IsMatrixType(Type type);
    }
}
