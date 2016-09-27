using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!");
            string cont;
            do
            {
                Console.WriteLine("\n Enter an integer");
                int userResponse = int.Parse(Console.ReadLine());


                int Square,  Cube;
                Console.WriteLine("\tNumber\tSquare\tCube");
                //loop 10 times calculating and displaying values
                for (int Number = 1; Number <= userResponse;
               Number++)

                {

                    Square = Number * Number;

                    Cube = Square * Number;

                    Console.WriteLine("\t{0}\t{1}\t{2}", Number, Square, Cube);

                }
                // end of calculate and display
                Console.WriteLine("Do you want to continue? y/n");
                cont = Console.ReadLine();

            }  while (cont == "y");

            string EndingMessage = ("Thank you for selecting an integer. Goodbye");
            Console.WriteLine(EndingMessage);

            Console.ReadKey();
        }
    }
}
