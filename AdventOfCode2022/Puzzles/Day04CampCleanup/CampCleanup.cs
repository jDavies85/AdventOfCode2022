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

            int total = 0;

            foreach (var line in input)
            {
                var assignmentPair = CampCleanupHelper.GetAssignmentPair(line);
                if (assignmentPair[0].IsFullyContainedIn(assignmentPair[1]) || assignmentPair[1].IsFullyContainedIn(assignmentPair[0]))
                    total++;
            }

            Console.WriteLine($"There are {total} cases where one assignment pair fully contains the other");
        }
    }
}
