namespace LearningProject.Algorightms
{
    internal class LongestSubstring
    {
        public static int GetLongestSubstring(string s)
        {
            int left = 0;
            int right = 0;
            int maxLength = 0;

            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            HashSet<char> existingCharaters = new HashSet<char>();

            while (right < s.Length)
            {
                if (!existingCharaters.Contains(s[right]))
                {
                    existingCharaters.Add(s[right]);
                    maxLength = Math.Max(maxLength, right - left + 1);
                    right++;
                }
                else
                {
                    existingCharaters.Remove(s[right]);
                    left++;
                }
            }

            return maxLength;
        }
    }
}
