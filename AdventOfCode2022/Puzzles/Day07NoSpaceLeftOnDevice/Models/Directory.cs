using File = AdventOfCode2022.Puzzles.Day07NoSpaceLeftOnDevice.Models.File;

namespace AdventOfCode2022.Puzzles.Day07NoSpaceLeftOnDevice.Models
{
    public class Directory
    {
        public string Name { get; set; }
        public List<File> Files { get; set; }
        public List<Directory> SubDirectories { get; set; }
        public Directory? ParentDirectory { get; set; }

        public int Size => Files.Sum(x => x.Size);

        public Directory()
        {
            Files = new List<File>();
            SubDirectories = new List<Directory>();
        }
    }
}
