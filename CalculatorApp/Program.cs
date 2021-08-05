using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string yes = "";
            do {
               
                Console.WriteLine(" Enter the 1st number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the 2nd number");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your choice from the list");
                Console.Write("\n\t1-Addition \n\t2-Subsatrction \n\t3-Multiplication \n\t4-Division \n\te-Exit\n");
                int operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        Console.WriteLine(" Addition is{0}", (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("Substarction is{0}", (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Multiplication is{0}", (num1 * num2));
                        break;
                    case 4:
                        while (num2 == 0)
                        {
                            Console.WriteLine("Enter a non-zero number");
                            num2 = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Division is{0}", (num1 / num2));
                        break;
                    case 5:
                        Console.WriteLine(" You enter the wrong option");
                        break;
                    default:
                        break;

                }
                Console.WriteLine("Do you want to continue:? Y or N");
                     yes = Console.ReadLine().ToUpper();

            } while (yes!="N");


            Console.ReadLine();
        }
    }
}
