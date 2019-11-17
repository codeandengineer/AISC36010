using System;

namespace AISC36010
{
    public class CmRolledIClassification : ICmClassificaiton
    {
        private RolledISection _section;
        private IMaterial _material;

        public CmRolledIClassification(ISection section, IMaterial material)
        {
            this._section = (RolledISection) section;
            this._material = material;
        }
        public CmClass UnstiffenedElements
        {
            get
            {
                if (((_section.b / 2) / (_section.tf)) <= 0.56 * Math.Sqrt(_material.E / _material.Fy))
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



        public CmClass Section
        {
            get
            {
                if ((this.StiffenedElements == CmClass.NonSlender) && (this.UnstiffenedElements == CmClass.NonSlender))
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

