using System.Linq;

namespace AISC36010
{
    public struct DesignFactors
    {
        // Factors for Axial Tension
        // Tensile Yielding
        private const double phiTY = 0.90;
        private const double omegaTY = 1.67;

        // Tensile Rupture
        private const double phiTR = 0.75;
        private const double omegaTR = 2.00;

        // Factors for Axial Compression
        private const double phiC = 0.90;
        private const double omegaC = 1.67;

        // Factors for Flexure
        private const double phiB = 0.90;
        private const double omegaB = 1.67;


        // Factors for Axial Tension
        // Tensile Yielding
       
        public static double OmegaTY 
        {
            get {
                return omegaTY;                
            }
        }

        public static double PhiTY 
        {
            get {
                return phiTY;
            }
        }

        // Tensile Rupture
        public static double PhiTR 
        {
            get
            {
                return phiTR;
            }
        }
        public static double OmegaTR
        {
            get
            {
                return omegaTR;
            }
        }

        // Factors for Axial Compression
        public static double PhiC
        {
            get
            {
                return phiC;
            }
        }

        public static double OmegaC
        {
            get
            {
                return omegaC;
            }
        }

        // Factors for Flexure
        public static double PhiB
        {
            get
            {
                return phiB;
            }
        }
        public static double OmegaB
        {
            get
            {
                return omegaB;
            }
        }

        // Factors for Shear
        // Factors for Torsion
    }
}
