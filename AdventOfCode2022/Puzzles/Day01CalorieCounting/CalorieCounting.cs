namespace AdventOfCode2022.Puzzles.Day01CalorieCounting
{
    internal class CalorieCounting : IAdventPuzzle
    {
        public string GetName()
        {
            return "Calorie Counting Part 1";
        }

        public void Run()
        {
            Console.WriteLine($"Running {GetName()}");
            var input = PuzzleHelper.GetInput("Day01CalorieCounting/input_01.txt");

            int largestCalorieCount = 0;
            int currentCalorieCount = 0;
            int elfIndex = 1;
            int winnerElfIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == string.Empty)
                {
                    Console.WriteLine($"Finished evaluating elf: {elfIndex} with a total calorie count of {currentCalorieCount}");
                    if (currentCalorieCount > largestCalorieCount)
                    {
                        largestCalorieCount = currentCalorieCount;
                        winnerElfIndex = elfIndex;
                        Console.WriteLine($"New largest calorie count of {largestCalorieCount}");
                    }
                    currentCalorieCount = 0;
                    elfIndex++;
                }
                else
                {
                    Console.WriteLine($"Adding {Convert.ToInt32(input[i])} to current calorie count");
                    currentCalorieCount += Convert.ToInt32(input[i]);
                    Console.WriteLine($"Elf: {elfIndex} has a current calorie count of {currentCalorieCount}");
                }
            }

            Console.WriteLine($"The winnder is Elf: {winnerElfIndex} with a calorie count of {largestCalorieCount}");
        }
    }
}
