using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> nums = new List<int>();
        int num = -1;
        while (num != 0) {
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            if (num != 0) {
                nums.Add(num);
            }
        }

        int total = 0;
        int max = 0;
        int smallestPositive = -1;
        for (int i = 0; i < nums.Count; i++) {
            total += nums[i];
            if (nums[i] > max) {
                max = nums[i];
            }
            if (nums[i] > 0 && nums[i] < smallestPositive) {
                smallestPositive = nums[i];
            }
        }

        double avg = double.Parse(total.ToString()) / double.Parse(nums.Count.ToString());

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        nums.Sort();
        Console.WriteLine("The sorted list is:");
        for (int i = 0; i < nums.Count; i++) {
            Console.WriteLine($"{nums[i]}");
        }
    }
}