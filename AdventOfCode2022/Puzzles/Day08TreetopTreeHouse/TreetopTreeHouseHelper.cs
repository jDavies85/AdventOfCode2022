namespace AdventOfCode2022.Puzzles.Day08TreetopTreeHouse
{
    public static class TreetopTreeHouseHelper
    {
        public static int[][] CreateMap(int xSize, int ySize, string[] input)
        {
            var map = new int[ySize][];
            for (int y = 0; y < ySize; y++)
            {
                map[y] = new int[xSize];
                for (int x = 0; x < xSize; x++)
                {
                    map[y][x] = (int)char.GetNumericValue(input[y][x]);
                }
            }

            return map;
        }

        public static bool IsVisible(int y, int x, int[][] map)
        {
            int treeHeight = map[y][x];
            int maxY = map.Length - 1;
            int maxX = map[0].Length - 1;

            //if is edge piece
            if (y == 0 || x == 0 || y == maxY || x == maxX)
                return true;

            bool isVisibleFromTop = true;
            bool isVisibleFromRight = true;
            bool isVisibleFromBottom = true;
            bool isVisibleFromLeft = true;

            for (int i = 0; i < y; i++)
            {
                if (map[i][x] >= treeHeight)
                {
                    isVisibleFromTop = false;
                    break;
                }
            }

            for (int i = maxX; i > x; i--)
            {
                if (map[y][i] >= treeHeight)
                {
                    isVisibleFromRight = false;
                    break;
                }
            }

            for (int i = maxY; i > y; i--)
            {
                if (map[i][x] >= treeHeight)
                {
                    isVisibleFromBottom = false;
                    break;
                }
            }

            for (int i = 0; i < x; i++)
            {
                if(map[y][i] >= treeHeight)
                {
                    isVisibleFromLeft = false;
                    break;
                }
            }

            if (isVisibleFromTop || isVisibleFromRight || isVisibleFromBottom || isVisibleFromLeft)
                return true;
            
            return false;
        }

        public static int CountVisibleTrees(int[][] map)
        {
            int maxY = map.Length;
            int maxX = map[0].Length;
            int visibleTrees = 0;

            for (int y = 0; y < maxY; y++)
            {
                for (int x = 0; x < maxX; x++)
                {
                    if (IsVisible(y, x, map))
                        visibleTrees++;
                }
            }

            return visibleTrees;
        }
    }
}
