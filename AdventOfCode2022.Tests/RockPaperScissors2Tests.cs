using AdventOfCode2022.Puzzles.Day02RockPaperScissors;

namespace AdventOfCode2022.Tests
{
    [TestClass]
    public class RockPaperScissors2Tests
    {
        /*
            A = Rock
            B = Paper
            C = Scissors

            X = Rock
            Y = Paper
            Z = Scissors

            Rock = 1
            Paper = 2
            Scissors = 3
            Win = 6
            Draw = 3
            Loss = 0

            X means you need to lose, 
            Y means you need to end the round in a draw, 
            Z means you need to win.
               R P S
            R |3|0|6|
            P |6|3|0|
            S |0|6|3|
         */
        //Given a result of (A Z) I must return a score of 8, 6 for the win, 2 for picking paper

        [TestMethod]
        public void ElfChoosesRockAndPlayerHasToWinReturnScoreOf8()
        {
            //Arrange
            var puzzle = new RockPaperScissors2();
            //Act
            var score = puzzle.EvaluateGame("A Z");
            //Assert
            Assert.AreEqual(8, score);
        }

        [TestMethod]
        public void ElfChoosesRockAndPlayerHasToLoseReturnScoreOf3()
        {
            //Arrange
            var puzzle = new RockPaperScissors2();
            //Act
            var score = puzzle.EvaluateGame("A X");
            //Assert
            Assert.AreEqual(3, score);
        }

        [TestMethod]
        public void ElfChoosesRockAndPlayerHasToDrawReturnScoreOf4()
        {
            //Arrange
            var puzzle = new RockPaperScissors2();
            //Act
            var score = puzzle.EvaluateGame("A Y");
            //Assert
            Assert.AreEqual(4, score);
        }

        [TestMethod]
        public void ElfChoosesPaperAndPlayerHasToWinReturnScoreOf9()
        {
            //Arrange
            var puzzle = new RockPaperScissors2();
            //Act
            var score = puzzle.EvaluateGame("B Z");
            //Assert
            Assert.AreEqual(9, score);
        }

        [TestMethod]
        public void ElfChoosesPaperAndPlayerHasToLoseReturnScoreOf1()
        {
            //Arrange
            var puzzle = new RockPaperScissors2();
            //Act
            var score = puzzle.EvaluateGame("B X");
            //Assert
            Assert.AreEqual(1, score);
        }

        [TestMethod]
        public void ElfChoosesPaperAndPlayerHasToDrawReturnScoreOf5()
        {
            //Arrange
            var puzzle = new RockPaperScissors2();
            //Act
            var score = puzzle.EvaluateGame("B Y");
            //Assert
            Assert.AreEqual(5, score);
        }

        [TestMethod]
        public void ElfChoosesScissorsAndPlayerHasToWinReturnScoreOf7()
        {
            //Arrange
            var puzzle = new RockPaperScissors2();
            //Act
            var score = puzzle.EvaluateGame("C Z");
            //Assert
            Assert.AreEqual(7, score);
        }

        [TestMethod]
        public void ElfChoosesScissorsAndPlayerHasToLoseReturnScoreOf2()
        {
            //Arrange
            var puzzle = new RockPaperScissors2();
            //Act
            var score = puzzle.EvaluateGame("C X");
            //Assert
            Assert.AreEqual(2, score);
        }

        [TestMethod]
        public void ElfChoosesScissorsAndPlayerHasToDrawReturnScoreOf6()
        {
            //Arrange
            var puzzle = new RockPaperScissors2();
            //Act
            var score = puzzle.EvaluateGame("C Y");
            //Assert
            Assert.AreEqual(6, score);
        }
    }
}