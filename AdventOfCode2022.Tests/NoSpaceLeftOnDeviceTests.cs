using AdventOfCode2022.Puzzles.Day07NoSpaceLeftOnDevice;

namespace AdventOfCode2022.Tests
{
    [TestClass]
    public class NoSpaceLeftOnDeviceTests
    {
        [TestMethod]
        public void CanGetInput()
        {
            var input = File.ReadAllLines("./TestInput/input_07_test_input_1.txt");

            Assert.AreEqual("$ cd /", input[0]);
        }

        [TestMethod]
        public void CanBuildFileSystem()
        {
            var input = File.ReadAllLines("./TestInput/input_07_test_input_1.txt");
            var fileSystem = NoSpaceLeftOnDeviceHelper.BuildFileSystem(input);

            Assert.AreEqual(2, fileSystem.SubDirectories.Count);
            Assert.AreEqual(2, fileSystem.Files.Count);
        }

        [TestMethod]
        public void Given_Directory_E_Size_Is_584()
        {
            var input = File.ReadAllLines("./TestInput/input_07_test_input_1.txt");
            var fileSystem = NoSpaceLeftOnDeviceHelper.BuildFileSystem(input);
            var dir = fileSystem.SubDirectories[0].SubDirectories[0];
            var total = NoSpaceLeftOnDeviceHelper.GetDirectorySize(dir, 0);

            Assert.AreEqual("e", dir.Name);
            Assert.AreEqual(584, total);
        }

        [TestMethod]
        public void Given_Directory_A_Size_Is_94853()
        {
            var input = File.ReadAllLines("./TestInput/input_07_test_input_1.txt");
            var fileSystem = NoSpaceLeftOnDeviceHelper.BuildFileSystem(input);
            var dir = fileSystem.SubDirectories[0];
            var total = NoSpaceLeftOnDeviceHelper.GetDirectorySize(dir, 0);

            Assert.AreEqual("a", dir.Name);
            Assert.AreEqual(94853, total);
        }

        [TestMethod]
        public void Given_Directory_D_Size_Is_24933642()
        {
            var input = File.ReadAllLines("./TestInput/input_07_test_input_1.txt");
            var fileSystem = NoSpaceLeftOnDeviceHelper.BuildFileSystem(input);
            var dir = fileSystem.SubDirectories[1];
            var total = NoSpaceLeftOnDeviceHelper.GetDirectorySize(dir, 0);

            Assert.AreEqual("d", dir.Name);
            Assert.AreEqual(24933642, total);
        }

        [TestMethod]
        public void Given_The_Root_Directory_Size_Is_48381165()
        {
            var input = File.ReadAllLines("./TestInput/input_07_test_input_1.txt");
            var fileSystem = NoSpaceLeftOnDeviceHelper.BuildFileSystem(input);
            var total = NoSpaceLeftOnDeviceHelper.GetDirectorySize(fileSystem, 0);

            Assert.AreEqual("/", fileSystem.Name);
            Assert.AreEqual(48381165, total);
        }

        [TestMethod]
        public void GetAllDirectoriesReturns4Directories()
        {
            var input = File.ReadAllLines("./TestInput/input_07_test_input_1.txt");
            var fileSystem = NoSpaceLeftOnDeviceHelper.BuildFileSystem(input);
            var directories = NoSpaceLeftOnDeviceHelper.GetAllDirectoriesRoot(fileSystem);

            Assert.AreEqual(4, directories.Count);
            Assert.AreEqual(true, directories.FirstOrDefault(x => x.Name == "/") != null);
            Assert.AreEqual(true, directories.FirstOrDefault(x => x.Name == "a") != null);
            Assert.AreEqual(true, directories.FirstOrDefault(x => x.Name == "e") != null);
            Assert.AreEqual(true, directories.FirstOrDefault(x => x.Name == "d") != null);
        }

        [TestMethod]
        public void Given_The_Sum_Of_All_Lists_Result_Is_95437()
        {
            var input = File.ReadAllLines("./TestInput/input_07_test_input_1.txt");
            var fileSystem = NoSpaceLeftOnDeviceHelper.BuildFileSystem(input);
            var directories = NoSpaceLeftOnDeviceHelper.GetAllDirectoriesRoot(fileSystem);
            var total = NoSpaceLeftOnDeviceHelper.GetSumOfAllDirectoriesWithThreshold(directories, 100000);

            Assert.AreEqual(95437, total);
        }

        [TestMethod]
        public void GetDirectoryStatsReturnsCorrectResults()
        {
            var input = File.ReadAllLines("./TestInput/input_07_test_input_1.txt");
            var fileSystem = NoSpaceLeftOnDeviceHelper.BuildFileSystem(input);
            var directories = NoSpaceLeftOnDeviceHelper.GetDirectoryStats(fileSystem);
            var highest = directories.OrderByDescending(x => x.Value).First().Value;
            Assert.AreEqual(4, directories.Count);
            Assert.AreEqual(48381165, directories["/"]);
            Assert.AreEqual(24933642, directories["d"]);
            Assert.AreEqual(94853, directories["a"]);
            Assert.AreEqual(584, directories["e"]);
            Assert.AreEqual(48381165, highest);
        }

        [TestMethod]
        public void Given_A_Total_Disk_Space_Of_70000000_And_A_Required_Free_Space_Of_30000000_Directory_D_Will_Be_Deleted()
        {
            int totalDiskSpace = 70000000;
            int requiredDiskSpace = 30000000;

            var input = File.ReadAllLines("./TestInput/input_07_test_input_1.txt");
            var fileSystem = NoSpaceLeftOnDeviceHelper.BuildFileSystem(input);
            var directories = NoSpaceLeftOnDeviceHelper.GetDirectoryStats(fileSystem);

            int totalDirectorySize = directories["/"];
            int currentUnusedFreeSpace = totalDiskSpace - totalDirectorySize;
            int requiredDeletedSpace = requiredDiskSpace - currentUnusedFreeSpace;

            var directoryToDelete = directories.Where(x => x.Value >= requiredDeletedSpace).OrderBy(x => x.Value).First();

            Assert.AreEqual(48381165, totalDirectorySize);
            Assert.AreEqual(21618835, currentUnusedFreeSpace);
            Assert.AreEqual(8381165, requiredDeletedSpace);
            Assert.AreEqual("d", directoryToDelete.Key);
        }
    }
}
