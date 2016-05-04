using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqToEnteties
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = CarsInitializer.FillCars(new Car());

            

            foreach (var car in cars)
            {
                foreach (var carList in car.Cars)
                {
                    Console.WriteLine(car.Name + "." + carList.Name);
                }
            }

            Console.ReadKey();
        }

        public class Car
        {
            public string Name { get; set; }
            public List<Car> Cars { get; set; }
        }

        public static class CarsInitializer 
        {
            public static List<Car> FillCars(Car car)
            {
                List<Car> cars = new List<Car>(); 
                car = new Car
                {
                    Name = "1",

                    Cars = new List<Car>
                    {
                        new Car()
                        {
                            Name = "1",
                            Cars = new List<Car>()
                        },
                        new Car()
                        {
                            Name = "2",
                            Cars = new List<Car>()
                        },
                        new Car()
                        {
                            Name = "3",
                            Cars = new List<Car>()
                        },
                        new Car()
                        {
                            Name = "4",
                            Cars = new List<Car>()
                        },
                        new Car()
                        {
                            Name = "5",
                            Cars = new List<Car>()
                        },
                        new Car()
                        {
                            Name = "6",
                            Cars = new List<Car>()
                        },
                        new Car()
                        {
                            Name = "7",
                            Cars = new List<Car>()
                        },
                        new Car()
                        {
                            Name = "8",
                            Cars = new List<Car>()
                        },
                        new Car()
                        {
                            Name = "9",
                            Cars = new List<Car>()
                        },
                        new Car()
                        {
                            Name = "10",
                            Cars = new List<Car>()
                        }
                    }
                };
                cars.Add(car);
                return cars;
            }
        }
    }
}
