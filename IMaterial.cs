namespace AISC36010
{
    public interface IMaterial
    {
        double E { get; set; }
        float Fy { get; set; }
        float Fu { get; set; }
        string Grade { get; set; }
    }
}
