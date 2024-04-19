using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class PassengerCar: Technics, ICars, ILandMove
    {
        
        public double EngineCapacity { get; set; }

        public double MaxUsefulWeight { get; set; }

        public string FuelGrage { get; set; }

        public string BodyType { get; set; }
        
    }
}
