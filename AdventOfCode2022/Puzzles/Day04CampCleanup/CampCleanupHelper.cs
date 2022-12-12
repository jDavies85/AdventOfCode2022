namespace AdventOfCode2022.Puzzles.Day04CampCleanup
{
    public static class CampCleanupHelper
    {
        public static bool IsFullyContainedIn(this AssignmentPair pair1, AssignmentPair pair2)
        {
            var result = pair1.a >= pair2.a && pair1.b <= pair2.b;

            //if (result)
            //    Console.WriteLine("A is fully contained in B");
            //else
            //    Console.WriteLine("A is NOT fully contained in B");

            //Console.WriteLine($"A: {pair1.a} - {pair1.b}");
            //Console.WriteLine($"B: {pair2.a} - {pair2.b}");

            return result;        
        }

        public static bool DoesOverlap(this AssignmentPair pair1, AssignmentPair pair2)
        {
            var result = pair1.b >= pair2.a && pair1.a <= pair2.b;

            return result;
        }

        public static AssignmentPair[] GetAssignmentPair(string input)
        {
            var pairs = input.Split(',');
            var result = new AssignmentPair[2];

            for (int i = 0; i < pairs.Length; i++)
            {
                var split = pairs[i].Split('-');
                result[i] = new AssignmentPair(Convert.ToInt32(split[0]), Convert.ToInt32(split[1]));
            }

            return result;
        }
    }
}
