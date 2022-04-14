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

    }
}
