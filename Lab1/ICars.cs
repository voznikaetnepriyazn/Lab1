using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public interface ICars//вопрос - лучше делать карс абстракт классом или можно оставить интерфейсом
    {
        public double MaxUsefulWeight{ get; set; }

        public string FuelGrage{ get; set; }

        

    }
}
