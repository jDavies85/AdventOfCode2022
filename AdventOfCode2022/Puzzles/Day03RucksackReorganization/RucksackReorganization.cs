namespace AdventOfCode2022.Puzzles.Day03RucksackReorganization
{
    public class RucksackReorganization : IAdventPuzzle
    {
        public string GetName()
        {
            return "Rucksack Reorganization part 1";
        }

        public void Run()
        {
            var input = PuzzleHelper.GetInput("Day03RucksackReorganization/input_03.txt");
            /*
             foreach line
            split it in half
            find the character that appears in both compartments
            get the int value for all characters
            sum those values and add to the grand total
             */
            int totalPriorityScore = 0;
            foreach (var line in input)
            {
                var compartmentA = line.Substring(0, line.Length / 2);
                var compartmentB = line.Substring(line.Length / 2);
                var commonCharacter = GetCommonCharacter(compartmentA, compartmentB);
                totalPriorityScore += GetCharacterValue(commonCharacter);
            }

            Console.WriteLine($"Total priority score is: {totalPriorityScore}");
        }

        public char GetCommonCharacter(string compartmentA, string compartmentB)
        {
            char result = ' ';
            foreach (char c in compartmentA)
            {
                if (compartmentB.Contains(c))
                {
                    result = c;
                    break;
                }
            }
            return result;
        }

        public int GetCharacterValue(char c)
        {
            int value = char.IsUpper(c) ? ((int)c % 32) + 26 : (int)c % 32;
            return value;
        }
    }
}
