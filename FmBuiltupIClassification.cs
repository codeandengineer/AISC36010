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
                
            }
        }

        public FmClass StiffenedElements
        {
            get
            {

            }
        }
    }
}