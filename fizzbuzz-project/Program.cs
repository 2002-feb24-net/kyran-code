using System;

namespace fizzbuzz_project
{
    class Program
    {
        static void Main(string[] args)
        {

            int fbuzz = 1000;
            int numFizz = 0;
            int numBuzz = 0;
            int numTotal = 0;

            for (int i = 0; i < fbuzz; i++)
            {

                if (i % 3 == 0 && i % 5 != 0)
                {
                    numFizz++;
                    System.Console.Write(i + " " + "Fizz " + " ");
                }

                if (i % 5 == 0 && i % 3 != 0)
                {
                    numBuzz++;
                    System.Console.Write(i + " " + "Buzz " + " ");

                }


                if (i % 5 == 0 && i % 3 == 0)
                {
                    numTotal++;
                    System.Console.WriteLine("(Fizz" + "Buzz)");
                }

            }


            System.Console.WriteLine("There are (" + numFizz + ") Fizz's");
            System.Console.WriteLine("There are (" + numBuzz + ") Buzz's");
            System.Console.WriteLine("There are (" + numTotal + ") FizzBuzz's");
        }
    }
}
