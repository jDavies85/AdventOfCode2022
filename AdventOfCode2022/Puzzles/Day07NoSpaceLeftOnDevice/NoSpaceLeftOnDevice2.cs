namespace AdventOfCode2022.Puzzles.Day07NoSpaceLeftOnDevice
{
    public class NoSpaceLeftOnDevice2 : IAdventPuzzle
    {
        public string GetName()
        {
            return "No Space Left On Device part 2";
        }

        public void Run()
        {
            int totalDiskSpace = 70000000;
            int requiredDiskSpace = 30000000;

            var input = PuzzleHelper.GetInput("/Day07NoSpaceLeftOnDevice/input_07.txt");

            var fileSystem = NoSpaceLeftOnDeviceHelper.BuildFileSystem(input);
            var directories = NoSpaceLeftOnDeviceHelper.GetDirectoryStats(fileSystem);

            int totalDirectorySize = directories["/"];
            int currentUnusedFreeSpace = totalDiskSpace - totalDirectorySize;
            int requiredDeletedSpace = requiredDiskSpace - currentUnusedFreeSpace;

            var directoryToDelete = directories.Where(x => x.Value >= requiredDeletedSpace).OrderBy(x => x.Value).First();

            Console.WriteLine($"The directory that should be deleted is dir: {directoryToDelete.Key}, with a size of {directoryToDelete.Value}");
        }
    }
}
