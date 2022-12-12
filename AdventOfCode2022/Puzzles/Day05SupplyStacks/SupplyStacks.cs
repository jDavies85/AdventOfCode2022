namespace AdventOfCode2022.Puzzles.Day05SupplyStacks
{
    public class SupplyStacks : IAdventPuzzle
    {
        public string GetName()
        {
            return "Supply Stacks part 1";
        }

        public void Run()
        {
            var input = PuzzleHelper.GetInput("/Day05SupplyStacks/input_05.txt");
            /*
            Build stacks
            Form queue of commands
            Execute commands
            Read out message
             */
            var stacks = SupplyStacksHelper.SetupStacks(input.Take(8).Reverse().ToArray());
            var commands = SupplyStacksHelper.GetCommands(input.Skip(10).ToArray());
            ExecuteCommands(stacks, commands);
            var message = SupplyStacksHelper.ReadStacks(stacks);
            Console.WriteLine(message);
        }

        private void ExecuteCommands(Dictionary<int, Stack<char>> stacks, int[][] commands)
        {
            foreach (var command in commands)
            {
                int take = command[0];
                for (int i = take; i > 0; i--)
                {
                    //take [0] from [1]
                    if (!stacks[command[1]].TryPop(out char toMove))
                        break;
                    //move to [2]
                    stacks[command[2]].Push(toMove);
                }
            }
        }
    }
}
