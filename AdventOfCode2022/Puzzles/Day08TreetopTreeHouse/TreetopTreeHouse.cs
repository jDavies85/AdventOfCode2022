namespace AdventOfCode2022.Puzzles.Day08TreetopTreeHouse
{
    public class TreetopTreeHouse : IAdventPuzzle
    {

        public string GetName()
        {
            return "Treetop Tree House part 1";
        }

        public void Run()
        {
            var input = PuzzleHelper.GetInput("/Day08TreetopTreeHouse/input_08.txt");
            var x = input[0].Length;
            var y = input.Length;
            var map = TreetopTreeHouseHelper.CreateMap(x, y, input);
            var visibleTrees = TreetopTreeHouseHelper.CountVisibleTrees(map);
            Console.WriteLine($"There are {visibleTrees} visible trees");
        }
    }
}
