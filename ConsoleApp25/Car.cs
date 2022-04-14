using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Car
    {
        public string Model;

        public bool StatusEngine;

        public int Rpm;

        public const int MaxRpm = 8000;

        public Car(string model)
        {
            Model = model;
            StatusEngine = false;
            Rpm = 0;
        }

        public void Start()
        {
            StatusEngine = true;
            Rpm = 800;
        }

        public void PowerOff()
        {
            StatusEngine = false;
            Rpm = 0;
        }

        public string GetInfoCar()
        {
            string info = $"Машина: {Model}. Статус двигателя: {StatusEngine}. Обороты: {Rpm}";
            return info;
        }

        public void IncreaseRpm(int rpm)
        {
            int temp = Rpm + rpm;
            if (temp >= MaxRpm)
            {
                return;
            }

            Rpm = Rpm + rpm;
        }

    }
}
