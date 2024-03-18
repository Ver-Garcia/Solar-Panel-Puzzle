using SolarPanelPuzzle.Models;

namespace Solar_Panel_Puzzle.Services
{
    public class PanelPermutationGenerator
    {
        public List<List<SolarPanel>> GeneratePermutations(List<SolarPanel> solarPanels)
        {
            var result = new List<List<SolarPanel>>();

            void Permute(List<SolarPanel> current, List<SolarPanel> remaining)
            {
                if (remaining.Count == 0)
                {
                    result.Add(new List<SolarPanel>(current));
                    return;
                }

                for (var i = 0; i < remaining.Count; i++)
                {
                    var nextCurrent = new List<SolarPanel>(current) { remaining[i] };
                    var nextRemaining = new List<SolarPanel>(remaining);
                    nextRemaining.RemoveAt(i);
                    Permute(nextCurrent, nextRemaining);
                }
            }

            Permute(new List<SolarPanel>(), solarPanels);

            return result;
        }
    }
}