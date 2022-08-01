/*
 * Input Format:
 * Each line of the input file will begin with an operation (S or C) followed by a semi-colon followed by M, C,
    or V followed by a semi-colon followed by the words you'll need to operate on.
 * The operation will either be S (split) or C (combine)
 * M indicates method, C indicates class, and V indicates variable
 * In the case of a split operation, the words will be a camel case method,
    class or variable name that you need to split into a space-delimited list of words starting with a lowercase letter.
 * In the case of a combine operation, the words will be a space-delimited list of words starting with lowercase letters
    that you need to combine into the appropriate camel case String.
    Methods should end with an empty set of parentheses to differentiate them from variable names.
 *
 */

public class Solution
{
    public static List<string> resultList = new List<string> { };

    public static char firstElem = ' ';
    public static char secandElem = ' ';
    public static string nameElem = " ";

    static void Main(String[] args)
    {
        List<string> input = new List<string>() {
            "C;V;can of coke",
            "S;M;sweatTea()",
            "S;V;epsonPrinter",
            "C;M;santa claus",
            "C;C;mirror",
        };

        resultList = ProcessL(input);

        Console.WriteLine(string.Join("\n", resultList));
    }


    public static List<string> ProcessL(List<string> input)
    {
        string result = " ";
        foreach (string line in input)
        {
            firstElem = char.Parse(line.Substring(0, 1).ToUpper());
            secandElem = char.Parse(line.Substring(2, 1).ToUpper());
            nameElem = line.Substring(4, line.Length - 4);

            if (firstElem == 'S')
            {
                if (secandElem == 'V')
                {
                    for (int i = 0; i < nameElem.Length; i++)
                    {
                        if (char.IsUpper(nameElem[i]))
                            result = nameElem.Insert(i, " ").ToLower();
                    }

                    resultList?.Add(result);
                }

                else if (secandElem == 'M')
                {
                    for (int i = 0; i < nameElem.Length; i++)
                    {
                        if (char.IsUpper(nameElem[i]))
                        {
                            nameElem = nameElem.Remove(nameElem.LastIndexOf('('));
                            result = nameElem.Insert(i, " ").ToLower();
                        }
                    }

                    resultList?.Add(result);
                }

                else if (secandElem == 'C')
                {
                    for (int i = 0; i < nameElem.Length; i++)
                    {
                        if (char.IsUpper(nameElem[i]))
                            result = nameElem.Insert(i, " ").ToLower();
                    }

                    resultList?.Add(result);
                }
            }

            else if (firstElem == 'C')
            {
                if (secandElem == 'V')
                {
                    for (int i = 0; i < nameElem.Length; i++)
                    {
                        if (char.IsWhiteSpace(nameElem[i]))
                        {
                            nameElem = nameElem.Remove(i, 1);
                            if (!char.IsUpper(nameElem[i]))
                            {
                                string o = nameElem[i].ToString().ToUpper();
                                nameElem = nameElem.Insert(i, o);
                                nameElem = nameElem.Remove(i + 1, 1);
                                result = nameElem;
                            }

                            result = nameElem;
                        }
                    }

                    resultList?.Add(result);
                }

                else if (secandElem == 'M')
                {
                    for (int i = 0; i < nameElem.Length; i++)
                    {
                        if (char.IsWhiteSpace(nameElem[i]))
                        {
                            char p = char.Parse(nameElem[i + 1].ToString().ToUpper());
                            nameElem = nameElem.Replace(nameElem[i + 1], p);
                            result = nameElem.Remove(i, +1) + "()";
                        }
                    }

                    resultList?.Add(result);
                }

                else if (secandElem == 'C')
                {
                    for (int i = 0; i < nameElem.Length; i++)
                    {

                        if (char.IsWhiteSpace(nameElem[i]))
                        {
                            char p = char.Parse(nameElem[i + 1].ToString().ToUpper());
                            nameElem = nameElem.Replace(nameElem[i + 1], p);
                            result = nameElem.Remove(i, +1);
                        }

                        if (!char.IsUpper(nameElem[0]))
                        {
                            nameElem = char.ToUpper(nameElem[0]) + nameElem.Substring(1);
                            result = nameElem;
                        }
                    }

                    resultList?.Add(result);
                }
            }
        }
        return resultList;
    }
}

/*
 * Input:                           Result:
 * S; M; plasticCup()           |   plastic cup
 * C; V; mobile phone           |   mobile phone       
 * C; C; coffee machine         |   CoffeeMachine      
 * S; C; LargeSoftwareBook      |   large software book
 * C; M; white sheet of paper   |   whiteSheetofPaper  
 * S; V; pictureFrame           |   picture frame
 *
 */
