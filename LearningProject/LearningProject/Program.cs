// See https://aka.ms/new-console-template for more information
using LearningProject.Algorightms;
using LearningProject.DataStructures;
using LearningProject.DesignPatterns.AbstractFactoryPattern;
using LearningProject.DesignPatterns.FactoryPattern;
using LearningProject.LeetCode;

while (true)
{
    Console.WriteLine("Hello, Select the option");
    Console.WriteLine("1. Algorithms");
    Console.WriteLine("2. Design Patterns");
    Console.WriteLine("Press any other key to exit");

    int option = 0;
    int.TryParse(Console.ReadLine(), out option);

    switch (option)
    {
        case 1:
            {
                Algorithms();
            }
            break;
        case 2:
            {
                DesignPatterns();
            }
            break;
        default:
            return;
    }
}

static void Algorithms()
{
    int option = 9999;
    while (option > 0)
    {
        Console.WriteLine("Hello, Select the option");
        Console.WriteLine("1. Longest Substring using Sliding Window technique");
        Console.WriteLine("2. Find median of two sorted arrays");
        Console.WriteLine("3. Binary Tree");
        Console.WriteLine("4. Find Largest substring without repeatation");
        Console.WriteLine("5. Find Largest substring with repeatation");
        Console.WriteLine("6. Add Two Numbers Linked List");
        Console.WriteLine("7. Reverse Integer");
        Console.WriteLine("8. Message Notification");
        Console.WriteLine("9. First Missing Positive Number");
        Console.WriteLine("Press any other key to exit");

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
            case 7:
                {
                    ReverseInteger reverseInteger = new ReverseInteger();
                    Console.WriteLine("Enter the number:");
                    var str = Console.ReadLine();
                    var result = reverseInteger.Reverse(Convert.ToInt32(str));
                    Console.WriteLine($"Reversed Integer = {result}");
                }
                break;
            case 8:
                {
                    var msg = new MessageNotification();
                    Console.WriteLine($"Message = abcd ; Length = 5 ; Output : {msg.solution("abcd", 5)}");
                    Console.WriteLine($"Message = howareasrer ; Length = 3 ; Output : {msg.solution("howareasrer", 3)}");
                    Console.WriteLine($"Message = And now here is my secret ; Length = 15 ; Output : {msg.solution("And now here is my secret", 15)}");
                    Console.WriteLine($"Message = There is an animal with four legs ; Length = 15 ; Output : {msg.solution("There is an animal with four legs", 15)}");
                    Console.WriteLine($"Message = super dog ; Length = 4 ; Output : {msg.solution("super dog", 4)}");
                    Console.WriteLine($"Message = how are you ; Length = 20 ; Output : {msg.solution("how are you", 20)}");
                }
                break;
            case 9:
                {
                    var positiveNumber = new FirstMissingPositiveNumber();

                    int[] numbers = new int[] { 1, 2, 3, 4 };
                    Console.WriteLine("Numbers = [1, 2, 3, 4]");
                    Console.WriteLine($"First Missing Positive Number = {positiveNumber.FirstPositiveMissingNumber(numbers)}");

                    numbers = new int[] { 1, 3, 6, 4, 1, 2 };
                    Console.WriteLine("Numbers = [1, 3, 6, 4, 1, 2]");
                    Console.WriteLine($"First Missing Positive Number = {positiveNumber.FirstPositiveMissingNumber(numbers)}"); ;
                }
                break;
            default:
                {
                    option = 0;
                }
                break;
        }
    }
}

static void DesignPatterns()
{
    int option = 9999;

    while (option > 0)
    {
        Console.WriteLine("Hello, Select the option");
        Console.WriteLine("1. Factory Pattern");
        Console.WriteLine("2. Abstract Factory Pattern");
        Console.WriteLine("Press any other key for Main Menu");

        int.TryParse(Console.ReadLine(), out option);

        switch (option)
        {
            case 1:
                {
                    Console.WriteLine("Please enter the vehicle type (car, bike, rickshaw): ");
                    var str = Console.ReadLine();
                    IVehicle vehicle = VehicleFactory.GetVehicle(str);
                    Console.WriteLine($"Type of Vehicle : {vehicle.VehicleType()}");
                    Console.WriteLine($"Number of Wheels for the vehicle : {vehicle.NumberOfWheels()}");
                }
                break;
            case 2:
                {
                    Console.WriteLine($"Regular Vehicle Factory");
                    IVehicleFactory regularVehicle = new RegularVehicleFactory();
                    ICar regularCar = regularVehicle.CreateCar();
                    regularCar.GetDetails();
                    IBike regularBike = regularVehicle.CreateBike();
                    regularBike.GetDetails();

                    Console.WriteLine($"Sports Vehicle Factory");
                    IVehicleFactory sportsVehicle = new SportsVehicleFactory();
                    ICar sportsCar = sportsVehicle.CreateCar();
                    sportsCar.GetDetails();
                    IBike sportsBike = sportsVehicle.CreateBike();
                    sportsBike.GetDetails();
                }
                break;
            default:
                {
                    option = 0;
                }
                break;
        }
    }
}


