namespace AdventOfCode2022.Puzzles.Day05SupplyStacks
{
    public class SupplyStacks2: IAdventPuzzle
    {
        public string GetName()
        {
            return "Supply Stacks part 2";
        }

        public void Run()
        {
            var input = PuzzleHelper.GetInput("/Day05SupplyStacks/input_05.txt");
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
                var boxPlopper = new Stack<char>();
                for (int i = take; i > 0; i--)
                {
                    if (!stacks[command[1]].TryPop(out char toMove))
                        break;

                    boxPlopper.Push(toMove);
                }

                while (boxPlopper.Count > 0)
                {
                    stacks[command[2]].Push(boxPlopper.Pop());
                }
            }
        }
    }
}
