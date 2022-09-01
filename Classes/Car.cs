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
            private bool _isDefective;

            public int Power { get; }
            public int Speed { get; }
            public int Torque { get; }

            public Engine(int power, int speed, int torque)
            {
                Power = power;
                Speed = speed;
                Torque = torque;

                _isDefective = IsDefective();
            }
            private bool IsDefective()
            {
                Random random = new();
                return random.Next(2) == 1;
            }
            public bool Start()
            {
                if(_isDefective)
                {
                    Console.WriteLine("Engine hasn't been started...");
                    return false;
                }
                Console.WriteLine("Engine has been started!");
                return true;
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
            if(CarEngine.Start())
                Console.WriteLine("The car is moving...");
        }   
    }
   
}
