﻿namespace AISC36010
{
    public class CmRolledCHSClassification : ICmClassificaiton
    {
        private ISection _section;
        private IMaterial _material;
        public CmRolledCHSClassification(ISection section, IMaterial material)
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
                if ((_section.h / _section.tw) <= 0.11 * (_material.E / _material.Fy))
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
            get { throw new System.NotImplementedException(); }
        }
    }
}
