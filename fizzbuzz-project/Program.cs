using System;

namespace fizzbuzz_project
{
    class Program
    {
        static void Main(string[] args)
        {

            int fbuzz = 1000;

           for (int i = 0; i <= fbuzz; i++)
           {

               if(i % 3 == 0)
               {
                    System.Console.Write(i + " " + "Fizz " + " ");
               }

                 if(i % 5 == 0)
               {
                   System.Console.Write(i + " " + "Buzz " + " ");

               }


                 if(i % 5 == 0 && i % 3 == 0)
               {
                   System.Console.WriteLine("(Fizz" + "Buzz)");
               }

           }


           int[] nFizz = {fbuzz};
               int[] nBuzz = {fbuzz};

               for (int j = 0; j < nFizz.Length; j++)
               {
                   if(j % 3 == 0)
                   {
                       System.Console.WriteLine("There are " + nFizz[j] + " Fizz");
                   }
               }


               for (int k = 0; k < nBuzz.Length; k++)
               {
                   if(k % 5 == 0)
                   {
                       System.Console.WriteLine("There are " + nFizz[k] + " Buzz");
                   }
               }
        }
    }
}
