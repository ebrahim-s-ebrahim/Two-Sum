namespace Two_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new int[] {2, 3, 4, 5, 6};

            int[] result = TwoSum(ints, 10);

            Console.WriteLine($"[{result[0]}, {result[1]}]");
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            int[] arr = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                int Value = target - nums[i];

                if (dict.ContainsKey(Value) && i != dict[Value])
                {
                    arr[0] = dict[Value];
                    arr[1] = i;
                    return arr;
                }
                dict[nums[i]] = i;
            }
            return arr;
        }
    }
}