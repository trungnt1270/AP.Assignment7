using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
/*
            Car car = new Car() { name = "Ford", producer = "Ford", seat = 4, year = 1997, rootPrice = 1000 };



            car.getinFor(car.name, car.producer, car.seat, car.year, car.caculatePrice(car));


            Car car1 = new LuxuryCar() { name = "Ford", producer = "FordTurner", seat = 6, year = 1998, rootPrice = 2000, specialRate = 0.5f };

            car1.getinFor(car1.name, car1.producer, car1.seat, car1.year, car1.caculatePrice(car1));*/

            BusCollection objCar = new BusCollection(5);
            objCar[0] = new LuxuryCar() { name = "BMW", producer = "BMW", seat = 4, year = 1997, rootPrice = 1500, specialRate= 0.5f };
            objCar[1] = new LuxuryCar() { name = "BMW", producer = "BMW", seat = 5, year = 1998, rootPrice = 1000, specialRate = 1.5f };
            objCar[2] = new Car() { name = "BMW", producer = "BMW", seat = 6, year = 1999, rootPrice = 2000 };
            objCar[3] = new Car() { name = "BMW", producer = "BMW", seat = 7, year = 2000, rootPrice = 3000 };
            objCar[4] = new Car() { name = "BMW", producer = "BMW", seat = 8, year = 2001, rootPrice = 2500 };
            objCar.displayDetail();
            Console.ReadKey();
    
        }
    }
}
