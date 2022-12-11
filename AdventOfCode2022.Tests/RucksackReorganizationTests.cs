using AdventOfCode2022.Puzzles.Day03RucksackReorganization;

namespace AdventOfCode2022.Tests
{
    [TestClass]
    public class RucksackReorganizationTests
    {
        [TestMethod]
        public void TestClass1()
        {
            //Arrange
            var puzzle = new RucksackReorganization();
            var alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var priorityValueAsserts = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52 };
            //Act
            List<int> priorityValues = new List<int>();
            foreach (var character in alphabet)
            {
                priorityValues.Add(puzzle.GetCharacterValue(character));
            }
            //Assert
            for (int i = 0; i < 52; i++)
            {
                Assert.AreEqual(priorityValueAsserts[i], priorityValues[i]);
            }
        }

        [TestMethod]
        public void CommonCharacterIsD()
        {
            var puzzle = new RucksackReorganization();

            var commonCharacter = puzzle.GetCommonCharacter("dWlhclDHd", "FvDCCDfFq");
            Assert.AreEqual('D', commonCharacter);
        }
    }
}
