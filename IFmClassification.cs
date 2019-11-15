namespace AISC36010
{
    public interface IFmClassification
    {
        FmClass UnstiffenedElements { get; }
        FmClass StiffenedElements { get; }
    }
}
