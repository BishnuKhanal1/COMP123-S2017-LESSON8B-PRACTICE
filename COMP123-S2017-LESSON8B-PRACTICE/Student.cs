using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2017_LESSON8B_PRACTICE
{
    /// <summary>
    /// this is a student child class class
    /// </summary>
   public class Student : Person  //student inherits from Person parent/super class
    {
        //private instance variables/fields
        private string _studentID;
        
        //public properties
        public string StudentID
        {
            get
            {
                return this._studentID;
            }
            set
            {
                this._studentID = value;
            }
        }
        //constructor------------
        /// <summary>
        /// This is the constructor for the student class
        /// takes three arguments - name(string), age(int) and strudentID(string)
        /// </summary>
        /// <param name="name"></param> //these are xml tags that format for code hinting/intellesence
        /// <param name="age"></param>
        /// <param name="studentID"></param>
        public Student(string name, int age, string studentID)
            :base(name, age)
        {
            this.StudentID = studentID;
        }

        //public methods
        /// <summary>
        /// this is the Studies method
        /// enables the student to study
        /// </summary>
        public void Studies()
        {
            Console.WriteLine(this.Name + " is studying!");
        }
    }
}
