namespace AdventOfCode2022.Puzzles.Day04CampCleanup
{
    public class CampCleanup : IAdventPuzzle
    {
        public string GetName()
        {
            return "Camp Cleanup Part 1";
        }

        public void Run()
        {
            var input = PuzzleHelper.GetInput("Day04CampCleanup/input_04.txt");
            foreach (var line in input)
            {
                var assignmentPair = line.Split(',');
            }
        }
    }
}
