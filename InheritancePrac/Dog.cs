﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePrac
{
    class Dog : Animal
    {
        public string Color { get; set; }
        public Dog() { Color = "하얀색"; }

        public void Bark() { Console.WriteLine("왈알 짓습니다."); }
    }
}
