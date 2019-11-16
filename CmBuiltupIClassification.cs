using System;
using System.Linq;

namespace AISC36010
{
    public class CmBuiltupIClassification : ICmClassificaiton
    {
        private ISection _section;
        private IMaterial _material;
        public CmBuiltupIClassification(ISection section, IMaterial material)
        {
            this._section = section;
            this._material = material;
        }

        private double kc
        {
            get
            {
               return Math.Min(0.76, Math.Max(0.35, 4 / Math.Sqrt(_section.h / _section.tw)));
            }
        }
        public CmClass UnstiffenedElements
        {
            get
            {
                if (((_section.b/2) / _section.tf) <= 0.64 * Math.Sqrt(kc * _material.E / _material.Fy))
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
            get { throw new NotImplementedException(); }
        }
    }

}
