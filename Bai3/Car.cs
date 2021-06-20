using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Car:Icar
    {
        public string name { get; set; }
        public string producer { get; set; }
        public int year { get; set; }
        public int seat { get; set; }
        public float rootPrice { get; set; }
        public float caculateTax(Car car)
        {
            
            if(car.seat < 7)
            {
                return (car.rootPrice *60/100);
            }
            else
            {
                return car.rootPrice * 70 / 100;
            }
        }
        public virtual float caculatePrice(Car car)
        {

            return rootPrice + caculateTax(car);
        }
        public void getinFor(string name , string producer, int year, int seat , float price)
        {
            
            Console.WriteLine($"Car { name} produced by {producer} in {year} has {seat} with the total price is {price}");
        }
    }
}
