namespace LearningProject.LeetCode
{
    public class LargestSubstring
    {
        public int FindLargestSubstringWithoutRepeatation(string str)
        {
            char[] chars = str.ToCharArray();
            int maxLength = 0;
            HashSet<char> hashSet = new HashSet<char>();
            int x = 0;
            int y = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (!hashSet.Contains(chars[i]))
                {
                    hashSet.Add(chars[i]);
                    x++;
                    maxLength = Math.Max(maxLength, x - y);
                }
                else
                {
                    hashSet.Remove(chars[i]);
                    y++;
                }
            }

            return maxLength;
        }

        public int FindLargestSubstringWithRepeatation(string str)
        {
            int right = 0;
            int left = 0;
            int maxLength = 0;
            Dictionary<char, int> charIndexMap = new Dictionary<char, int>();

            while (right < str.Length)
            {
                if (charIndexMap.ContainsKey(str[right]))
                {
                    left = Math.Max(left, charIndexMap[str[right]] + 1);
                }

                charIndexMap[str[right]] = right;
                right++;

                maxLength = Math.Max(maxLength, right - left);
            }

            return maxLength;
        }
    }
}
