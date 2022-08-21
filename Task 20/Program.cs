/*
 * Danse
 *
 * Sample Input
 *  Dave
 *  8
 *  Jessica
 *  7
 * 
 * Sample Output
 *  Dave & Jessica
 *  15
 */

namespace SoloLearn;

class Program
{
    static void Main(string[] args)
    {
        string name1 = Console.ReadLine();
        int points1 = Convert.ToInt32(Console.ReadLine());
        string name2 = Console.ReadLine();
        int points2 = Convert.ToInt32(Console.ReadLine());

        DancerPoints dancer1 = new DancerPoints(name1, points1);
        DancerPoints dancer2 = new DancerPoints(name2, points2);

        DancerPoints total = dancer1 + dancer2;
        Console.WriteLine(total.name);
        Console.WriteLine(total.points);
    }

    class DancerPoints
    {
        public string name;
        public int points;
        public DancerPoints(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public static DancerPoints operator +(DancerPoints dancer1, DancerPoints dancer2)
        {
            string name = dancer1.name + " & " + dancer2.name;
            int points = dancer1.points + dancer2.points;

            DancerPoints result = new DancerPoints(name, points);
            return result;
        }
    }
}
