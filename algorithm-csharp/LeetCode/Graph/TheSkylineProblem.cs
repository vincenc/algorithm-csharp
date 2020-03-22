using System;
using System.Collections.Generic;

namespace algorithm_csharp
{
    public class TheSkylineProblem
    {
        List<Building> buildingList = new List<Building>();
        public IList<IList<int>> GetSkyline(int[][] buildings)
        {
            int minLi = 0;
            int maxRi = 0;
            for (int i = 0; i < buildings.Length; i++)
            {
                buildingList.Add(new Building());
                buildingList[i].Li = buildings[i][0];
                buildingList[i].Ri = buildings[i][1];
                maxRi = Math.Max(maxRi, buildingList[i].Ri);
                buildingList[i].Hi = buildings[i][2];
            }

            buildingList.Sort();
            minLi = buildingList[0].Li;


            for (int i = 0; i < buildingList.Count-1; i++)
            {
                int targetBuildingIndex = i + 1;
                bool isCoverNext = true;
                do
                {
                    // check cover
                    isCoverNext = buildingList[i].IsCover(buildingList[targetBuildingIndex]);
                    if (isCoverNext)
                    {
                        // change skyline point
                        buildingList[i].CoverSkyLinePoint(buildingList[targetBuildingIndex]);
                        targetBuildingIndex++;
                    }
                }
                while (isCoverNext);
            }

            IList<IList<int>> result = new List<IList<int>>();
            Point forRightGroundPoint = null;
            for (int i = 0; i < buildingList.Count; i++)
            {
                Building cur = buildingList[i];

                if (forRightGroundPoint != null && cur.Li > forRightGroundPoint.HorizonPotition)
                {
                    result.Add(new List<int>(){ forRightGroundPoint.HorizonPotition, forRightGroundPoint.VerticalHight });
                }
                if (cur.leftSkyLinePoint != null)
                {
                    result.Add(new List<int>() { cur.leftSkyLinePoint.HorizonPotition , cur.leftSkyLinePoint.VerticalHight });
                }

                if (cur.rightSkyLinePoint != null)
                {
                    forRightGroundPoint = cur.rightSkyLinePoint;
                }
            }

            return result;
        }

        class Point
        {
            public int VerticalHight { get; set; }
            public int HorizonPotition { get; set; }
            //public Point(int horizonPosition, int verticalHight)
            //{
            //    VerticalHight = verticalHight;
            //    HorizonPotition = horizonPosition;
            //}
        }

        class Building : IComparable<Building>
        {
            public int Li { get; set; }
            public int Ri { get; set; }
            public int Hi { get; set; }
            public Point leftSkyLinePoint;
            public Point rightSkyLinePoint;

            public void SetBuilding(int li, int ri, int hi)
            {
                Li = li;
                Ri = ri;
                Hi = hi;

            }

            public void ResetSkyLingPoint()
            {
                leftSkyLinePoint = new Point { HorizonPotition = Hi, VerticalHight = Li };
                rightSkyLinePoint = new Point { HorizonPotition = Hi, VerticalHight = Li };
            }

            public void CoverSkyLinePoint(Building target)
            {
                Building leftBuilding = this;
                Building rightBuilding = target;

                // left point 
                if (leftBuilding.Li == rightBuilding.Li)
                {
                    if (leftBuilding.Hi >= rightBuilding.Hi) rightBuilding.leftSkyLinePoint = null;
                    else leftBuilding.leftSkyLinePoint = null;
                }
                else
                {
                    if (leftBuilding.Hi >= rightBuilding.Hi)
                    {
                        rightBuilding.leftSkyLinePoint.HorizonPotition = leftBuilding.Ri;
                    }
                }

                // right point
                if (leftBuilding.Ri == rightBuilding.Ri)
                {
                    if (leftBuilding.rightSkyLinePoint != null && rightBuilding.rightSkyLinePoint != null)
                    {
                        leftBuilding = null;
                    }
                }
                else if (leftBuilding.Ri < rightBuilding.Ri)
                {
                    leftBuilding.rightSkyLinePoint = null;
                }
                else // left > right 
                {
                    rightBuilding.rightSkyLinePoint = null; 
                }
            }

            public Building()
            {
            }
            public Building(int li, int ri, int hi)
            {
                Li = li;
                Ri = ri;
                Hi = hi;
            }
            public bool IsCover(Building target)
            {
                if (this.Ri >= target.Li)
                    return true;

                return false;
            }

            public int CompareTo(Building other)
            {
                return this.Li.CompareTo(other.Li);
            }
        }
    }
}
