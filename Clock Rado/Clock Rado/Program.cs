using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_Rado
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio kissFM = new Radio("103.7", false, 100);
            Radio v100 = new Radio("100.7", false, 100);
            v100.station = "Jams";
            kissFM.turnOn();
            kissFM.TurnUp();
        }
    }
}
