using Enums;
namespace MemberDesign
{
    public interface ICmClassificaiton
    {
        CmClass UnstiffenedElements { get; }
        CmClass StiffenedElements { get; }
        CmClass SectionClassification { get; }
    }
}