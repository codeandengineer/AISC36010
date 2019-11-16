using System;
namespace AISC36010
{
    public class CmRolledRHSClassification : ICmClassificaiton
    {
        private ISection _section;
        private IMaterial _material;

        public CmRolledRHSClassification(ISection section, IMaterial material)
        {
            this._section = section;
            this._material = material;
        }

        public CmClass UnstiffenedElements
        {
            get
            {
                return CmClass.NonSlender;
            }
        }
        public CmClass StiffenedElements
        {
            get
            {
                if (((_section.d / _section.tw) <= 1.40 * Math.Sqrt(_material.E / _material.Fy)) && ((_section.b / _section.tw) <= 1.40 * Math.Sqrt(_material.E / _material.Fy)))
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
            get { throw new NotImplementedException(); }
        }
    }
}