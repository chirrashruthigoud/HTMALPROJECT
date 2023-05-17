using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlProjectProgram
{
    public class Basicclass
    {
        public void SumofNaturalnum()
        {
            int n = 5;
            int sum = 0;

            int i = 1;
            while (i <= n)
            {
                sum += i;
                i++;

            }
            Console.WriteLine($"the first natural {n}is : {sum}");
        }


        int num;
        public void CheckEvenOdd()
        {
            Console.WriteLine("Enter the Number:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Number is even.");
            }
            else
            {
                Console.WriteLine("Number is odd.");
            }
        }


        int age;
        public void AgeEligibility()
        {
            Console.WriteLine("Enter the Number:");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Candidate Eligible to Vote.");
            }
            else
            {
                Console.WriteLine("Candidate Not Eligible to Vote.");
            }
        }


        public void largestofthree()
        {
            Console.WriteLine("enter first Number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third number:");
            int z = Convert.ToInt32(Console.ReadLine());
            int largest;
            if (x >= y && x >= z)
            {
                largest = x;
            }
            else if (y >= x && y >= z)
            {
                largest = y;
            }
            else
            {
                largest = z;
            }
            Console.WriteLine("the largest is {0}.", largest);
            Console.ReadLine();

        }


        public void ReverseString()
        {
            Console.WriteLine("enter a name");
            string name = Console.ReadLine();
            string xname = " ";

            int i = name.Length - 1;

            while (i >= 0)
            {
                xname += name[i];
                i--;
            }
            Console.WriteLine($"reverse name is : {xname}");

        }


        public void admissioneligibility()
        {
            int Mathsmarks, Pysicsmarks, Chemistrymarks, totalmarks;
            Console.WriteLine("Enter the Maths marks:");
            Mathsmarks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Pysics marks:");
            Pysicsmarks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Chemistry:");
            Chemistrymarks = Convert.ToInt32(Console.ReadLine());
            totalmarks = Mathsmarks + Pysicsmarks + Chemistrymarks;
            if (Mathsmarks >= 65 && Pysicsmarks >= 55 && Chemistrymarks >= 50 && totalmarks >= 180)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else if (Mathsmarks >= 65 && (Pysicsmarks >= 55 || Chemistrymarks >= 50) && (Mathsmarks + Pysicsmarks + Chemistrymarks >= 140))
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
            Console.ReadLine();
        }

        public void WeekDays()
        {
            Console.WriteLine("Enter a Day:");
            int Day = int.Parse(Console.ReadLine());

            switch (Day)
            {
                case 1:
                    Console.WriteLine("It is Monday.");
                    break;
                case 2:
                    Console.WriteLine("It is Tuseday.");
                    break;
                case 3:
                    Console.WriteLine("It is Wednesday.");
                    break;
                case 4:
                    Console.WriteLine("It is Thusday.");
                    break;
                case 5:
                    Console.WriteLine("It is Friday.");
                    break;
                case 6:
                    Console.WriteLine("It is Saturday.");
                    break;
                case 7:
                    Console.WriteLine("It is Sunday.");
                    break;

                default:
                    Console.WriteLine("Invalid Day");
                    break;
            }
        }

        public void Tables()
        {
            int i;
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                Console.WriteLine($"table of 3*{i}={3 * i}");
            }

            Console.ReadKey();
        }
        public void SumOfquares()
        {
            int i;
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            int sumofsquare = 0;
            for (i = 1; i <= n; i++)
            {
                sumofsquare = i * i;

                Console.WriteLine($"The sum of squares numbers {n} start of {i} is {sumofsquare}.");
            }

            Console.ReadKey();
        }


        public void Factorial()
        {

            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;

                Console.WriteLine($"{n}!={factorial}.");
            }

            Console.ReadKey();
        }
    }
}
