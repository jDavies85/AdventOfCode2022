namespace AdventOfCode2022.Puzzles.Day02RockPaperScissors
{
    internal class RockPaperScissors : IAdventPuzzle
    {
        private readonly Dictionary<char, int> moveMap;

        private readonly int[,] gameResultChart;

        public RockPaperScissors()
        {
            gameResultChart = new int[3, 3] {
                { 3, 0, 6 },
                { 6, 3, 0 },
                { 0, 6, 3 }
            };

            moveMap = new Dictionary<char, int>()
            {
                { 'A', 0 },
                { 'B', 1 },
                { 'C', 2 },
                { 'X', 0 },
                { 'Y', 1 },
                { 'Z', 2 }
            };
        }

        public string GetName()
        {
            return "Rock Paper Scissors part 1";
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

            Total should be 14297
             */

            var input = PuzzleHelper.GetInput("Day02RockPaperScissors/input_02.txt");
            int totalScore = 0;
            foreach (var game in input)
            {
                totalScore += EvaluateGame(game);
            }

            Console.WriteLine($"Total Score = {totalScore}");
        }

        private int EvaluateGame(string game)
        {
            var elfMove = moveMap[game[0]];
            var playerMove = moveMap[game[2]];
            var score = playerMove + 1;

            score += gameResultChart[playerMove, elfMove];

            return score;
        }
    }
}
