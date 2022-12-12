using AdventOfCode2022.Puzzles.Day04CampCleanup;
namespace AdventOfCode2022.Tests
{
    [TestClass]
    public class CampCleanupTests
    {
        [TestMethod]
        public void GetAssignmentPair()
        {
            //Arrange
            var input = new string[] {
            "57-93,9-57",
            "55-55,55-83",
            "55-88,78-88",
            "24-24,24-95" };
            //Act
            var assignmentPair1 = CampCleanupHelper.GetAssignmentPair(input[0]);
            var assignmentPair2 = CampCleanupHelper.GetAssignmentPair(input[1]);
            var assignmentPair3 = CampCleanupHelper.GetAssignmentPair(input[2]);
            var assignmentPair4 = CampCleanupHelper.GetAssignmentPair(input[3]);

            //Assert
            Assert.AreEqual(57, assignmentPair1[0].a);
            Assert.AreEqual(93, assignmentPair1[0].b);
            Assert.AreEqual(9, assignmentPair1[1].a);
            Assert.AreEqual(57, assignmentPair1[1].b);
            Assert.AreEqual(55, assignmentPair2[0].a);
            Assert.AreEqual(55, assignmentPair2[0].b);
            Assert.AreEqual(55, assignmentPair2[1].a);
            Assert.AreEqual(83, assignmentPair2[1].b);
            Assert.AreEqual(55, assignmentPair3[0].a);
            Assert.AreEqual(88, assignmentPair3[0].b);
            Assert.AreEqual(78, assignmentPair3[1].a);
            Assert.AreEqual(88, assignmentPair3[1].b);
            Assert.AreEqual(24, assignmentPair4[0].a);
            Assert.AreEqual(24, assignmentPair4[0].b);
            Assert.AreEqual(24, assignmentPair4[1].a);
            Assert.AreEqual(95, assignmentPair4[1].b);
        }

        [TestMethod]
        public void CampCleanupHelperIsFullyContainedIn()
        {
            //Arrange
            var input1 = new AssignmentPair[2] { new AssignmentPair(57, 93), new AssignmentPair(9, 57) };
            var input2 = new AssignmentPair[2] { new AssignmentPair(55, 55), new AssignmentPair(55, 83) };
            var input3 = new AssignmentPair[2] { new AssignmentPair(55, 88), new AssignmentPair(78, 88) };
            var input4 = new AssignmentPair[2] { new AssignmentPair(24, 24), new AssignmentPair(24, 95) };
            //Act

            //Assert
            Assert.AreEqual(false, input1[0].IsFullyContainedIn(input1[1]));
            Assert.AreEqual(false, input1[1].IsFullyContainedIn(input1[0]));

            Assert.AreEqual(true, input2[0].IsFullyContainedIn(input2[1]));
            Assert.AreEqual(false, input2[1].IsFullyContainedIn(input2[0]));

            Assert.AreEqual(false, input3[0].IsFullyContainedIn(input3[1]));
            Assert.AreEqual(true, input3[1].IsFullyContainedIn(input3[0]));

            Assert.AreEqual(true, input4[0].IsFullyContainedIn(input4[1]));
            Assert.AreEqual(false, input4[1].IsFullyContainedIn(input4[0]));
        }

        [TestMethod]
        public void DoesOverlap()
        {
            /*
             In the above example, the first two pairs (2-4,6-8 and 2-3,4-5) don't overlap, 
            while the remaining four pairs (5-7,7-9, 2-8,3-7, 6-6,4-6, and 2-6,4-8) do overlap:
             */

            //Arrange
            var input1 = new AssignmentPair[2] { new AssignmentPair(2, 4), new AssignmentPair(6, 8) };
            var input2 = new AssignmentPair[2] { new AssignmentPair(2, 3), new AssignmentPair(4, 5) };
            var input3 = new AssignmentPair[2] { new AssignmentPair(5, 7), new AssignmentPair(7, 9) };
            var input4 = new AssignmentPair[2] { new AssignmentPair(2, 8), new AssignmentPair(3, 7) };
            var input5 = new AssignmentPair[2] { new AssignmentPair(6, 6), new AssignmentPair(4, 6) };
            var input6 = new AssignmentPair[2] { new AssignmentPair(2, 6), new AssignmentPair(4, 8) };
            //Act

            //Assert
            Assert.AreEqual(false, input1[0].DoesOverlap(input1[1]));

            Assert.AreEqual(false, input2[0].DoesOverlap(input2[1]));

            Assert.AreEqual(true, input3[0].DoesOverlap(input3[1]));

            Assert.AreEqual(true, input4[0].DoesOverlap(input4[1]));

            Assert.AreEqual(true, input5[0].DoesOverlap(input5[1]));

            Assert.AreEqual(true, input6[0].DoesOverlap(input6[1]));
        }
    }
}
