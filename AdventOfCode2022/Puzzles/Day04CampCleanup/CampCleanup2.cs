namespace AdventOfCode2022.Puzzles.Day04CampCleanup
{
    public class CampCleanup2 : IAdventPuzzle
    {
        public string GetName()
        {
            return "Camp Cleanup Part 2";
        }

        public void Run()
        {
            var input = PuzzleHelper.GetInput("Day04CampCleanup/input_04.txt");

            int total = 0;

            foreach (var line in input)
            {
                var assignmentPair = CampCleanupHelper.GetAssignmentPair(line);
                if (assignmentPair[0].DoesOverlap(assignmentPair[1]))
                    total++;
            }

            Console.WriteLine($"There are {total} cases where one assignment overlaps the other");
        }
    }
}
