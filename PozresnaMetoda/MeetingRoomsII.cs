using System;

namespace PozresnaMetoda
{
    internal class MeetingRoomsII
    {
        public int MinMeetingRooms(int[][] intervals)
        {
            if (intervals.Length == 0)
                return 0;

            int n = intervals.Length;

            // Ločeno shranimo vse začetke in vse konce
            int[] starts = new int[n];
            int[] ends = new int[n];

            for (int i = 0; i < n; i++)
            {
                starts[i] = intervals[i][0];
                ends[i] = intervals[i][1];
            }

            // Uredimo začetke in konce
            Array.Sort(starts);
            Array.Sort(ends);

            int rooms = 0;      // trenutno potrebne sobe
            int maxRooms = 0;   // največ sob, kar jih potrebujemo
            int s = 0;          // kazalec za začetke
            int e = 0;          // kazalec za konce

            while (s < n)
            {
                // Če se nov sestanek začne pred koncem najzgodnejšega trenutnega,
                // potrebujemo novo sobo
                if (starts[s] < ends[e])
                {
                    rooms++;
                    maxRooms = Math.Max(maxRooms, rooms);
                    s++;
                }
                else
                {
                    // Če se je en sestanek že končal, sprostimo sobo
                    rooms--;
                    e++;
                }
            }

            return maxRooms;
        }
    }
}