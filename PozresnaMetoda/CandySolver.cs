using System;

namespace PozresnaMetoda
{
    internal class CandySolver
    {
        public int Candy(int[] ratings)
        {
            int n = ratings.Length;

            // Vsak dobi na začetku vsaj 1 bonbon
            int[] candies = new int[n];
            for (int i = 0; i < n; i++)
            {
                candies[i] = 1;
            }

            // Prehod z leve proti desni:
            // če ima otrok višjo oceno od levega soseda,
            // mora dobiti več bonbonov
            for (int i = 1; i < n; i++)
            {
                if (ratings[i] > ratings[i - 1])
                {
                    candies[i] = candies[i - 1] + 1;
                }
            }

            // Prehod z desne proti levi:
            // če ima otrok višjo oceno od desnega soseda,
            // mora dobiti več bonbonov
            for (int i = n - 2; i >= 0; i--)
            {
                if (ratings[i] > ratings[i + 1])
                {
                    candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
                }
            }

            // Seštejemo vse bonbone
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += candies[i];
            }

            return sum;
        }
    }
}