using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_Rado
{
    public class Radio
    {
        public string station;
        public bool isOn;
        public int percentageVolume;

        public Radio(string Station, bool IsOn, int PercentageVolume)
        {
            station = Station;
            isOn = IsOn;
            percentageVolume = PercentageVolume;
        }
        public void turnOn()
        {
            isOn = true;
        }
        public int TurnUp()
        {
            return percentageVolume += 5;
        }
    }
}
