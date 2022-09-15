/*
 * break
 * We are making a program for auction with a maximum bid set. The count of bids is variable.
 * Write a program to take the maximum bid as input, then take all bids from auction participants until the maximum bid is exceeded.
 * The program should output the corresponding message with the winning bid.
 * 
 * Sample Input
 * 1600
 * 800
 * 1300
 * 1700
 * 
 * Sample Output
 * Sold: 1700
 * 
 */

int maxBid = Convert.ToInt32(Console.ReadLine());

//your code goes here
while (true)
{
    string smth = Console.ReadLine();
    smth.Substring(0, Math.Min(smth.Length, 1));

    if (Convert.ToInt32(smth) >= maxBid)
    {
        Console.WriteLine("Sold: " + smth);
        break;
    }
}
