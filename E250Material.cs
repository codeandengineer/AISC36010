
namespace AISC36010
{
    public class E250Material : IMaterial
    {
        private string _Grade;
        private double _E;
        private double _G;
        private float _Fy;
        private float _Fu;
        public E250Material(string grade, double elasticModulus, float yieldStress, float ultimateStress)
        {
            this._Grade = grade;
            this._E = elasticModulus;
            this._Fy = yieldStress;
            this._Fu = ultimateStress;
        }
        public double E
        {
            get
            {
                return this._E;
            }
            set
            {
                this._E = value;
            }
        }

        public float Fy
        {
            get
            {
                return this._Fy;
            }
            set
            {
                this._Fy = value;
            }
        }

        public float Fu
        {
            get
            {
                return this._Fu;
            }
            set
            {
                this._Fu = value;
            }
        }

        public string Grade
        {
            get
            {
                return this._Grade;
            }
            set
            {
                this._Grade = value;
            }
        }

    }
}
