class Result
{
    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     * 
     *  IN
     * 1 3 5 7 9
     * 256741038 623958417 467905213 714532089 938071625
     * 5 5 5 5 5
     * 
     * 
     *  OUT
     * 16   24
     * 2063136757 2744467344
     * 20 20
     * 
     */

    public static void miniMaxSum(List<Int64> arr)
    {
        var whitoutMax = arr.Where(a => a < arr.Max());
        long minSum = whitoutMax.Sum();

        var whitoutMin = arr.Where(a => a > arr.Min());
        long maxSum = whitoutMin.Sum();

        if (arr.Max() == arr.Min())
        {
            var whitout = arr.Skip(1).Sum();
            minSum = whitout;
            maxSum = whitout;
        }

        Console.WriteLine(minSum + " " + maxSum);
    }
}

class Solution
{
    public static void Main(string[] args)
    {

        List<Int64> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}