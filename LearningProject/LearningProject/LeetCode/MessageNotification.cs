using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading;

namespace LearningProject.LeetCode
{
    /*Prepare a notification of the given message which will be displayed on a mobile device.The message is made of words separated by single spaces.
    The length of the notification is limited to K characters.If the message is too long to be displayed fully, some words from the end of the message should be cropped, keeping in mind that:
    • the notification should be as long as possible;
    • only whole words can be cropped;
    • if any words are cropped, the notification should end with "..."; the dots should be separated from the last word by a single space;
    • the notification may not exceed the K-character limit, including the dots.
    If all the words need to be cropped, the notification is "..." (three dots without a space).
    For example, for message = "And now here is my secret" and K = 15, the notification is "And now...". 
    
    Note that:
    • the notification "And ..." would be incorrect, because there is a longer correct notification;
    • the notification "And now her.." would be incorrect, because the original message is cropped through the middle of a word;
    • the notification "And now ... "would be incorrect, because it ends with a space;
    • the notification "And now here..." would be incorrect, because there is no space before the three dots;
    • the notification "And now here..."would be incorrect, because it exceeds the 15-character limit.
    
    Write a function:
    def solution(message, K)
    that, given a string message and an integer K, returns the notification to display, which has no more than K characters, as described above.
    
    Examples:
    1. For message = "And now here is my secret" and K = 15, the function should return "And now ...", as explained above.
    2. For message = "There is an animal with four legs" and K = 15, the function should return "There is an ...".
    3. For message = "super dog" and K = 4, the function should return "...".
    4. For message = "how are you" and K = 20, the function should return "how are you".
    
    Assume that:
    • K is an integer within the range [3...500];
    • the length of string message is within the range[1.500);
    • string message is made of English letters('a'-z', 'A'-) and spaces ( );
    • message does not contain spaces at the beginning or at the
    • words are separated by a single space (there are never two or more consecutive spaces).
    In your solution, focus on correctness.The performance of your solution will not be the focus of the assessment.*/

    internal class MessageNotification
    {
        public string solution(string message, int K)
        {

            if (message.Length <= K)
                return message;

            string[] words = message.Split(' ');

            StringBuilder notification = new StringBuilder();

            int totalChars = 0;
            string dots = "...";
            int spaceLength = 1;

            for (int i = 0; i < words.Length; i++)
            {
                if (totalChars + words[i].Length + spaceLength <= K)
                {
                    if (totalChars + words[i].Length + spaceLength + words[i + 1].Length + spaceLength + dots.Length <= K)
                    {
                        notification.Append(words[i]).Append(" ");
                        totalChars += words[i].Length + spaceLength;
                    }
                    else if (totalChars + words[i].Length + spaceLength + dots.Length <= K)
                    {
                        notification.Append(words[i]).Append(" ").Append(dots);
                        totalChars += words[i].Length + spaceLength + dots.Length;
                    }
                }
                else
                {
                    break;
                }
            }

            if (notification.Length == 0)
                return dots;

            return notification.ToString();
        }
    }
}
