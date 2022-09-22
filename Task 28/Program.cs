/*
 * Вам предоставляется список 32-битных беззнаковых целых чисел.
 * Вы должны вывести список беззнаковых целых чисел, полученных инвертированием битов в их двоичном представлении 
 * (то есть, неустановленные биты должны быть установленными, а установленные  неустановленными).
 * 
 */

using System.Text;

class Result
{
    /*
     * Complete the 'flippingBits' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     */

    public static long flippingBits(long n)
    {
        var bits = InvertBits(n);

        long result = 0;

        for (var i = 0; i < bits.Length; i++)
        {
            if (bits[i] == '1')
            {
                result = result + (long)Math.Pow(2, 31 - i);
            }
        }

        return result;
    }

    private static string InvertBits(long n)
    {
        var builder = new StringBuilder();

        for (var i = 31; i >= 0; i--)
        {
            builder = (((1 << i) & n) != 0) ? builder.Append('0') : builder.Append('1');
        }

        return builder.ToString();
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        List<long> list = new List<long>();

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = Result.flippingBits(n);
            list.Add(result);
        }
        Console.WriteLine("\nRes: \n" + String.Join("\n", list));
    }
}

/*

in: 
3
2147483647
1
0

2147483648      
4294967294
4294967295      

in int: 1
step1: convert 2x
00000000000000000000000000000001

step2: invent
11111111111111111111111111111110

step3: convert 10x
result:  4294967294

802743475
101111110110001110010010110011
010000001001110001101101001100
3492223820

 */
