/*
 * Given a square matrix, calculate the absolute difference between the sums of its diagonals.
 */

class Result
{
    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int leftDiagonal = 0;
        int rightDiagonal = 0;
        int res = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            for (int j = 0; j < arr[i].Count; j++)
            {
                if ((i + j) == (arr.Count - 1))
                {
                    rightDiagonal += arr[i][j];
                }
                if (i == j)
                {
                    leftDiagonal += arr[i][j];
                }
            }
        }
        res = Math.Abs(leftDiagonal - rightDiagonal);
        return res;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);
    }
}

/*

in: 
3
11 2 4
4 5 6
10 8 -12

out: 15

 */
