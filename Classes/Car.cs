using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Car
    {
        class Engine
        {
            public int Power { get; }
            public int Speed { get; }
            public int Torque { get; }

            public Engine(int power, int speed, int torque)
            {
                Power = power;
                Speed = speed;
                Torque = torque;
            }
            public void Start()
            {
                Console.WriteLine("Engine has been started!");
            }
        }
        private Engine CarEngine { get; }

        public Car(int price)
        {
            CarEngine = price switch
            {
                10000 => new Engine(60, 2000, 210),
                15000 => new Engine(75, 3450, 122),
                _ => throw new Exception("Enter the correct price")
            };
        }

        public void Go()
        {
            CarEngine.Start();
            Console.WriteLine("The car is moving...");
        }
    }
   
}
