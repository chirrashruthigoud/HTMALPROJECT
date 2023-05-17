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
        public  void Palindrome()
        {

            string string1, rev;
            Console.WriteLine("Enter the String to check is Palindrome or not ");
            string1 = Console.ReadLine();
            string s1 = string1.ToLower();
            char[] ch = s1.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);
            bool b = s1.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine("" + string1 + " is a Palindrome!");
            }
            else
            {
                Console.WriteLine(" " + string1 + " is not a Palindrome!");
            }
        }

        public  void CheckReversenumber()
        {
            int n, reverse = 0, rem;
            Console.WriteLine("Enter the Number : ");
            n = Convert.ToInt32(Console.ReadLine());

            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine("Number Reversed " + reverse);

        }

        public  void Checkthecharacter()
        {
            char ch;
            Console.WriteLine("Enter any Character");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch + " is Vowel ");

            }
            else if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z')
            {

                Console.WriteLine(ch + " is Constant ");
            }
            else
            {
                Console.WriteLine(" ");
            }
        }
        public  void CheckPrimefactor()
        {
            Console.WriteLine("Enter a number to find its prime factor:");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(N);

            int i;
            int a = 0;
            for (i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    a++;
                }

            }
            if (a == 2)
            {
                Console.WriteLine("Prime Number");
                int fact = 1;
                int factor;
                for (i = 2; i <= N; i++)
                {
                    factor = fact * i; //fact = fact * i
                    Console.Write(factor);
                }
            }
            else
            {
                Console.WriteLine("Not prime number");
            }
        }
        public  void FindPerfectNumber()
        {
            int n, i, sum;
            int mn, mx;
            Console.WriteLine("Input the starting range or number");
            mn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the starting range or number");
            mx = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The perfect numbers within the given range : ");
            for (n = mn; n < mx; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)

                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                {
                    Console.WriteLine("{0}", n);
                }
            }
        }
        public void CheckPrimeNumber()
        {
            int a = 0, i, num;
            Console.WriteLine("Enter your Number to Check Prime number or not");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);
            for (i = 1; i <= num; i++)
            {

                if (num % i == 0)
                {
                    a++;

                }
            }
            if (a == 2)
            {
                Console.WriteLine("Prime number");

            }
            else
            {
                Console.WriteLine("Not Prime number");
            }
        }

    }

}
