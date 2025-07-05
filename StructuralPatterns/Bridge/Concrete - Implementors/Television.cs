using Bridge.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Concrete___Implementors
{
    public class Television: IDevice
    {
        public void TurnOn() => Console.WriteLine("TV açıldı.");
        public void TurnOff() => Console.WriteLine("TV kapatıldı.");

        public void SetChannel(int channel) => Console.WriteLine($"Kanal {channel}’e geçildi.");
        public void Mute() => Console.WriteLine("TV sessize alındı.");
    }
}
