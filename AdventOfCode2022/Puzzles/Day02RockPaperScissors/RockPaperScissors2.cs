namespace AdventOfCode2022.Puzzles.Day02RockPaperScissors
{
    public class RockPaperScissors2 : IAdventPuzzle
    {
        private readonly Dictionary<char, int> moveMap;
        private readonly Dictionary<int, int[]> gameResultDictionary;
        private readonly int[,] gameResultChart;

        public RockPaperScissors2()
        {
            gameResultChart = new int[3, 3] {
                { 3, 0, 6 },
                { 6, 3, 0 },
                { 0, 6, 3 }
            };

            gameResultDictionary = new Dictionary<int, int[]>()
            {
                { 0, new int[] { 3, 6, 0 } },
                { 1, new int[] { 0, 3, 6 } },
                { 2, new int[] { 6, 0, 3 } }
            };

            moveMap = new Dictionary<char, int>()
            {
                { 'A', 0 },
                { 'B', 1 },
                { 'C', 2 },
                { 'X', 0 },
                { 'Y', 3 },
                { 'Z', 6 }
            };
        }

        public string GetName()
        {
            return "Rock Paper Scissors part 2";
        }

        public void Run()
        {
            /*
            A = Rock
            B = Paper
            C = Scissors

            X = Rock
            Y = Paper
            Z = Scissors

            Rock = 1
            Paper = 2
            Scissors = 3
            Win = 6
            Draw = 3
            Loss = 0

            X means you need to lose, 
            Y means you need to end the round in a draw, 
            Z means you need to win.

             */

            var input = PuzzleHelper.GetInput("Day02RockPaperScissors/input_02.txt");
            int totalScore = 0;
            foreach (var game in input)
            {
                totalScore += EvaluateGame(game);
            }

            Console.WriteLine($"Total Score = {totalScore}");
        }

        public int EvaluateGame(string game)
        {
            var elfMove = moveMap[game[0]];
            var playerMove = moveMap[game[2]];
            var array = gameResultDictionary[elfMove];
            var index = Array.IndexOf(array, playerMove);
            var score = index + 1;
            score += gameResultChart[index, elfMove];

            return score;
        }
    }
}

