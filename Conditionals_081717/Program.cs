using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals_081717
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your age");

            //int age = int.Parse(Console.ReadLine());
            //if (age >= 17)
            //{
            //    Console.WriteLine("You can see this movie");
            //}
            //if(age == 18)
            //{
            //    Console.WriteLine("You are now an adult");
            //        }
            //else if (age == 21)
            //{
            //    Console.WriteLine("Let's get a drink");
            //}

            //else

            //{

            //    Console.WriteLine("Sorry you are too young you need a parent present");
            //}

            //Console.WriteLine("Enter your percentage");
            //int grade = int.Parse(Console.ReadLine());
            //if(grade >= 90 && grade <= 100)
            //{
            //    Console.WriteLine("You got an A!!");
            //        }
            //else if (grade >= 80 && grade <= 89)
            //{
            //    Console.WriteLine("You got a B!!");
            //}

            // user inputs number of people in dinner party and the total of the bill
            Console.WriteLine("How many people were in your dining party?");
            int dinnerParty = int.Parse(Console.ReadLine());
            Console.WriteLine("What was the total of you bill?");
            double dinnerBill = double.Parse(Console.ReadLine());

            // computer calculates the customer appreciation discount and gives each person's total
            double totalCost = dinnerBill;
            if (totalCost >= 50)
            {
              Console.WriteLine("Congratulation, You received a 10% discount on your bill");
              Console.WriteLine("Each person owes $" + ((totalCost - (totalCost * .10)) / dinnerParty));
            
            }
            else if (dinnerBill < 50)
            { Console.WriteLine("Congratulations! You received a 5% discount on your bill");
              Console.WriteLine("Each person owes $" + ((totalCost - (totalCost * .05)) / dinnerParty));
            }
        }
    }
}
