using System;
using System.Linq;
using System.Collections.Generic;

namespace PersonList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("Hello, Here we hae a list of the students in the classroom: \n");


            var firstStudent = new cPersonList("Kyran", "Male", "California");

            var secondStudent = new cPersonList("Stacey", "Female", "South Carolina");

            var thirdStudent = new cPersonList("Nick", "Male", "Seattle");

            var fourthStudent = new cPersonList("Paul", "Male", "Texas");

            var fifthStudent = new cPersonList("Brendan", "Male", "North Dakota");

            var sixthStudent = new cPersonList("Diana", "Female", "California");

            var pInfo = new List<object>();
            pInfo.Add(firstStudent);
            pInfo.Add(secondStudent);
            pInfo.Add(thirdStudent);
            pInfo.Add(fourthStudent);
            pInfo.Add(fifthStudent);
            pInfo.Add(sixthStudent);

           firstStudent.dupCheck();
           secondStudent.dupCheck();
           thirdStudent.dupCheck();
           fourthStudent.dupCheck();
           fifthStudent.dupCheck();
           sixthStudent.dupCheck();

            foreach (var item in pInfo)
            {
                System.Console.WriteLine(item);
            }





        }
    }
}
