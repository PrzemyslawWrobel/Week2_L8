using System;

namespace Week2_l8
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadanie_10();
            //Zadanie_9();
            //Zadanie_8();
            //Zadanie_7();
            //Zadanie_6();
            //Zadanie_5();
            //Zadanie_4();
            //Zadanie_3();
            //Zadanie_2();
            //Zadanie_1();
        }

        private static void Zadanie_10()
        {
            Console.WriteLine("Give first number: ");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Give second number: ");
            int second = int.Parse(Console.ReadLine());

            int i = first;

            while (i % second != 0)
            {
                i += first;

            }

            Console.WriteLine($"Least common multiple: {i}");

        }

        private static void Zadanie_9()
        {
            Console.Write("Wprowadź liczbę dziesiętną: ");
            int numberToChange = Int32.Parse(Console.ReadLine());
            string changedRev = "";
            string changed = "";

            while (numberToChange > 0)
            {
                changedRev += (numberToChange % 2);
                numberToChange /= 2;
            }

            for (int i = changedRev.Length - 1; i >= 0; i--)
            {
                changed += changedRev[i];
            }
            Console.WriteLine("Reprezentacja binarna liczby to: " + changed);
        }

        private static void Zadanie_8()
        {
            Console.WriteLine("Program odwraca wpisany ciąg znaków np ABC i wypisuje CBA");

            string str = Console.ReadLine();
            char[] characters = str.ToCharArray();
            int a = characters.Length;
            Console.Write("Odwrócony string to: ");
            for (int i = a; i > 0; i--)
            {
               int  b = i - 1;
               char m = characters[b];
               Console.Write(m);
            }

        }

        private static void Zadanie_7()
        {
            int a = 8;
            int b = a - 1;
            for (int i = 0; i <= a; i++)
            {
                for (int j = i; j < a; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= (2 * i - 2); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = b; i >0; i--)
            {
                for (int j = i; j < b+1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= (2 * i - 2); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        private static void Zadanie_6()
        {
            double suma;
            for (int i = 1; i < 20; i++)
            {
                suma = i + (i /2 )+ (i / 3) + (i / 4);
                Console.WriteLine(suma);              
            }
        }

        private static void Zadanie_5()
        {
            double potęga;

            for (int i = 1; i < 20; i++)
            {
                potęga = Math.Pow(i, 3);

                Console.WriteLine($"Potęga liczby {i} to: " + potęga);
            }
        }

        public static void Zadanie_4()
        {
            int a = 8;
            int b = 1;
            for (int i = 0; i <= a; i++)
            {
             
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(b++);
                }
                Console.WriteLine();
               
            }
        }

        private static void Zadanie_3()
        {

            int a = 0;
            int b = 1;
            int next;

            Console.WriteLine("Program implementuje ciąg Fibonacciego i wyświetla go na ekranie");
            Console.WriteLine("Podaj liczbę do jakiej ma być liczony");

            int fibonacciego = Int32.Parse(Console.ReadLine());
            while (a + b <= fibonacciego)
            {
                next = a + b;
                a = b;
                b = next;

                Console.Write(" " + next);
            }
        }

        private static void Zadanie_2()
        {
            double number = 1;

            Console.WriteLine("Program znajduje liczby parzyste w zakresie <1,1000>");
            Console.WriteLine("Lista liczb parzystych: ");
            do
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                    number++;
                }
                else
                {
                    number++;
                }

            } while (number <= 1000);
        }

        private static void Zadanie_1()
        {
            Console.WriteLine("Liczby pierwsze od 0 do 100");
            Console.WriteLine("Liczby 0 i 1 nie spełniają warunków dla liczb pierwszych");

            int prime = 0;

            for (int i = 2; i <= 100; i++)
            {

                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    prime++;
                    Console.WriteLine(i + " ");
                }
            }
            Console.WriteLine(prime);
        }
    }
}
