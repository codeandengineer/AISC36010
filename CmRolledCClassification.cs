using Enums;
namespace AISC36010
{
    public class CmRolledCClassification : ICmClassificaiton
    {
        private ISection _section;
        private IMaterial _material;
        public CmRolledCClassification(ISection section, IMaterial material)
        {
            this._section = section;
            this._material = material;
        }

        public CmClass UnstiffenedElements
        {
            get
            {
                if ((_section.b / _section.tf) <= 0.56 * Math.Sqrt(_material.E / _material.Fy))
                {
                    return CmClass.NonSlender;
                }
                else
                {
                    return CmClass.NonSlender;
                }
            }
        }

        public CmClass StiffenedElements
        {
            get
            {
                if ((_section.d / _section.tw) <= 1.49 * Math.Sqrt(_material.E / _material.Fy))
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
