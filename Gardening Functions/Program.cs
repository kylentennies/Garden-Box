using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gardening_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Ask the user for the length/width of their garden bed
             * Tell the user the area and perimeter of their bed
             * Tell the user how many of each type of crop they can grow
             * using the following values
             * 
             * 16 Carrots per 4x4 bed (1/sq ft)
             * 9 Beets per 4x4 bed
             * 3 Corn per 4x4 bed
             *
             * Bonus:
             * Update the program to allow the user to chose which vegetable they're growing
             * 
             */

            Console.WriteLine("What is the length of your garden bed?");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the width of your garden bed?");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * length + 2 * width;
            Console.WriteLine("The area of your garden bed is " + area + " and the perimeter is " + perimeter);
            //Console.WriteLine("You can plant " + Math.Floor(area/16) + " carrots, " + Math.Floor(area / 9) + " beets, and " + Math.Floor(area / 3) + " corn.");

            Console.WriteLine("Which vegetable would you like to plant? (carrots, beets, corn?)");
            string vegAnswer = Console.ReadLine().ToLower();

            if (vegAnswer == "carrots")
            {
                NumberPlant(area, 16, "carrots");
            }
            if (vegAnswer == "beets")
            {
                NumberPlant(area, 9, "beets");
            }
            if (vegAnswer == "corn")
            {
                NumberPlant(area, 3, "corn");
            }



            Console.ReadLine();

        }
        static void NumberPlant(double area, int numberVeggie, string veg)
        {
            int numberVeg = Convert.ToInt32(area / numberVeggie);
            Console.WriteLine("You are able to plant " + numberVeg + " " + veg + ".");

        }
    }
}
