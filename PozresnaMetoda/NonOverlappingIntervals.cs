using System;

namespace PozresnaMetoda
{
    internal class NonOverlappingIntervals
    {
        public int EraseOverlapIntervals(int[][] intervals)
        {
            // Če ni intervalov ali je samo en, ni nič za odstranit
            if (intervals.Length <= 1)
                return 0;

            // Intervale uredimo po končnem času naraščajoče
            Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));

            // Štejemo koliko intervalov lahko obdržimo brez prekrivanja
            int count = 1;

            // Končni čas zadnjega izbranega intervala
            int end = intervals[0][1];

            for (int i = 1; i < intervals.Length; i++)
            {
                // Če se trenutni interval začne po ali ob koncu prejšnjega,
                // ga lahko obdržimo
                if (intervals[i][0] >= end)
                {
                    count++;
                    end = intervals[i][1];
                }
            }

            // Rezultat: vsi intervali - tisti, ki jih lahko obdržimo
            return intervals.Length - count;
        }
    }
}