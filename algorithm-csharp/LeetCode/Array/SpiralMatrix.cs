/*
 * https://leetcode.com/problems/spiral-matrix/
 * Runtime: 220 ms, faster than 100.00% of C# online submissions for Spiral Matrix.
 * Memory Usage: 29.6 MB, less than 25.00% of C# online submissions for Spiral Matrix.
 * 
 * use direction status to decide path
 * use x,y make a string to check visited
 */

using System.Collections.Generic;

namespace algorithm_csharp
{
    public class SpiralMatrix
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            
            List<int> res = new List<int>();
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0) return res;
             // end trigger m*n == length
             int length = matrix.Length * matrix[0].Length;
            int indexX = 0;
            int indexY = 0;
            int status = 1; //1 rightGo , 2 downGo , 3 leftGo , 4 upGo
            HashSet<string> visited = new HashSet<string>(); // turn point => edge, or already proceessed(by hash)
            while (res.Count < length)
            {
                res.Add(matrix[indexX][indexY]);
                visited.Add($"{indexX.ToString()},{indexY.ToString()}");
                switch (status)
                {
                    case 1: //1 rightGo // if rightGo => turnDown
                        if (indexY == matrix[indexX].Length - 1 || checkExist(indexX, indexY+1, visited))
                        {
                            status = 2;
                            indexX++;
                        }
                        else
                            indexY++;
                        break;
                    case 2: //2 downGo // if downGo => turnLeft
                        if (indexX == matrix.Length - 1 || checkExist(indexX+1, indexY, visited))
                        {
                            status = 3;
                            indexY--;
                        }
                        else
                            indexX++;
                        break;
                    case 3: //3 leftGo // if leftGo => turnUp
                        if (indexY == 0 || checkExist(indexX, indexY-1, visited))
                        {
                            status = 4;
                            indexX--;
                        }
                        else
                            indexY--;
                        break;
                    default: //4 upGo // if upGo => turnright
                        if (checkExist(indexX-1, indexY, visited))
                        {
                            status = 1;
                            indexY++;
                        }
                        else
                            indexX--;
                        break;
                }
            }

            return res;
        }

        public bool checkExist(int x, int y, HashSet<string> datas)
        {
            return datas.Contains($"{x.ToString()},{y.ToString()}");
        }
    }
}
