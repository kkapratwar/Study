namespace LearningProject.LeetCode
{
    internal class MedianOfSortedArray
    {
        public static float GetMedianOfSortedArray(int[] arr1, int[] arr2)
        {
            int lengthArr1 = arr1.Length;
            int lengthArr2 = arr2.Length;

            if (lengthArr1 > 0 && lengthArr2 == 0)
            {
                return GetMedian(arr1, lengthArr1);
            }

            if (lengthArr2 > 0 && lengthArr1 == 0)
            {
                return GetMedian(arr2, lengthArr2);
            }

            var mergedArray = new int[lengthArr1 + lengthArr2];
            var mergedArrayIndex = 0;
            int arr1Index = 0;
            int arr2Index = 0;
            while (arr1Index < lengthArr1 && arr2Index < lengthArr2)
            {
                if (arr1[arr1Index] < arr2[arr2Index])
                {
                    mergedArray[mergedArrayIndex] = arr1[arr1Index];
                    arr1Index++;
                }
                else if (arr2Index < lengthArr2)
                {
                    mergedArray[mergedArrayIndex] = arr2[arr2Index];
                    arr2Index++;
                }

                mergedArrayIndex++;
            }

            while (arr1Index < lengthArr1)
            {
                mergedArray[mergedArrayIndex] = arr1[arr1Index];
                arr1Index++;
                mergedArrayIndex++;
            }

            while (arr2Index < lengthArr2)
            {
                mergedArray[mergedArrayIndex] = arr2[arr2Index];
                arr2Index++;
                mergedArrayIndex++;
            }

            return GetMedian(mergedArray, mergedArray.Length);
        }

        private static float GetMedian(int[] arr, int lengthArr)
        {
            if (lengthArr % 2 == 0)
            {
                var index = lengthArr / 2;
                return ((arr[index] + arr[index - 1]) / (float)2);
            }
            else
            {
                return (float)arr[lengthArr / 2];
            }
        }
    }
}
