namespace AISC36010
{
    public interface ISection
    {
        float d { get; set; }
        float h { get; set; }
        float b { get; set; }
        float tf { get; set; }
        float tw { get; set; }
        float rToe { get; set; }
        float rRoot { get; set; }

    }
}