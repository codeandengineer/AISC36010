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
        public static double OmegaTY => omegaTY;

        public static double PhiTY => phiTY;

        // Tensile Rupture
        public static double PhiTR => phiTR;

        public static double OmegaTR => omegaTR;

        // Factors for Axial Compression
        public static double PhiC => phiC;

        public static double OmegaC => omegaC;

        // Factors for Flexure
        public static double PhiB => phiB;

        public static double OmegaB => omegaB;

        // Factors for Shear
        // Factors for Torsion
    }
}
