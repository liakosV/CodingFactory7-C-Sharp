﻿namespace ParamsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            result = Add(1, 7, 8, 9);
            Console.WriteLine(result);

            result = Add(1, 7, 8, 9, 5, 5, 9);
            Console.WriteLine(result);

            result = Add(1);
            Console.WriteLine(result);
        }

        public static int Add(params int[] nums)
        {
            int sum = 0;
            foreach (int el in nums)
            {
                sum += el;
            }
            return sum;
        }
    }
}
