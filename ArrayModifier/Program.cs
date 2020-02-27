using System.Reflection.Metadata;
using System;

namespace ArrayModifier
{
    class Program
    {
        // accept input from user, list of numbers separated by spaces
        // interpret that as an int array
        // print the array's values back to the user


        // ask the user for some operation
        // print the array's new values to the user.
        static void Main(string[] args)
        {

            string input = GetInput();
            int[] array = InterpretStringAsArray(input);
            PrintArray(array);

            PrintArray(takeAway(array));



        }


        static int[] takeAway(int[] arrayA)
        {

            //ask user if they want to remove a number from the sequence
            Console.Write("What would you like to do? ");

            Console.WriteLine("Press 1. for remove a number \nPress 2. for add the numbers");
            int request = int.Parse(Console.ReadLine());

            if (request == 1)
            {



                //print the batch of numbers so that they cans see what their options are.
                PrintArray(arrayA);
                //ask the user which number they would like to remove.
                Console.WriteLine("Which number would you like to remove?");
                //ask the user to choose which number out of the numbers that are printed.
                int nAsnwer = int.Parse(Console.ReadLine());


                for (int i = 0; i < arrayA.Length; i++)
                {
                    if (nAsnwer == arrayA[i])
                    {
                        arrayA[i] = 0;

                    }

                }




            }

            else if (request == 2)
            {
                addNums(arrayA);
            }


            return arrayA;

        }


        static void addNums(int[] arrayB)
        {
            int add = 0;
            for (int i = 0; i < arrayB.Length; i++)
            {
                add = add + arrayB[i];
            }

            Console.WriteLine(add);
        }


        static void PrintArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                //printing all slots of the Array "a".
                Console.Write(a[i]);
            }

            Console.WriteLine();
        }

        static int[] InterpretStringAsArray(string str)
        {
            //List of numbers 
            string[] strArray = str.Split(' ');
            //create an array the same size as the string array
            int[] intArray = new int[strArray.Length];

            for (int i = 0; i < strArray.Length; i++)
            {

                //this is converting the string array into integers
                intArray[i] = int.Parse(strArray[i]);


            }
            //returning the int array to the main function.
            return intArray;

        }

        // any method is going to have
        // 1. a name
        // 2. a return value: either nothing (void), or some type e.g. int
        // what result does the method need to send back to the code that uses this method.
        // 3. a list of parameters (maybe empty)
        // does the method need any input from the code that uses it to do its job.
        static string GetInput()
        {
            string str = Console.ReadLine();

            return str;

        }

        static int Add(int a, int b)
        {
            int result = a + b;
            return result;
            // you use "return" to send the return value back to the
            // code that calls this method.
        }
    }
}