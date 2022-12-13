using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdventOfCode2022.Puzzles.Day07NoSpaceLeftOnDevice
{
    public class NoSpaceLeftOnDevice : IAdventPuzzle
    {
        public string GetName()
        {
            return "No Space Left On Device part 1";
        }

        public void Run()
        {
            var input = PuzzleHelper.GetInput("/Day07NoSpaceLeftOnDevice/input_07.txt");
            /*
            Build file system
            Traverse tree summing all files in directories with total file size less than 100000
             */
            var fileSystem = NoSpaceLeftOnDeviceHelper.BuildFileSystem(input);
            var directories = NoSpaceLeftOnDeviceHelper.GetAllDirectoriesRoot(fileSystem);
            var total = NoSpaceLeftOnDeviceHelper.GetSumOfAllDirectoriesWithThreshold(directories, 100000);

            Console.WriteLine($"The sum of all directories with a total size of at most 100000 is {total}");
        }


    }
}
