using System;
using System.Collections.Generic;
using System.Text;

namespace CarExcercise2502
{
    class Car
    {
        private string _name;
        private string _model;
        private string _regnum;
        private string _color;
        private int _odometer;
        private int _fueltank;


        public Car (string name, string model, string regnum, string color)
        {


            _name = name;
            _model = model;
            _regnum = regnum;
            _color = color;
            _odometer = 0;
            _fueltank = 60;

            if (_regnum.Length > 6)
            {

                throw new ArgumentOutOfRangeException("Registration number", "Registration number can be a maximum of 6 characters!");
                
            }


        }

        public string CarName
        {
            get
            {
                return _name;
            }
        }
        public string CarModel
        {
            get
            {
                return _model;
            }
        }
        public string RegisterNumber
        {
            get
            {
                return _regnum;
            }
        }
        public string CarColor
        {
            get
            {
                return _color;
            }
        }
        public int ShowFuel
        {
            get
            {
                return _fueltank;
            }
        }

        public void DriveCar()
        {
            if (_fueltank == 0)
            {
                Console.WriteLine($"Your car ran out of fuel! Fuel: {_fueltank}");
                return;
            }
            _odometer += 100;
            _fueltank -= 5;
        }
        public void DisplayProperties()
        {
            Console.WriteLine($"Name of the car: {_name}\nModel of the car: {_model}\nRegistration number of the car: {_regnum}\nColor of the car: {_color}");
            Console.WriteLine($"Odometer shows: {_odometer}\nFuel left: {_fueltank}");
        }
    }
}
