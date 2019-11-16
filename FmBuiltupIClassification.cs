namespace AISC36010
{
    public class FmBuiltupIClassification : IFmClassification
    {
        private ISection _section;
        private IMaterial _material;
        public FmBuiltupIClassification(ISection section, IMaterial material)
        {
            this._section = section;
            this._material = material;
        }
        public FmClass UnstiffenedElements
        {
            get
            {
                return FmClass.Compact;
            }
        }

        public FmClass StiffenedElements
        {
            get
            {
                return FmClass.Compact;
            }
        }


        public FmClass Section
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}