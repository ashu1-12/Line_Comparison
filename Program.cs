using System.Numerics;

namespace LineComparisonProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

           // Console.WriteLine("Lenght of Line is "+lengthOfLine());
            Console.WriteLine("The lines are equal " + checkLinesAreEqual());
        }

        private static bool checkLinesAreEqual()
        {
            /*Console.WriteLine("Enter line1 co-ordinates");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter line2 co-ordinates");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            int x4 = Convert.ToInt32(Console.ReadLine());
            int y4 = Convert.ToInt32(Console.ReadLine());*/

            if(lengthOfLine().Equals(lengthOfLine()))
                return true;
            return false;

        }

        private static int lengthOfLine()
        {
            Console.WriteLine("Enter line1 co-ordinates");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            return (int)Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
        }
    }
}