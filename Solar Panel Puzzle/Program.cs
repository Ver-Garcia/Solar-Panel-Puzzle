using Solar_Panel_Puzzle.Services;
using SolarPanelPuzzle.Models;

public class Program
{
    public static void Main(string[] args)
    {
        var solarPanels = new[]
        {
            new SolarPanel(3, 3, 10),
            new SolarPanel(2, 7, 12),
            new SolarPanel(3, 4, 14),
        };

        var landArea = 81;

        var permutationGenerator = new PanelPermutationGenerator();
        var farm = new SolarFarm(permutationGenerator);
        var result = farm.MaxOutput(solarPanels, landArea);
        var maxOutput = result.maxOutput / landArea;

        Console.WriteLine("Maximum total energy output: " + result.maxOutput);
        Console.WriteLine("Maximum energy output per square meter: " + maxOutput);

        Console.WriteLine("\nPanel combinations for maximum output:");
        foreach (var panel in result.usedPanels)
        {
            Console.WriteLine($"Length: {panel.Length}, Width: {panel.Width}, OutputPerUnitArea: {panel.OutputPerUnitArea}");
        }
    }
}