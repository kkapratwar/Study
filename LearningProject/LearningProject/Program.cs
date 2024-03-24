// See https://aka.ms/new-console-template for more information
using LearningProject.Algorightms;
using LearningProject.DataStructures;
using LearningProject.LeetCode;

while (true)
{
    Console.WriteLine("Hello, Select the option");
    Console.WriteLine("1. Longest Substring using Sliding Window technique");
    Console.WriteLine("2. Find median of two sorted arrays");
    Console.WriteLine("3. Binary Tree");
    Console.WriteLine("4. Find Largest substring without repeatation");
    Console.WriteLine("5. Find Largest substring with repeatation");
    Console.WriteLine("6. Add Two Numbers Linked List");
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
        case 3:
            {
                BinaryTree binaryTree = new BinaryTree();
                binaryTree.InsertNode(2);
                binaryTree.InsertNode(3);
                binaryTree.InsertNode(4);
                binaryTree.InsertNode(1);
                binaryTree.InsertNode(5);

                Console.WriteLine("Preorder:");
                binaryTree.PreOrderTraversal();

                Console.WriteLine("Inorder");
                binaryTree.InorderTraversal();

                Console.WriteLine("PostOrder");
                binaryTree.PostOrderTraversal();

            }
            break;
        case 4:
            {
                LargestSubstring largestSubstring = new LargestSubstring();
                Console.WriteLine($"abcabcd: {largestSubstring.FindLargestSubstringWithoutRepeatation("abcabcd")}");
                Console.WriteLine($"abcabcbb: {largestSubstring.FindLargestSubstringWithoutRepeatation("abcabcbb")}");
                Console.WriteLine($"bbbbb: {largestSubstring.FindLargestSubstringWithoutRepeatation("bbbbb")}");
                Console.WriteLine($"pwwkew: {largestSubstring.FindLargestSubstringWithoutRepeatation("pwwkew")}");
            }
            break;
        case 5:
            {
                LargestSubstring largestSubstring = new LargestSubstring();
                Console.WriteLine($"abcabcbb: {largestSubstring.FindLargestSubstringWithRepeatation("abcabcbb")}");
                Console.WriteLine($"bbbbb: {largestSubstring.FindLargestSubstringWithRepeatation("bbbbb")}");
                Console.WriteLine($"pwwkew: {largestSubstring.FindLargestSubstringWithRepeatation("pwwkew")}");
            }
            break;
        case 6:
            {
                AddTwoNumbersLinkedList addTwoNumbersLinkedList = new AddTwoNumbersLinkedList();
                int[] l1Numbers = new[] { 9, 9, 9, 9, 9, 9, 9 };
                int[] l2Numbers = new[] { 9, 9, 9, 9 };
                ListNode l1 = null;
                ListNode currentNode = null;
                for (int i = 0; i < l1Numbers.Length; i++)
                {
                    var newNode = new ListNode(l1Numbers[i]);
                    if (l1 == null)
                    {
                        l1 = newNode;
                        currentNode = newNode;
                    }
                    else
                    {
                        currentNode.next = newNode;
                        currentNode = currentNode.next;
                    }
                }
                ListNode l2 = null;
                currentNode = null;
                for (int i = 0; i < l2Numbers.Length; i++)
                {
                    var newNode = new ListNode(l2Numbers[i]);
                    if (l2 == null)
                    {
                        l2 = newNode;
                        currentNode = newNode;
                    }
                    else
                    {
                        currentNode.next = newNode;
                        currentNode = currentNode.next;
                    }
                }

                var result = addTwoNumbersLinkedList.AddTwoNumbers(l1, l2);
                while (result != null)
                {
                    Console.Write(result.val);
                    result = result.next;
                }
            }
            break;
        default:
            {
                if (option == 0)
                {
                    break;
                }
            }
            break;
    }
}
