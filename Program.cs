using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        class MyException : Exception
        {
            //public MyException(string message, i)
        }


        class Manufacther
        {
            private string _name;
            private static int _id;
            private readonly uint _limit;

            public Manufacther(string Name, uint limit)
            {
                _name = Name;
                _id = 1;
                _limit = limit;
         
            }

            public Car CreateCar(uint speed)
            {

                if (_id <= _limit)
                {
                    var x = new Car(_name, Convert.ToString(_id + _name), _id, DateTime.Today, speed);
                    _id++;
                    return x;
                }
                else
                    throw new Exception("dsadas");         

            }


        }

        class Car
        {
            private string _name;
            private int _id;
            private string _number;
            private DateTime _dateManuf;
            private uint _speed;
            private readonly uint _maxspeed;

            public uint Speed
            {
                get { return _speed; }
                set
                {
                    _speed = value;
                    if (_speed > _maxspeed)
                    {
                        Breaking();
                    }
                }
            }
            public Car()
            {

            }

            public Car(string Name, string Number, int Id, DateTime DateManuf, uint speed)
            {
                _name = Name;
                _id = Id;
                _number = Number;
                _dateManuf = DateManuf;
                _maxspeed = speed;
                _speed = 0;
            }

            public void Voice()
            {
                Console.WriteLine("Bi-bi-bi");
                Console.WriteLine($"Name: {_name}, Id: {_id}, Number: {_number}");
            }

            public void Breaking()
            {
                for (int i = 0; i < 5; i++)
                    Speed--;
            }

            public void Run()
            {
                Speed++;
            }
        }


        public static uint GetMaxSpeed()
        {
            try
            {
                Console.WriteLine("Enter MaxSpeed:");
                var x = Convert.ToUInt32(Console.ReadLine());
                return x;
            }
            catch
            {
                Console.WriteLine("Wrong input");
                Console.WriteLine("MaxSpeed = 60");

                return 60;
            }

        }
        public static uint GetLimitManuf()
        {
            try
            {
                Console.WriteLine("Enter limit for creation:");
                var x = Convert.ToUInt32(Console.ReadLine());
                return x;
            }
            catch
            {
                Console.WriteLine("Wrong input");
                Console.WriteLine("Limit = 10");

                return 10;
            }
        }

        static void Main(string[] args)
        {
            
            uint lim = GetLimitManuf();
            Manufacther m = new Manufacther("Lada", lim);
            uint max = GetMaxSpeed();
            var c = m.CreateCar(max);

            for (int i = 0; i < 100; i++)
            {
                c.Run();

                Console.WriteLine(c.Speed);
            }
                c.Voice();
        }
    }
}