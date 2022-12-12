namespace AdventOfCode2022.Puzzles.Day06TuningTrouble
{
    public class TuningTrouble2 : IAdventPuzzle
    {
        public string GetName()
        {
            return "Tuning Trouble part 2";
        }

        public void Run()
        {
            var input = PuzzleHelper.GetInput("/Day06TuningTrouble/input_06.txt");
            var startOfMessageMarkerIndex = TuningTroubleHelper.GetStartOfMessageMarkerIndex(input[0]);

            Console.WriteLine($"{startOfMessageMarkerIndex} characters need to be processed before the first start-of-message marker is detected.");
        }
    }
}
