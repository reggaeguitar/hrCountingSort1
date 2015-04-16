namespace hrCountingSort1
{
    using System;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main()
        {
            var numItems = Int32.Parse(Console.ReadLine());
            var counts = new int[100];
            var nums = Console.ReadLine().Split(' ').Select(Int32.Parse);
            foreach (var num in nums)
            {
                ++counts[num];
            }
            var sb = new StringBuilder();
            foreach (var count in counts)
            {
                sb.Append(count);
                sb.Append(" ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
