namespace LearningProject.LeetCode
{
    public class RemoveElement
    {
        public RemoveElement()
        {
            int[] nums = new[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            int val = 2;

            int result = RemoveElementFromArray(nums, val);

            Console.WriteLine("Input - [0,1,2,2,3,0,4,2], Val - 2");
            Console.WriteLine($"Output - {result}");

        }

        public int RemoveElementFromArray(int[] nums, int val)
        {
            int length = nums.Length;
            int i = 0;
            int j = length - 1;

            while (i < length && nums[i] == val)
            {
                i++;
            }

            while (j >= 0 && nums[j] == val)
            {
                j--;
            }

            while (i <= j)
            {
                if (nums[i] == val)
                {
                    var temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    j--;
                }
                else
                {
                    i++;
                }
            }

            return i;
        }
    }
}
