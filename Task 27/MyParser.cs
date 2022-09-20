

namespace Task_27;

public class MyParser
{
    public int TryCathParse(string input)
    {
        try
        {
            return int.Parse(input);
        }
        catch (Exception ex)
        {
            return 0;
        }
    }

    public int TryParse(string input)
    {
        int result;

        if(!int.TryParse(input, out result))
        {
            result = 0;
        }
        return result;
    }
}
