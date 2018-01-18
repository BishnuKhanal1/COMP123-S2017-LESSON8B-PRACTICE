using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2017_LESSON8B_PRACTICE
{
    /*Note: to add git repo in VS first, go to 'Tools', click 'Extension and Updates', 
     * click 'Online' and in search box-type 'git'
     * you will see 'Github' and install it in Vs. 
     * */


        /// <summary>
        /// This is the person class
        /// </summary>

    class Person
    {
        //private instance variables(fields)
        private string _name;
        private int _age;

        //public properties

        public string Name
        {
            get
            {
                return this._name; //get and set accessor method
            }
            set
            {
                this._name = value; //value is a key word , indicates the value given to _name;
            } //properties function like method as accessor
        }

        public int Age
        {
            get
            {
                return this._age;
            
            }
            set
            {
                this._age = value;  //instance variables are going to be accessed through propertes, not directly to them
            }
        }
        //constructors --------------
        /// <summary>
        /// thisis the constructor for the person class
        /// it takes two arguments = name(string) and age(int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        //public mwthods (methods are behavours/ functionalaties)eg: person can talk
        /// <summary>
        /// this method enablesthe person object to talk
        /// </summary>
        public void Talks()
        {
            Console.WriteLine(this.Name+ " is talking");
        }
    }
}
