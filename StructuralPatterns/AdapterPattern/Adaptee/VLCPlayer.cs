using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adaptee
{
    public class VLCPlayer : IModernMedyaOynatabilen
    {
        public void OynatMP4(string dosyaAdi)
        {

        }

        public void OynatVLC(string dosyaAdi)
        {
            Console.WriteLine($"VLC Player ile {dosyaAdi} dosyası oynatılıyor.");
        }
    }
}
