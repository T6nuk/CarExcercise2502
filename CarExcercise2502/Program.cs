using System;

namespace CarExcercise2502
{
    class Program
    {
        static void Main(string[] args)
        {


            Car car1 = new Car("Audi", "A6", "3GGGXXX", "red");
            
            car1.DisplayProperties();

            for (int i = 0; i < car1.ShowFuel; i++)
            {
                car1.DriveCar();
            }
            car1.DisplayProperties();
            car1.DriveCar();
            car1.DriveCar();
            car1.DriveCar();

        }
    }
}
