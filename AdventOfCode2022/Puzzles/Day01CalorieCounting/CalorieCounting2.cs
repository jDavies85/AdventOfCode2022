namespace AdventOfCode2022.Puzzles.Day01CalorieCounting
{
    internal class CalorieCounting2 : IAdventPuzzle
    {
        public string GetName()
        {
            return "Calorie Counting Part 2";
        }

        public void Run()
        {
            var calorieTotal = GetElves().OrderByDescending(x => x.TotalCalories).Take(3).Sum(x => x.TotalCalories);
            Console.WriteLine($"Total calories of top 3 elves = {calorieTotal}");
        }

        private List<Elf> GetElves()
        {
            
            var input = PuzzleHelper.GetInput("Day01CalorieCounting/input_01.txt");
            int elfIndex = 1;

            var elves = new List<Elf>()
            {
                new Elf(){ Name = $"Elf {elfIndex}"}
            };

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == string.Empty)
                {
                    elfIndex++;
                    elves.Add(new Elf() { Name = $"Elf {elfIndex}" });
                }
                else
                {
                    elves[elfIndex-1].Calories.Add(Convert.ToInt32(input[i]));
                }
            }

            return elves;
        }
    }
}
