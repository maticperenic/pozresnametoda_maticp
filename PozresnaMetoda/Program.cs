using System;

namespace PozresnaMetoda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ============================
            // 1. NON-OVERLAPPING INTERVALS
            // ============================
            int[][] intervals1 = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 3, 4 },
                new int[] { 1, 3 }
            };

            NonOverlappingIntervals nonOverlap = new NonOverlappingIntervals();
            int odstranimo = nonOverlap.EraseOverlapIntervals(intervals1);

            Console.WriteLine("1. Non-overlapping Intervals");
            Console.WriteLine("Minimalno stevilo intervalov za odstranitev: " + odstranimo);
            Console.WriteLine();

            // ============================
            // 2. MEETING ROOMS II
            // ============================
            int[][] intervals2 = new int[][]
            {
                new int[] { 0, 30 },
                new int[] { 5, 10 },
                new int[] { 15, 20 }
            };

            MeetingRoomsII meetingRooms = new MeetingRoomsII();
            int sobe = meetingRooms.MinMeetingRooms(intervals2);

            Console.WriteLine("2. Meeting Rooms II");
            Console.WriteLine("Minimalno stevilo potrebnih sejnih sob: " + sobe);
            Console.WriteLine();

            // ============================
            // 3. CANDY
            // ============================
            int[] ratings = { 1, 0, 2 };

            CandySolver candySolver = new CandySolver();
            int bonboni = candySolver.Candy(ratings);

            Console.WriteLine("3. Candy");
            Console.WriteLine("Minimalno stevilo bonbonov: " + bonboni);
            Console.WriteLine();

            // ============================
            // 4. JUMP GAME II
            // ============================
            int[] nums = { 2, 3, 1, 1, 4 };

            JumpGameII jumpGame = new JumpGameII();
            int skoki = jumpGame.Jump(nums);

            Console.WriteLine("4. Jump Game II");
            Console.WriteLine("Minimalno stevilo skokov: " + skoki);
            Console.WriteLine();
        }
    }
}