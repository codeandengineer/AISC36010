
namespace AISC36010
{
    public interface ICmClassificaiton
    {
        CmClass UnstiffenedElements { get; }
        CmClass StiffenedElements { get; }
        CmClass Section { get; }
    }
}