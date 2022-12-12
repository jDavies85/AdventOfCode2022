namespace AdventOfCode2022.Puzzles.Day06TuningTrouble
{
    public static class TuningTroubleHelper
    {
        public static int GetStartOfPacketMarkerIndex(string input)
        {
            return GetIndexOfUniqueCharactersByCount(4, input);
        }

        public static int GetStartOfMessageMarkerIndex(string input)
        {
            return GetIndexOfUniqueCharactersByCount(14, input);
        }

        private static int GetIndexOfUniqueCharactersByCount(int count, string input)
        {
            int index = 0;
            int uniqueCharacters = 0;
            List<char> characters = new List<char>();

            foreach (var character in input)
            {
                if (characters.Contains(character))
                {
                    //remove everything from the duplicate character and preceding
                    var duplicateIndex = Array.IndexOf(characters.ToArray(), character);
                    characters = new List<char>(characters.Skip(duplicateIndex + 1))
                    {
                        //add in new character and recount array
                        character
                    };
                    //recount array
                    uniqueCharacters = characters.Count;
                }
                else
                {
                    characters.Add(character);
                    uniqueCharacters++;

                    if (uniqueCharacters == count)
                    {
                        return index + 1;
                    }
                }
                index++;
            }
            return index;
        }
    }
}
