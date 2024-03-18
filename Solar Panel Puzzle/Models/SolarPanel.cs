namespace SolarPanelPuzzle.Models
{
    public class SolarPanel
    {
        public int Length { get; }
        public int Width { get; }
        public int OutputPerUnitArea { get; }

        public SolarPanel(int length, int width, int outputPerUnitArea)
        {
            Length = length;
            Width = width;
            OutputPerUnitArea = outputPerUnitArea;
        }

        public int CalculateArea() => Length * Width;

        public int CalculateTotalOutput() => CalculateArea() * OutputPerUnitArea;
    }
}