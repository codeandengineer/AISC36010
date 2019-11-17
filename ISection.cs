namespace AISC36010
{
    public interface ISection
    {
        /* Sectional properties defined in this interface follows the
         * following cross section local axes convention
         * X-indicates the major axis of the section
         * Y-indicates the minor axis of the section
         * Z-indicates the longitudinal axis of the section
         */
        float d { get; set; }
        float h { get; set; }
        float b { get; set; }
        float tf { get; set; }
        float tw { get; set; }
        float rToe { get; set; }
        float rRoot { get; set; }
        //double Ax { get; set; }
        //double Ay { get; set; }
        //double Az { get; set; }
        //double Ix { get; set; }
        //double Iy { get; set; }
        //double J { get; set; }
        //double Iu { get; set; }
        //double Iv { get; set; }
        //double Iw { get; set; }

        //double Zx { get; set; }
        //double Zy { get; set; }
        //double Zz { get; set; }
        //double Sx { get; set; }
        //double Sy { get; set; }
        //double Sz { get; set; }
        //double rx { get; set; }
        //double ry { get; set; }
        //double rz { get; set; }
        //double ru { get; set; }
        //double rv { get; set; }
        //double rw { get; set; }
        //float w { get; private set; }


    }
}