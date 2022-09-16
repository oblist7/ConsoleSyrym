/*
 * There is a collection of input strings and a collection of query strings.
 * For each query string, determine how many times it occurs in the list of input strings.
 * Return an array of the results.
 * 
 * Function Description
 * Complete the function matchingStrings in the editor below. 
 * The function must return an array of integers representing the frequency of occurrence 
 * of each query string in strings.
 * matchingStrings has the following parameters:
 *      string strings[n] - an array of strings to search
 *      string queries[q] - an array of query strings
 *      
 * Returns: int[q]: an array of results for each query
 */

class Result
{
    /*
     * Complete the 'matchingStrings' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. STRING_ARRAY strings
     *  2. STRING_ARRAY queries
     */

    public static List<int> matchingStrings(List<string> strings, List<string> queries)
    {
        List<int> result = new List<int>();
        int count = 0;

        for (int i = 0; i < queries.Count; i++)
        {
            count = strings.Count(x => x == queries[i]);
            result.Add(count);
            Console.WriteLine(count);
        }

        return result;
    }
}

class Program
{
    static void Main()
    {
        TextWriter textWriter = new StreamWriter(".\\Text.txt", true);
        Console.Write("Vvod strings: ");
        int stringsCount = Convert.ToInt32(Console.ReadLine().Trim());
        List<string> strings = new List<string>();
        for (int i = 0; i < stringsCount; i++)
        {
            string stringsItem = Console.ReadLine();
            strings.Add(stringsItem);
        }

        Console.Write("Vvod queries: ");
        int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());
        List<string> queries = new List<string>();
        for (int i = 0; i < queriesCount; i++)
        {
            string queriesItem = Console.ReadLine();
            queries.Add(queriesItem);
        }

        List<int> res = Result.matchingStrings(strings, queries);

        textWriter.WriteLine(String.Join("\n", res));
        textWriter.Flush();
        textWriter.Close();

        Console.ReadKey();
    }
}

/*
 * Example:
 * 
 *  strings = ['ab','ab','abc']
 *  queries = ['ab','abc','bc']
 *  
 * There are    2 instances of 'ab',
 *              1 of 'abc' and 0 of 'bc'.
 *              For each query, add an element to the return array,
 *              
 * Result = [2, 1, 0]
 */
