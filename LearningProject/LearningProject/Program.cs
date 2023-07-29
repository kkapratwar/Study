// See https://aka.ms/new-console-template for more information
using LearningProject.Algorightms;
using LearningProject.LeetCode;

while (true)
{
    Console.WriteLine("Hello, Select the option");
    Console.WriteLine("1. Longest Substring using Sliding Window technique");
    Console.WriteLine("2. Find median of two sorted arrays");
    Console.WriteLine("Press any other key to exit");

    int option = 0;
    int.TryParse(Console.ReadLine(), out option);

    switch (option)
    {
        case 1:
            {
                Console.WriteLine("Please enter the string: ");
                var str = Console.ReadLine();
                var length = LongestSubstring.GetLongestSubstring(str);
                Console.WriteLine($"Longest substring = {length}");
            }
            break;
        case 2:
            {
                Console.WriteLine("Comma seperate number for array 1: 1,2,3,4,5");
                Console.WriteLine("Comma seperate number for array 2: 2,3,4,5,6");
                int[] arr1 = new[] { 1, 2 };
                int[] arr2 = new[] { 3, 4 };
                float median = MedianOfSortedArray.GetMedianOfSortedArray(arr1, arr2);
                Console.WriteLine($"Median = {median}");
            }
            break;
        default:
            break;
    }

    if (option == 0)
    {
        break;
    }
}
