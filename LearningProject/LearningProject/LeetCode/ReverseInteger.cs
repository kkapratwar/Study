namespace LearningProject.LeetCode
{
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            int reversedInteger = 0;

            while (x != 0)
            {
                int remainder = x % 10;

                if (reversedInteger == 0)
                {
                    reversedInteger = remainder;
                }
                else
                {
                    if (reversedInteger != (reversedInteger * 10) / 10)
                    {
                        return 0;
                    }

                    reversedInteger = reversedInteger * 10 + remainder;
                }

                x = x / 10;
            }

            return reversedInteger;
        }
    }
}
