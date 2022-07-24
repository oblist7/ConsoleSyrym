/*
 * Quick Sort algorithm
 * 
 * Sorted array: 1,2,4,5,7,10,54
 * 
 */

int[] inputArray = { 2, 5, 54, 1, 7, 10, 4 };

int[] sortedArray = QuickSort(inputArray, 0, inputArray.Length - 1);

Console.WriteLine($"Sorted array: {string.Join(",", sortedArray)}");

static int[] QuickSort(int[] array, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex)
    {
        return array;
    }

    int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

    QuickSort(array, minIndex, pivotIndex - 1);

    QuickSort(array, pivotIndex + 1, maxIndex);

    return array;
}

static int GetPivotIndex(int[] array, int minIndex, int maxIndex)
{
    int pivot = minIndex - 1;

    for (int i = minIndex; i <= maxIndex; i++)
    {
        if (array[i] < array[maxIndex])
        {
            pivot++;

            Swap(ref array[pivot], ref array[i]);
        }
    }

    pivot++;
    Swap(ref array[pivot], ref array[maxIndex]);

    return pivot;
}

static void Swap(ref int leftItem, ref int rigthItem)
{
    int temp = leftItem;

    leftItem = rigthItem;

    rigthItem = temp;
}