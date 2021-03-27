using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HotHouse_Task
{
    class Program
    {
        static void Main()
        {
            Heater heater = new Heater();
            Cooler cooler = new Cooler();
            AllRight well = new AllRight();

            Hothouse hothouse = new Hothouse(5, 8, 30);

            hothouse.TooCold += heater.Heat;
            hothouse.TooHot += cooler.Cool;
            hothouse.Well += well.Well;
            while (true)
            {
                Random tmp = new Random();
                hothouse.Temperature += tmp.Next() % 5 - 2;
                Thread.Sleep(800);
            }
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading;


//namespace ConsoleApp4
//{
//    class HotHouse
//    {
//        public readonly int MaxT;
//        public readonly int MinT;
//        public event TemparatureError TooHot;
//        public event TemparatureError TooCold;
//        public event TemparatureError Well;
//        public HotHouse(int Current, int Min = 10, int Max = 20)
//        {
//            MaxT = Max;
//            MinT = Min;
//            Temparature = Current;
//        }
//        private int temparature;
//        public int Temparature
//        {
//            get => temparature;
//            set
//            {
//                temparature = value;
//                Console.WriteLine($"Current temparature: {Temparature}");
//                if (Temparature > MaxT)
//                {
//                    Console.WriteLine($"Current temparature too hot! After cooling: ");
//                    TooHot(this, 5);
//                    return;
//                }
//                if (Temparature < MinT)
//                {
//                    Console.WriteLine($"Current temparature too cold! After heating: ");
//                    TooCold(this, 5);
//                    return;
//                }
//                if (Temparature > MinT && Temparature < MaxT)
//                {
//                    Well?.Invoke(this, 0);
//                    Console.WriteLine($"All right");
//                }

//            }
//        }
//    }
//    class Heater
//    {
//        public void Warm(HotHouse h, int t)
//        {
//            h.Temparature += t;
//        }
//    }
//    class Cooler
//    {
//        public void Cool(HotHouse h, int t)
//        {
//            h.Temparature -= t;
//        }
//    }
//    class AllRight
//    {
//        public void Well(HotHouse h, int t)
//        {
//            h.Temparature += t;
//        }
//    }
//    delegate void TemparatureError(HotHouse house, int t);
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Heater heater = new Heater();
//            Cooler cooler = new Cooler();
//            AllRight ar = new AllRight();
//            HotHouse hotHouse = new HotHouse(25, 20, 30);
//            hotHouse.TooCold += heater.Warm;
//            hotHouse.TooHot += cooler.Cool;
//            hotHouse.Well += ar.Well;
//            while (true)
//            {
//                Random rnd = new Random();
//                hotHouse.Temparature += rnd.Next() % 5 - 2;
//                Thread.Sleep(300);
//            }
//        }
//    }
//}
