using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class BusCollection:LuxuryCar
    {
        public Car[] objCar;

        public BusCollection(int n)
        {
            objCar = new Car[n];

        }
        public Car this [int index]
        {
            get { return objCar[index]; }
            set { objCar[index] = value; }
        }
        public void displayDetail()
        {
            Console.WriteLine("Bus Name \t\t Bus Producer\t Seat\tYear\tTotal Price");
            Console.WriteLine("--------\t\t--------------\t------\t----\t-----------");
            foreach (var car in objCar)
            {
                Console.WriteLine($"{car.name}\t\t{car.producer}\t{car.seat}\t{car.year}\t{caculatePrice(car)}");
            }

        }


    }
}
