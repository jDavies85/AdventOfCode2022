using AdventOfCode2022.Puzzles.Day08TreetopTreeHouse;

namespace AdventOfCode2022.Tests
{
    [TestClass]
    public class TreetopTreeHouseTests
    {

        [TestMethod]
        public void CanCreateMap()
        {
            var input = File.ReadAllLines("./TestInput/input_08_test_input_1.txt");
            var x = input[0].Length;
            var y = input.Length;
            var map = TreetopTreeHouseHelper.CreateMap(x, y, input);

            /*
             30373
             25512
             65332
             33549
             35390
             */
            Assert.AreEqual(3, map[0][0]);
            Assert.AreEqual(0, map[0][1]);
            Assert.AreEqual(3, map[0][2]);
            Assert.AreEqual(7, map[0][3]);
            Assert.AreEqual(3, map[0][4]);

            Assert.AreEqual(2, map[1][0]);
            Assert.AreEqual(6, map[2][0]);
            Assert.AreEqual(3, map[3][0]);
            Assert.AreEqual(3, map[4][0]);
        }

        [TestMethod]
        public void IsEdgePiece()
        {
            //Top Row    0,0 0,1 0,2 0,3 0,4
            //Left Side  0,0 1,0 2,0 3,0 4,0
            //Right Side 0,4 1,4 2,4 3,4 4,4
            //Bottom Row 4,0 4,1 4,2 4,3 4,4
            var input = File.ReadAllLines("./TestInput/input_08_test_input_1.txt");
            var x = input[0].Length;
            var y = input.Length;
            var map = TreetopTreeHouseHelper.CreateMap(x, y, input);

            Assert.AreEqual(true, TreetopTreeHouseHelper.IsVisible(0, 0, map));
            Assert.AreEqual(true, TreetopTreeHouseHelper.IsVisible(0, 1, map));
            Assert.AreEqual(true, TreetopTreeHouseHelper.IsVisible(0, 2, map));
            Assert.AreEqual(true, TreetopTreeHouseHelper.IsVisible(0, 3, map));
            Assert.AreEqual(true, TreetopTreeHouseHelper.IsVisible(0, 4, map));
            Assert.AreEqual(true, TreetopTreeHouseHelper.IsVisible(1, 0, map));
            Assert.AreEqual(true, TreetopTreeHouseHelper.IsVisible(2, 0, map));
            Assert.AreEqual(true, TreetopTreeHouseHelper.IsVisible(3, 0, map));
            Assert.AreEqual(true, TreetopTreeHouseHelper.IsVisible(1, 4, map));
            Assert.AreEqual(true, TreetopTreeHouseHelper.IsVisible(2, 4, map));
            Assert.AreEqual(true, TreetopTreeHouseHelper.IsVisible(3, 4, map));
            Assert.AreEqual(true, TreetopTreeHouseHelper.IsVisible(4, 0, map));
            Assert.AreEqual(true, TreetopTreeHouseHelper.IsVisible(4, 1, map));
            Assert.AreEqual(true, TreetopTreeHouseHelper.IsVisible(4, 2, map));
            Assert.AreEqual(true, TreetopTreeHouseHelper.IsVisible(4, 3, map));
            Assert.AreEqual(true, TreetopTreeHouseHelper.IsVisible(4, 4, map));
        }

        [TestMethod]
        public void Given_Y_1_And_X_1_Value_Is_5_And_IsVisible_Is_True()
        {
            var input = File.ReadAllLines("./TestInput/input_08_test_input_1.txt");
            var x = input[0].Length;
            var y = input.Length;
            var map = TreetopTreeHouseHelper.CreateMap(x, y, input);

            Assert.AreEqual(5, map[1][1]);
            Assert.AreEqual(true, TreetopTreeHouseHelper.IsVisible(1, 1, map));
        }

        [TestMethod]
        public void Given_Y_1_And_X_2_Value_Is_5_And_IsVisible_Is_True()
        {
            var input = File.ReadAllLines("./TestInput/input_08_test_input_1.txt");
            var x = input[0].Length;
            var y = input.Length;
            var map = TreetopTreeHouseHelper.CreateMap(x, y, input);

            Assert.AreEqual(5, map[1][2]);
            Assert.AreEqual(true, TreetopTreeHouseHelper.IsVisible(1, 2, map));
        }

        [TestMethod]
        public void Given_Y_1_And_X_3_Value_Is_1_And_IsVisible_Is_False()
        {
            var input = File.ReadAllLines("./TestInput/input_08_test_input_1.txt");
            var x = input[0].Length;
            var y = input.Length;
            var map = TreetopTreeHouseHelper.CreateMap(x, y, input);

            Assert.AreEqual(1, map[1][3]);
            Assert.AreEqual(false, TreetopTreeHouseHelper.IsVisible(1, 3, map));
        }

        [TestMethod]
        public void Given_Y_2_And_X_1_Value_Is_5_And_IsVisible_Is_True()
        {
            var input = File.ReadAllLines("./TestInput/input_08_test_input_1.txt");
            var x = input[0].Length;
            var y = input.Length;
            var map = TreetopTreeHouseHelper.CreateMap(x, y, input);

            Assert.AreEqual(5, map[2][1]);
            Assert.AreEqual(true, TreetopTreeHouseHelper.IsVisible(2, 1, map));
        }

        [TestMethod]
        public void Given_Y_2_And_X_2_Value_Is_3_And_IsVisible_Is_False()
        {
            var input = File.ReadAllLines("./TestInput/input_08_test_input_1.txt");
            var x = input[0].Length;
            var y = input.Length;
            var map = TreetopTreeHouseHelper.CreateMap(x, y, input);

            Assert.AreEqual(3, map[2][2]);
            Assert.AreEqual(false, TreetopTreeHouseHelper.IsVisible(2, 2, map));
        }

        [TestMethod]
        public void Given_Y_2_And_X_3_Value_Is_3_And_IsVisible_Is_True()
        {
            var input = File.ReadAllLines("./TestInput/input_08_test_input_1.txt");
            var x = input[0].Length;
            var y = input.Length;
            var map = TreetopTreeHouseHelper.CreateMap(x, y, input);

            Assert.AreEqual(3, map[2][3]);
            Assert.AreEqual(true, TreetopTreeHouseHelper.IsVisible(2, 3, map));
        }

        [TestMethod]
        public void Given_Y_3_And_X_1_Value_Is_3_And_IsVisible_Is_False()
        {
            var input = File.ReadAllLines("./TestInput/input_08_test_input_1.txt");
            var x = input[0].Length;
            var y = input.Length;
            var map = TreetopTreeHouseHelper.CreateMap(x, y, input);

            Assert.AreEqual(3, map[3][1]);
            Assert.AreEqual(false, TreetopTreeHouseHelper.IsVisible(3, 1, map));
        }

        [TestMethod]
        public void Given_Y_3_And_X_2_Value_Is_5_And_IsVisible_Is_True()
        {
            var input = File.ReadAllLines("./TestInput/input_08_test_input_1.txt");
            var x = input[0].Length;
            var y = input.Length;
            var map = TreetopTreeHouseHelper.CreateMap(x, y, input);

            Assert.AreEqual(5, map[3][2]);
            Assert.AreEqual(true, TreetopTreeHouseHelper.IsVisible(3, 2, map));
        }

        [TestMethod]
        public void Given_Y_3_And_X_3_Value_Is_4_And_IsVisible_Is_False()
        {
            var input = File.ReadAllLines("./TestInput/input_08_test_input_1.txt");
            var x = input[0].Length;
            var y = input.Length;
            var map = TreetopTreeHouseHelper.CreateMap(x, y, input);

            Assert.AreEqual(4, map[3][3]);
            Assert.AreEqual(false, TreetopTreeHouseHelper.IsVisible(3, 3, map));
        }

        [TestMethod]
        public void There_Are_21_Visible_Trees()
        {
            var input = File.ReadAllLines("./TestInput/input_08_test_input_1.txt");
            var x = input[0].Length;
            var y = input.Length;
            var map = TreetopTreeHouseHelper.CreateMap(x, y, input);

            Assert.AreEqual(21, TreetopTreeHouseHelper.CountVisibleTrees(map));
        }
    }
}
