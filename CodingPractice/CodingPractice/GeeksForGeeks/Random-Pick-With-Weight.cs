using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.GeeksForGeeks
{
    class Random_Pick_With_Weight
    {
        List<int> psum = new List<int>();
        int tot = 0;
        Random rand = new Random();

        public Random_Pick_With_Weight(int[] w)
        {
            foreach (int x in w)
            {
                tot += x;
                psum.Add(tot);
            }
        }

        public int pickIndex()
        {
            int targ = rand.Next(tot);

            int lo = 0;
            int hi = psum.Count - 1;
            while (lo != hi)
            {
                int mid = (lo + hi) / 2;
                if (targ >= psum[mid]) lo = mid + 1;
                else hi = mid;
            }
            return lo;
        }
    }
}
