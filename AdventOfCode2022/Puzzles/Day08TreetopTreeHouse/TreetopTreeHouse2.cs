namespace AdventOfCode2022.Puzzles.Day08TreetopTreeHouse
{
    public class TreetopTreeHouse2 : IAdventPuzzle
    {
        public string GetName()
        {
            return "Treetop Tree House part 2";
        }

        public void Run()
        {
            var input = PuzzleHelper.GetInput("/Day08TreetopTreeHouse/input_08.txt");
            int maxY = input.Length;
            int maxX = input[0].Length;
            var map = TreetopTreeHouseHelper.CreateMap(maxX, maxY, input);

            int highestScenicScore = 0;

            for (int y = 0; y < maxY; y++)
            {
                for (int x = 0; x < maxX; x++)
                {
                    var score = TreetopTreeHouseHelper.GetScenicScore(y, x, map);
                    if (score > highestScenicScore)
                        highestScenicScore = score;
                }
            }

            Console.WriteLine($"The highest Scenic score in the forest is: {highestScenicScore}");
        }
    }
}
