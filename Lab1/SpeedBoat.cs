﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class SpeedBoat: Technics, ILandMove
    {
        public double EngineCapacity{ get; set; }

        public bool Cabin {  get; set; }
    }
}
