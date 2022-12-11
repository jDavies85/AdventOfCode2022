namespace AdventOfCode2022.Puzzles.Day03RucksackReorganization
{
    public class RucksackReorganization2 : IAdventPuzzle
    {
        public string GetName()
        {
            return "Rucksack Reorganization part 1";
        }

        public void Run()
        {
            var input = PuzzleHelper.GetInput("Day03RucksackReorganization/input_03.txt");
            var groups = ConvertToGroups(input);
            /*
            Split input into groups of 3
            find the common character in all 3 members of each group
            get and sum priority value
             */
            int totalPriorityScore = 0;
            foreach (var group in groups)
            {
                var commonCharacter = GetCommonCharacter(group[0], group[1], group[2]);
                totalPriorityScore += GetCharacterValue(commonCharacter);
            }
            Console.WriteLine($"Total priority score is: {totalPriorityScore}");
        }

        public List<List<string>> ConvertToGroups(string[] input)
        {
            int groupCount = 0;
            int groupIndex = 0;

            var groups = new List<List<string>>()
            {
                { new List<string>() }
            };

            for (int i = 0; i < input.Length; i++)
            {
                if (groupCount == 3)
                {
                    groupIndex++;
                    groupCount = 0;
                    groups.Add(new List<string>());
                }
                groups[groupIndex].Add(input[i]);
                groupCount++;
            }

            return groups;
        }

        public char GetCommonCharacter(string rucksackA, string rucksackB, string rucksackC)
        {
            char result = ' ';
            foreach (char c in rucksackA)
            {
                if (rucksackB.Contains(c) && rucksackC.Contains(c))
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
