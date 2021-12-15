using System;

namespace L2_4_Zad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello.\r\nThis program calculates the diagonal length \r\n" +
                "of the rectangle based on the given side lengths.");
            Console.Write("Please enter the length of the first side: ");
            bool firstSideCanBeDouble = double.TryParse(Console.ReadLine(), out double firstSideDouble);
            Console.Write("Please enete the length of the second side: ");
            bool secondSideCanBeDouble = double.TryParse(Console.ReadLine(), out double secondSideDouble);

            if (firstSideCanBeDouble && secondSideCanBeDouble)
            {
                double diagonalOfTheRectangle = Math.Sqrt(Math.Pow(firstSideDouble, 2) + Math.Pow(secondSideDouble, 2));
                Console.WriteLine($"Calculated diagonal length is: {diagonalOfTheRectangle}");
            }
            else
            {
                Console.WriteLine("You enterd wrong type length values of rectangle sides! Try Again.");
            }
        }
    }
}