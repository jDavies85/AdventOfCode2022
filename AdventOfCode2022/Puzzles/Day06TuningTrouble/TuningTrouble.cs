namespace AdventOfCode2022.Puzzles.Day06TuningTrouble
{
    public class TuningTrouble : IAdventPuzzle
    {
        public string GetName()
        {
            return "Tuning Trouble part 1";
        }

        public void Run()
        {
            var input = PuzzleHelper.GetInput("/Day06TuningTrouble/input_06.txt");
            var startOfPacketMarkerIndex = TuningTroubleHelper.GetStartOfPacketMarkerIndex(input[0]);

            Console.WriteLine($"{startOfPacketMarkerIndex} characters need to be processed before the first start-of-packet marker is detected.");
        }
    }
}
