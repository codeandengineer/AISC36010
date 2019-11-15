using Enums;
namespace AISC36010
{
    public class CmRolledIClassification : ICmClassificaiton
    {
        private ISection _section;
        private IMaterial _material;

        public CmRolledIClassification(ISection section, IMaterial material)
        {
            this._section = section;
            this._material = material;
        }
        public CmClass UnstiffenedElements
        {
            get
            {
                if (((_section.b / 2) / (_section.tf)) <= 0.56 * Math.Sqrt(Material.E / Material.Fy))
                {
                    return CmClass.NonSlender;
                }
                else
                {
                    return CmClass.Slender;
                }
            }
        }

        public CmClass StiffenedElements
        {
            get
            {
                if ((_section.d / _section.tw) <= 1.49 * Math.Sqrt(Material.E / Material.Fy))
                {
                    return CmClass.NonSlender;
                }
                else
                {
                    return CmClass.Slender;
                }
            }
        }

    }    
}

