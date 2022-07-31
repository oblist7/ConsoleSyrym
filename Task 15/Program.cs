/*
 * Maria plays college basketball and wants to go pro. Each season she maintains a record of her play.
 * She tabulates the number of times she breaks her season record for most points and least points in a game.
 * Points scored in the first game establish her record for the season, and she begins counting from there.
 * 
 * Example
 * scores = [12, 24, 10, 24]
 * 
 * Scores are in the same order as the games played. She tabulates her results as follows:
 * 
 * Game  Score  Minimum  Maximum   Lose Win
 *   0      12     12       12       0   0
 *   1      24     12       24       0   1
 *   2      10     10       24       1   1
 *   3      24     10       24       1   1
 * 
 */

class Result
{
    public static List<int> breakingRecords(List<int> scores)
    {
        int min = 0;
        int max = 0;

        int loseCount = 0;
        int winCount = 0;

        for (int i = 0; i < scores.Count; i++)
        {
            if (i != 0)
            {
                if (min < scores[i])
                {
                    min = scores[i];
                    winCount++;
                }
                else if (max > scores[i])
                {
                    max = scores[i];
                    loseCount++;
                }
            }

            else
            {
                min = scores[i];
                max = scores[i];
                loseCount = 0;
                winCount = 0;
            }
        }

        List<int> result = new List<int> { winCount, loseCount };
        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {

        int n = 9;
        List<int> scores = new List<int> { 10, 5, 20, 20, 4, 5, 2, 25, 1 };

        List<int> result = Result.breakingRecords(scores);

        Console.WriteLine(String.Join(" ", result));
    }
}


/*
 * Input:
 * Game count n = 9
 * Scores = [10, 5, 20, 20, 4, 5, 2, 25, 1]
 * 
 * Result:
 * Win  Lose
 *  2    4
 * 
 * 
 *    *** 14 Tests cases Success ***
 *  
 */
