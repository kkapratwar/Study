namespace LearningProject.LeetCode
{
    internal class CountPrimes
    {
        public CountPrimes()
        {
            CountPrimeNumbers(5);    
        }

        public int CountPrimeNumbers(int n)
        {
            int count = 0;

            for (int i = 2; i <= n; i++)
            {
                if (i % 2 > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
