﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Auto
{
    public void Anlassen()
    {
        Console.WriteLine("Auto anlassen");
        Motor motor = new Motor();
        motor.Starten();
    }
}

