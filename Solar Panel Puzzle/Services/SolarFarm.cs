using SolarPanelPuzzle.Models;

namespace Solar_Panel_Puzzle.Services
{
    public class SolarFarm
    {
        private readonly PanelPermutationGenerator _permutationGenerator;

        public SolarFarm(PanelPermutationGenerator permutationGenerator)
        {
            _permutationGenerator = permutationGenerator;
        }

        public (float maxOutput, List<SolarPanel> usedPanels) MaxOutput(SolarPanel[] solarPanels, int landArea)
        {
            float maxOutput = 0;
            List<SolarPanel> maxOutputPanels = new List<SolarPanel>();

            List<List<SolarPanel>> permutations = _permutationGenerator.GeneratePermutations(solarPanels.ToList());

            foreach (var permutation in permutations)
            {
                var currentLandArea = landArea;
                var currentOutput = 0f;
                var currentPanels = new List<SolarPanel>();

                foreach (var panel in permutation)
                {
                    var maxPanels = currentLandArea / panel.CalculateArea();
                    currentLandArea -= maxPanels * panel.CalculateArea();
                    currentOutput += maxPanels * panel.CalculateTotalOutput();
                    currentPanels.AddRange(Enumerable.Repeat(panel, maxPanels));

                    if (currentLandArea == 0)
                        break;
                }

                if (currentOutput > maxOutput)
                {
                    maxOutput = currentOutput;
                    maxOutputPanels = new List<SolarPanel>(currentPanels);
                }
            }

            return (maxOutput, maxOutputPanels);
        }
    }
}