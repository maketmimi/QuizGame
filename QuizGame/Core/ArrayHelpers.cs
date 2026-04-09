using System;

namespace QuizGame
{
    internal class ArrayHelpers
    {
        private static readonly Random Rnd = new Random();

        public static void ShuffleArray<T>(T[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                GeneralHelpers.Swap(ref Array[Rnd.Next(0, Array.Length - 1)],
                    ref Array[Rnd.Next(0, Array.Length - 1)]);
            }
        }

    }
}
