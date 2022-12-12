using System.Text.RegularExpressions;

namespace AdventOfCode2022.Puzzles.Day05SupplyStacks
{
    public static class SupplyStacksHelper
    {
        public static Dictionary<int, Stack<char>> SetupStacks(string[] input)
        {
            var result = new Dictionary<int, Stack<char>>()
            {
                { 0, new Stack<char>()},
                { 1, new Stack<char>()},
                { 2, new Stack<char>()},
                { 3, new Stack<char>()},
                { 4, new Stack<char>()},
                { 5, new Stack<char>()},
                { 6, new Stack<char>()},
                { 7, new Stack<char>()},
                { 8, new Stack<char>()}
            };

            foreach (var line in input)
            {
                int stackIndex = 0;
                for (int i = 1; i < line.Length; i+= 4)
                {
                    if (line[i] != ' ')
                        result[stackIndex].Push(line[i]);

                    if(stackIndex +1 >= line.Length)
                        stackIndex = 0;
                    else
                        stackIndex++;
                }
            }

            return result;
        }

        public static int[][] GetCommands(string[] input)
        {
            var result = new int[input.Length][];

            for (int i = 0; i < input.Length; i++)
            {
                var resultString = string.Join(",", Regex.Matches(input[i], @"\d+").OfType<Match>().Select(m => m.Value));
                var split = resultString.Split(",");
                result[i] = new int[3] { Convert.ToInt32(split[0]), (Convert.ToInt32(split[1]) -1), (Convert.ToInt32(split[2]) -1) };
            }

            return result;
        }

        public static string ReadStacks(Dictionary<int, Stack<char>> stacks)
        {
            char[] message = new char[stacks.Count];
            for (int i = 0; i < stacks.Count; i++)
            {
                message[i] = stacks[i].Pop();
            }

            return new string(message);
        }
    }
}
