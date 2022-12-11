namespace AdventOfCode2022
{
    public static class PuzzleHelper
    {
        public static string[] GetInput(string path)
        {
            var lines = File.ReadAllLines($"./Puzzles/{path}");

            return lines;
        }
    }
}
