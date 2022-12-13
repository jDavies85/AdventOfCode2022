using AdventOfCode2022.Puzzles.Day06TuningTrouble;

namespace AdventOfCode2022.Tests
{
    [TestClass]
    public class TuningTroubleTests
    {
        public TuningTroubleTests()
        {
            /*
             mjqjpqmgbljsphdztnvjfqwrcgsmlb: first marker after character 7
             bvwbjplbgvbhsrlpgdmjqwftvncz: first marker after character 5
             nppdvjthqldpwncqszvftbrmjlhg: first marker after character 6
             nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg: first marker after character 10
             zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw: first marker after character 11
             */
        }

        [TestMethod]
        public void GivenTestInput1ResultIs7()
        {
            //Arrange
            string testInput1 = "mjqjpqmgbljsphdztnvjfqwrcgsmlb";
            //Act
            var result = TuningTroubleHelper.GetStartOfPacketMarkerIndex(testInput1);
            //Assert
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void GivenTestInput2ResultIs5()
        {
            //Arrange
            string testInput = "bvwbjplbgvbhsrlpgdmjqwftvncz";
            //Act
            var result = TuningTroubleHelper.GetStartOfPacketMarkerIndex(testInput);
            //Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void GivenTestInput3ResultIs6()
        {
            //Arrange
            string testInput = "nppdvjthqldpwncqszvftbrmjlhg";
            //Act
            var result = TuningTroubleHelper.GetStartOfPacketMarkerIndex(testInput);
            //Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void GivenTestInput4ResultIs10()
        {
            //Arrange
            string testInput = "nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg";
            //Act
            var result = TuningTroubleHelper.GetStartOfPacketMarkerIndex(testInput);
            //Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void GivenTestInput5ResultIs11()
        {
            //Arrange
            string testInput = "zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw";
            //Act
            var result = TuningTroubleHelper.GetStartOfPacketMarkerIndex(testInput);
            //Assert
            Assert.AreEqual(11, result);
        }

        [TestMethod]
        public void GetStartOfMessageMarker()
        {
            var testInput1 = "mjqjpqmgbljsphdztnvjfqwrcgsmlb"; //first marker after character 19
            var testInput2 = "bvwbjplbgvbhsrlpgdmjqwftvncz"; //first marker after character 23
            var testInput3 = "nppdvjthqldpwncqszvftbrmjlhg"; //first marker after character 23
            var testInput4 = "nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg"; //first marker after character 29
            var testInput5 = "zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw:"; //first marker after character 26

            Assert.AreEqual(19, TuningTroubleHelper.GetStartOfMessageMarkerIndex(testInput1));
            Assert.AreEqual(23, TuningTroubleHelper.GetStartOfMessageMarkerIndex(testInput2));
            Assert.AreEqual(23, TuningTroubleHelper.GetStartOfMessageMarkerIndex(testInput3));
            Assert.AreEqual(29, TuningTroubleHelper.GetStartOfMessageMarkerIndex(testInput4));
            Assert.AreEqual(26, TuningTroubleHelper.GetStartOfMessageMarkerIndex(testInput5));
        }
    }
}
