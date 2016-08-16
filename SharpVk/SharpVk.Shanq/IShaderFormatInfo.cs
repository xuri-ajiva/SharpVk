namespace SharpVk.Shanq
{
    public interface IShaderFormatInfo
    {
        string Format(IShaderExpression expression);

        string Format(IShaderStatement statement);

        string GetStructureName(DataStructureType dataStructure, int? dataStructureIndex = null);

        string GetStructureField(DataStructureType dataStructure, DataField inputData);
    }
}