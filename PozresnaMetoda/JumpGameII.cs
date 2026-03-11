using System;

namespace PozresnaMetoda
{
    internal class JumpGameII
    {
        public int Jump(int[] nums)
        {
            // Če je samo en element, smo že na cilju
            if (nums.Length <= 1)
                return 0;

            int jumps = 0;      // število skokov
            int currentEnd = 0; // konec trenutnega dosega
            int farthest = 0;   // najdlje, kamor lahko pridemo

            for (int i = 0; i < nums.Length - 1; i++)
            {
                // Posodabljamo najdaljši možni doseg
                farthest = Math.Max(farthest, i + nums[i]);

                // Ko pridemo do konca trenutnega dosega,
                // moramo narediti nov skok
                if (i == currentEnd)
                {
                    jumps++;
                    currentEnd = farthest;
                }
            }

            return jumps;
        }
    }
}