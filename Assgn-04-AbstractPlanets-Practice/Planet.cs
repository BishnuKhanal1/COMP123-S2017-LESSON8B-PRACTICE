using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgn_04_AbstractPlanets_Practice
{
    //this is planet class
    class Planet
    {
        //private instance variables/ fields
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        //properties

        public double Diameter
        {
            get
            {
                return this._diameter;
            }
           
        }
        public double Mass
        {
            get
            {
                return this._mass;
            }
        }
        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }
        public string Name
        {
            get
            {
                return this._name;
            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }
        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }

        //constructor
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;

        }

        //@override toString()method that returns the Name, Diameter, and Mass
        public override string ToString()
        {
            string outputString = " ";
            outputString = "\nName\t:\t " + this.Name + "\nDiameter:\t " + this.Diameter + "\nMass\t:\t " + this.Mass +" kg";
            return outputString;
        }
    }
}
