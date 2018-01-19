using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_S2017_LESSON8B_PRACTICE
{
    //inconsistance accessibility problem occurs if the super class is not public(acessble)
    public class DomesticStudent : Student
    {


        //public properties
        public string DomesticAddress { get; private set; } //readonly property

       


        //constructor------------------------

        /// <summary>
        /// this is the costructor - takes three arguments
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="studentID"></param>
        public DomesticStudent(string name, int age, string studentID):
            base(name, age, studentID)
        {
            
        }
        //public methods------------------

            /// <summary>
            /// this method sets the domestic address property
            /// </summary>
            /// <param name="address"></param>
        public void SetDomesticAddress(string address)
        {
            this.DomesticAddress = address;
        }
    }
}