namespace AISC36010
{
    public class FmRolledCClassification : IFmClassification
    {
        private ISection _section;
        private IMaterial _material;

        public FmRolledCClassification(ISection section, IMaterial material)
        {
            this._section = section;
            this._material = material;
        }

        public FmClass UnstiffenedElements
        {
            get
            {
                if ((_section.b / _section.tf) <= 0.38 * Math.Sqrt(_material.E / _material.Fy))
                {
                    return FmClass.Compact;
                }
                else if ((_section.b / _section.tf) <= 1.00 * Math.Sqrt(_material.E / _material.Fy))
                {
                    return FmClass.NonCompact;
                }
                else
                {
                    return FmClass.Slender;
                }
            }
        }

        public FmClass StiffenedElements
        {
            get
            {
                if ((_section.h / _section.tw) <= 3.76 * Math.Sqrt(_material.E / _material.Fy))
                {
                    return FmClass.Compact;
                }
                else if ((_section.h / _section.tw) <= 5.70 * Math.Sqrt(_material.E / _material.Fy))
                {
                    return FmClass.NonCompact;
                }
                else
                {
                    return FmClass.Slender;
                }
            }
        }
    }
}