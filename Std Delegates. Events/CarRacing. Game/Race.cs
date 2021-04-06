using System;
using System.Linq;
using System.Threading;
using System.Collections.Generic;

namespace CarRacing._Game
{
    delegate void Finish();
    class Race
    {
        public event Finish finish;
        private List<Car> cars;
        public Race()
        {
            cars = new List<Car>();
        }
        public void AddCar(Car car)
        {
            cars.Add(car);
        }
        public void Move()
        {
            int i = 0;
            while (true)
            {
                if (i == cars.Count)
                {
                    i = 0;
                }
                cars[i].distance += cars[i].Speed;
                cars[i].Drive();
                Console.WriteLine($"Current distance of ({cars[i].GetType().Name}) is {cars[i].distance}.\n");
                if (cars[i].distance >= 100)
                {
                    if (i == cars.Count + 1)
                    {
                        --i;
                    }
                    finish = cars[i].FinishLine;
                    finish?.Invoke();
                    return;
                }
                ++i;
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
