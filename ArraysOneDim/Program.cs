namespace ArraysOneDim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[2];
            arr[0] = 1;
            arr[1] = 2;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            int[] arr2 = { 1, 2, 3 };

            foreach (int el in arr2)
            {
                Console.WriteLine(el);
            }

            int[] arr3 = new int[] { 1, 2, 3 };

            int[] arr4 = new int[1, 2, 3, 4];
        }

        public static bool IsSymmetric(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n / 2; i++)
            {
                if (arr[i] != arr[n - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
