using Bridge.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Concrete___Implementors
{
    public class AirConditioner: IDevice
    {
        public void TurnOn() => Console.WriteLine("Klima açıldı.");
        public void TurnOff() => Console.WriteLine("Klima kapatıldı.");

        public void IncreaseTemperature() => Console.WriteLine("Sıcaklık artırıldı.");
        public void DecreaseTemperature() => Console.WriteLine("Sıcaklık azaltıldı.");
        public void SetMode(string mode) => Console.WriteLine($"{mode} modu aktif.");

    }
}
