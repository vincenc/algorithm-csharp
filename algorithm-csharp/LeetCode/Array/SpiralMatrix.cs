using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_csharp
{
    public class SpiralMatrix
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> res = new List<int>();
            int length = matrix.Sum(n => n.Length);
            // status rightGo,downGo,leftGo,upGo
            // turn point => edge, or already proceessed(by hash)
            // if rightGo => turnDown
            // if downGo => turnLeft
            // if leftGo => turnUp
            // if upGo => turnright
            // end trigger m*n == length
            int indexX = 0;
            int indexY = 0;
            int status = 1; //1 rightGo , 2 downGo , 3 leftGo , 4 upGo
            HashSet<int[]> visited = new HashSet<int[]>();
            while (res.Count < length)
            {
                res.Add(matrix[indexX][indexY]);
                visited.Add(new[] {indexX, indexY});
                switch (status)
                {
                    case 1: //1 rightGo
                        if (indexY == matrix[indexX].Length - 1 || visited.Contains(new []{indexX,indexY}))
                        {
                            indexX++;
                        }
                        else
                        {
                            indexY++;
                        }                        
                        break;
                    case 2: //2 downGo
                        if (indexX == matrix.Length - 1)
                        {
                            indexY--;
                        }
                        else
                        {
                            indexX++;
                        }
                        break;
                    case 3: //3 leftGo
                        if (indexY == 0)
                        {
                            indexX--;
                        }
                        else
                        {
                            indexY--;
                        }
                        break;
                    default: //4 upGo
                        if (indexY == 0)
                        {
                            indexX--;
                        }
                        else
                        {
                            indexY--;
                        }
                        break;
                }
            }

            return new int[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };
        }

        private bool checkExist(int x, int y , HashSet<int[]> datas )
        {
            return false;
        }
    }
}
