﻿using System;
using System.Collections.Generic;
using System.Text;


namespace Palindrome
{
    public class pDrome : IPalindrome
    {

        string tempString = "";
        string inputString = tempString.ToLower();

        


        public void checkPDrome()
        {
            Console.WriteLine("Input some data to Please");

            string uInput = Console.ReadLine();

            int inputLength = uInput.Length;
            
            if (inputLength == 0)
            {
                Console.WriteLine("You MUST enter something, you cannot leave blank!");

            }

            else
            {

                for (int j = inputLength - 1; j >= 0; j--)
                {
                    inputString = inputString + uInput[j];
                }

                if (inputString == uInput)
                {
                    Console.WriteLine(uInput + " is palindrome!");
                }
                else
                {
                    Console.WriteLine(uInput + " is not a palindrome!");
                }

            }
        }
    }
}
