using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_csharp.LeetCode.Graph
{
    class Relation
    {
        public bool Knows(int a, int b)
        {
            return true;
        }
    }

    class FindTheCelebrity : Relation
    {
        public int FindCelebrity(int n)
        {
            // all other know the result
            // the result know no one
            // if a == result => know(1~n,a) == true
            // if a == result => know(a,1~n) == false

            // n * n relationship => check n time can remove 2/n
            // 1,2 true => 1 X result
            // 2,3 false => 3 X result   2 dont know 3

            int candidate = 0;

            for (int i = 1; i < n; i++)
            {
                if (this.Knows(candidate, i))
                {
                    candidate = i;
                }
            }

            if (candidate == 0) // 0 dont know every one => all know 0?
            {
                if (checkAllKnowCandidate(0, n))
                {
                    return 0;
                }
                return -1;
            }
            else // some one know n => all know n? n dont know all?
            {
                if (checkQualifyCandidate(candidate, n))
                {
                    return candidate;
                }
                return -1;
            }
        }

        private bool checkQualifyCandidate(int candidate, int n)
        {
            bool result = checkAllKnowCandidate(candidate, n) &&
                checkCandidateDontKnowAll(candidate, n);

            return result;
        }

        private bool checkAllKnowCandidate(int candidate, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (i != candidate && this.Knows(i, candidate) == false)
                {
                    return false;
                }
            }
            return true;
        }

        private bool checkCandidateDontKnowAll(int candidate, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (i != candidate && this.Knows(candidate, i) == true)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
