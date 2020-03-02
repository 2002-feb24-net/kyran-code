using System;

namespace CPU_github
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter in some text please: ");
            string nString = System.Console.ReadLine();

            eString(nString);


        }




        static void eString(string str)
        {


            string[] sString = str.Split(" ");

            for (int i = 0; i < sString.Length; i++)
            {
                Console.Write(sString[i].Substring(0, 1));
            }
        }


    }
}
