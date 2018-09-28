﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    abstract class Flower : IPlant
    {

        public virtual void Grow()
        {
            Console.WriteLine("Fotosinteziruyu tak skozat'");
        }
        
        public string Color { get; set; }
        public string Name { get; set; }


        public Flower(string name = "", string color = "")
        {
            Name = name;
            Color = color;
        }

        public override string ToString()
        {
            return String.Format("Тип объекта: {0}\nИмя: {1}\nЦвет: {2}", base.ToString(), Name, Color);
        }

        public virtual void Bloom()
        {
            Console.WriteLine("Bloom");
        }
    }
}
