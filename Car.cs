using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    public class Car
    {
        //these are fields
        public int nrWheels;
        public string color;
        public int nrDoors;
        public bool isRunning;
        string carName;

        public string Name {
            get=> carName;
            set=> this.carName = value;
        }

        public Car()
        {
            this.color = "white";
            this.isRunning = false;
            this.nrDoors = 2;
            this.nrWheels = 4;
            this.carName = null;
        }
        //these are constructors
        public Car(string newColor) : this()
        {
            this.color = newColor;
        }
        public Car(string newColor, string newName) : this()
        {
            this.color = newColor;
            this.NameMyCar(newName);
        }

        public void FlatTire()
        {
            this.nrWheels--;
        }
        public void NameMyCar(string newName)
        {
            this.Name = newName;
        }
    }
}
