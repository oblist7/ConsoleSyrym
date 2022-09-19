/* 
 * HackerLand University has the following grading policy:
 * 
 * Every student receives a grade in the inclusive range from 0 to 100. Any grade less than 40 is a failing grade.
 * Sam is a professor at the university and likes to round each student's grade according to these rules:
 * 
 * If the difference between the grade and the next multiple of 5 is less than 3, round grade up to the next multiple of 5.
 * If the value of grade is less than 38, no rounding occurs as the result will still be a failing grade.
 * 
 * Examples:
 * grade = 84 round to  (85 - 84 is less than 3)
 * grade = 29 do not round (result is less than 40)
 * grade = 57 do not round (60 - 57 is 3 or higher)
 * 
 */


class Result
{
    public static List<int> gradingStudents(List<int> grades)
    {
        for (int i = 0; i < grades.Count; i++)
        {
            if (grades[i] >= 38)
            {
                int mod5 = grades[i] % 5;
                if (mod5 >= 3)
                {
                    grades[i] = grades[i] + (5 - mod5);
                }
            }
        }

        return grades;
    }
}


class Solution
{
    public static void Main(string[] args)
    {
        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);
        Console.WriteLine("r: " + String.Join(" ", result));
    }
}

/*
input   output

4

73      75  +
67      67  -
38      40  +
33      33  -

 */
