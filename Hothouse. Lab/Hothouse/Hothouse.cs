using System;
using System.Collections.Generic;
using System.Text;

namespace HotHouse_Task
{
    delegate void HotHouseDeleg(Hothouse house, int degrees);
    class Hothouse
    {
        public readonly int MnTemperature;
        public readonly int MxTemperature;

        public event HotHouseDeleg TooHot;
        public event HotHouseDeleg TooCold;
        public event HotHouseDeleg Well;

        private int temperature;
        public int Temperature
        {
            get => temperature;
            set
            {
                if (value > Temperature)
                {
                    Console.WriteLine($"All right. The temperature is {temperature} degrees.");
                    Well?.Invoke(this, 0);
                }
                temperature = value;
                //Console.WriteLine($"Now temperature : {Temperature}");
                if (value > MxTemperature)
                {
                    Console.WriteLine($"It is too hot, really! Now the temperature is {Temperature} degrees.");
                    TooHot?.Invoke(this, 5);
                    return;
                }
                else if (value < MnTemperature)
                {
                    Console.WriteLine($"It is some freezly(cold)! Now the temperature is {Temperature} degrees.");
                    TooCold?.Invoke(this, 5);
                    return;
                }
            }
        }
        public Hothouse(int min, int temperature, int max)
        {
            MxTemperature = max;
            MnTemperature = min;
            Temperature = temperature;
        }
    }
    class Heater
    {
        public void Heat(Hothouse hothouse, int degrees)
        {
            hothouse.Temperature += degrees;
        }
    }
    class Cooler
    {
        public void Cool(Hothouse hothouse, int degrees)
        {
            hothouse.Temperature -= degrees;
        }
    }
    class AllRight
    {
        public void Well(Hothouse hothouse, int degrees)
        {
            hothouse.Temperature += degrees;
        }
    }
}
