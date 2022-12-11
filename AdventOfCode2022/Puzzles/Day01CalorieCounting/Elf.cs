using System.Linq;

namespace AdventOfCode2022.Puzzles.Day01CalorieCounting
{
    internal class Elf
    {
        public string Name { get; set; }
        public List<int> Calories{ get; set; }
        public int TotalCalories => Calories.Sum();

        public Elf()
        {
            Calories = new List<int>();
        }
    }
}