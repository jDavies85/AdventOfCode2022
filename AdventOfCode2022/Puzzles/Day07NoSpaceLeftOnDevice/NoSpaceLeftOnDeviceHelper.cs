using System.Xml.Linq;
using Directory = AdventOfCode2022.Puzzles.Day07NoSpaceLeftOnDevice.Models.Directory;
using File = AdventOfCode2022.Puzzles.Day07NoSpaceLeftOnDevice.Models.File;

namespace AdventOfCode2022.Puzzles.Day07NoSpaceLeftOnDevice
{
    public static class NoSpaceLeftOnDeviceHelper
    {
        public static Directory BuildFileSystem(string[] input)
        {
            Directory currentDirectory = null;

            foreach (var item in input)
            {
                var command = item.Split(" ");

                if (command[0] == "$")
                {
                    if (command[1] == "cd" && command[2] != "..")
                    {
                        //navigate or create
                        var existingDirectory = currentDirectory?.SubDirectories.FirstOrDefault(x => x.Name == command[2]);
                        if (existingDirectory != null)
                        {
                            currentDirectory = existingDirectory;
                        }
                        else
                        {
                            var directory = new Directory()
                            {
                                Name = command[2],
                                ParentDirectory = currentDirectory
                            };
                            if (currentDirectory == null)
                            {
                                currentDirectory = directory;
                            }
                            else
                            {
                                currentDirectory.SubDirectories.Add(directory);
                                currentDirectory = directory;
                            }
                        }
                    }
                    else if (command[1] == "cd" && command[2] == "..")
                    {
                        //navigate 
                        currentDirectory = currentDirectory?.ParentDirectory;
                    }
                    else if (command[1] == "ls")
                    {
                        //create files
                    }
                }
                else if (command[0] == "dir")
                {
                    //create directory if not exists
                    var existingDirectory = currentDirectory?.SubDirectories.FirstOrDefault(x => x.Name == command[1]);
                    if (existingDirectory == null)
                    {
                        currentDirectory.SubDirectories.Add(new Directory() { Name = command[1], ParentDirectory = currentDirectory });
                    }
                }
                else
                {
                    //create file if not exists
                    var exisitingFile = currentDirectory.Files.FirstOrDefault(x => x.Name == command[1]);
                    if (exisitingFile == null)
                    {
                        currentDirectory.Files.Add(new File() { Name = command[1], Size = Convert.ToInt32(command[0]) });
                    }
                }
            }

            while (currentDirectory != null)
            {
                if (currentDirectory.ParentDirectory == null)
                    break;

                currentDirectory = currentDirectory.ParentDirectory;
            }
            return currentDirectory;
        }

        public static List<Directory> GetAllDirectoriesRoot(Directory dir)
        {
            var list = new List<Directory>() { dir };
            GetAllDirectories(dir, list);
            return list;
        }

        private static void GetAllDirectories(Directory dir, List<Directory> list)
        {
            foreach (var child in dir.SubDirectories)
            {
                list.Add(child);
                GetAllDirectories(child, list);
            }        
        }

        public static int GetDirectorySize(Directory dir, int total)
        {
            total += dir.Size; 
            foreach (var child in dir.SubDirectories)
            {
                total += GetDirectorySize(child, 0);
            }

            return total;
        }

        public static int GetSumOfAllDirectoriesWithThreshold(List<Directory> directories, int threshold)
        {
            int total = 0;
            foreach (var dir in directories)
            {
                int size = GetDirectorySize(dir, 0);
                if (size < threshold)
                    total += size;
            }

            return total;
        }

        public static Dictionary<string, int> GetDirectoryStats(Directory dir)
        {
            Random rnd = new Random();
            var directories = GetAllDirectoriesRoot(dir);
            var result = new Dictionary<string, int>();

            foreach (var d in directories)
            {
                //hack to avoid duplicate keys in dictionary of directories
                if (result.ContainsKey(d.Name))
                    d.Name = $"{d.Name}_{rnd.Next(1, 1000)}";

                result.Add(d.Name, GetDirectorySize(d, 0));
            }

            return result;
        }
    }
}
