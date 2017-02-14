using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune.teller
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName;
            string lastName;
            int age;
            int birthMonth;
            int numberOfSibs;
            string[] myArray = { "red", "orange", "yellow", "green", "blue ", "indigo", "violet" };
            string favColor;
            int retirementyears;


            Console.WriteLine("What is your first name?");
            firstName = (Console.ReadLine().ToLower());

            Console.WriteLine("What is your last name?");
            lastName = (Console.ReadLine().ToLower());

            Console.WriteLine("What is your age?");
            age = int.Parse(Console.ReadLine().ToLower());

            Console.WriteLine("What is your birth month? i.e. number january will be 1");
            birthMonth = int.Parse(Console.ReadLine().ToLower());

            Console.WriteLine("What is favorite ROYGBIV color? \nIf you do not know what ROYGBIV is enter Help  ");
            favColor = (Console.ReadLine().ToLower());


            if ((favColor.Equals("help", StringComparison.OrdinalIgnoreCase)))
            {

                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.WriteLine(myArray[i]);

                 //   Console.WriteLine("What is favorite ROYGBIV color of the options given?  ");
                   // favColor = (Console.ReadLine());
                }

                Console.WriteLine("What is favorite ROYGBIV color of the options given?  ");
                //favColor.ToLower();
                favColor = (Console.ReadLine().ToLower());
                

            }

            Console.WriteLine("How many sibilings do you have?");
            numberOfSibs = int.Parse(Console.ReadLine());


            if (age % 2 == 0)
            {
                retirementyears = 50;
            }

            else
            {
                retirementyears = 30;

            }


            string location;           
            {
              
            if (numberOfSibs == 0)
            {
                    location = "hawaii";
            }

            else if (numberOfSibs == 1)
            {
                    location = "jamaica";
            }

            else if (numberOfSibs == 2)
            {
                    location = "San diego";
            }

            else if (numberOfSibs == 3)
            {
                    location = "Atlanta";
            }
            else if (numberOfSibs > 3 )
            {
                    location = "Los Angeles";
            }
            else
                {
                    location = "Buffalo";
                }

        }


        string transportation = favColor;

            switch (favColor)
            {
                case "red":
                    transportation = "car";
                    break;
                case "orange":
                    transportation = "boat";
                    break;
                case "yellow":
                    transportation = "train";
                    break;
                case "green":
                    transportation = "motorcycle";
                    break;
                case "blue":
                    transportation = "helicopter";
                    break;
                case "indigo":
                    transportation = "uberxl";
                    break;
                case "violet":
                    transportation = "skateboard";
                    break;

                default:
                    Console.WriteLine();
                    break;

            }

            double amountOfMoney;

            if (birthMonth >= 1 && birthMonth <= 4)
            {
                amountOfMoney= 1000.00;
            }

            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                amountOfMoney = 5000.00;
            }

            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                amountOfMoney = 10000.00;
            }        
           else
            {
                amountOfMoney= 0.00;
            }
         

            Console.WriteLine(firstName +" "+ lastName + " will retire in " + retirementyears + " years with $" + amountOfMoney + " in the bank, a vacation home in " + location + " and a " + transportation + ".");



        }
    }
}
/*               for (int i = 0; i < myArray.Length; i++)
                     {
                         Console.WriteLine(myArray[i]);
                     }


     Console.WriteLine(firstName + lastName +transportation + location +retirementyears);

     favColor.Equals("red", StringComparison.OrdinalIgnoreCase);


     case 0:
                    location = "hawaii";
                    break;
                case 1:
                    location = "jamaica";
                    break;
                case 2:
                    location = "Atlanta";
                    break;
                case 3:
                    location = "San diego";             
                    break;

                default:
                    location = "Buffalo";
                    break;

*/
