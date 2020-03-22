/*
 * 
 * https://leetcode.com/problems/reorganize-string/
 * 
 * Runtime: 84 ms, faster than 80.86% of C# online submissions for Reorganize String.
 * Memory Usage: 23 MB, less than 20.00% of C# online submissions for Reorganize String.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace algorithm_csharp
{
    class ReorganizeStrings
    {
        public string ReorganizeString(string S)
        {
            // longest should be shorter than half => aab ok 3+1/2 aaabb 5+1/2  => aabb 4+1/2 
            // limit => n+1/2
            int maxCountLimit = (S.Length + 1) / 2;
            // sort => nlogn
            // getmaxCount => N

            // getmaxCount => N
            // group N
            // space N
            char maxCountsChar = ' ';
            int maxCounts = 0;
            Dictionary<char, int> charCounts = new Dictionary<char, int>();
            for (int i = 0; i < S.Length; i++)
            {
                int orgCount = 0;
                if (charCounts.ContainsKey(S[i]))
                {
                    orgCount = charCounts[S[i]];
                }
                orgCount = orgCount + 1;
                charCounts[S[i]] = orgCount;
                if (orgCount > maxCounts)
                {
                    if (orgCount > (S.Length + 1) / 2) return "";
                    maxCounts = orgCount;
                    maxCountsChar = S[i];
                }
            }
            

            // put to position by even places and odds places
            char[] result = new char[S.Length];
            char curChar = maxCountsChar;
            bool even = true;
            for (int i = 0; i < S.Length; i = i + 2)
            {
                charCounts[curChar]--;
                result[i] = curChar;
                if (charCounts[curChar] == 0)
                {
                    charCounts.Remove(curChar);
                    curChar = charCounts.Keys.FirstOrDefault();
                }
                if (i + 2 >= S.Length && even)
                {
                    i = -1;  //i +2 =1  odds first position
                    even = false;
                }
            }
            return string.Concat(result);
            // priority queue
            // add all nlogn
            // get max o1
            // 26 char

            // put to position by even places and odds places
        }

    }
}
