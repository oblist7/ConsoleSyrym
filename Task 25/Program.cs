/*
 * Given an array of integers and a positive integer k,
 * determine the number of (i, j) pairs where i<j and [i] + [j] is divisible by k.
 * 
 * Example
 * ar = [1, 2, 3, 4, 5, 6]
 * k = 5
 * Three pairs meet the criteria: [1, 4], [2, 3] and [4, 6].
 * 
 * Function Description
 * Complete the divisibleSumPairs function in the editor below.
 * divisibleSumPairs has the following parameter(s):
 *  int n: the length of array 
 *  int ar[n]: an array of integers
 *  int k: the integer divisor
 * Returns
 *  int: the number of pairs
 */

class Result
{

    /*
     * Complete the 'divisibleSumPairs' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n length
     *  2. INTEGER k divisor
     *  3. INTEGER_ARRAY ar
     */

    public static int divisibleSumPairs(int n, int k, List<int> ar)
    {
        int[] freq = new int[k];

        for (int i = 0; i < n; i++)
            ++freq[ar[i] % k];

        int sum = freq[0] * (freq[0] - 1) / 2;

        for (int i = 1; i <= k / 2 && i != (k - i); i++)
            sum += freq[i] * freq[k - i];

        if (k % 2 == 0)
            sum += (freq[k / 2] * (freq[k / 2] - 1) / 2);
        return sum;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        Console.Write("vvod Length(n) and Divisor(k): ");
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);
        Console.Write("vvod arr: ");
        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        Console.WriteLine("Result: " + Result.divisibleSumPairs(n, k, ar));
    }
}



/*
 * Input: 
 *      n k: 6 3
 *      ar: 1 3 2 6 1 2
 * 
 * Output: 5
 */
