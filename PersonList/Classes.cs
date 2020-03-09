using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonList {
    class cPersonList {
        private string name;
        private string state;

        private string gender;

        public cPersonList (string cName, string cGender, string cState) { }

        public override string ToString () {
            return "Name: " + name + "\n" + " Gender: " + gender + "\n" + " State: " + state + "\n";
        }

        public string getName () {
            return name;
        }

        public void setName (string cName) {
            name = cName;
        }

        public string getGender () {
            return gender;
        }

        public void setGender (string cGender) {
            gender = cGender;
        }

        public string getState () {
            return state;
        }

        public void setAge (string cState) {
            state = cState;
        }

        // public void listSummary (int[] numStudnets, ) {
        //     System.Console.WriteLine ("The ");

        //     for (int i = 0; i < numStudnets.Length; i++) {
        //         System.Console.WriteLine ("The student Named: " + );

        //         System.Console.WriteLine ();
        //     }

        // }

        public void dupCheck () {
            List<string> studentCollection = new List<string> ();

            if (studentCollection.Count != studentCollection.Distinct ().Count ()) {

            }

        }

    }

}