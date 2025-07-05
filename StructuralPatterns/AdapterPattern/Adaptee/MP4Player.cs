using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adaptee
{
    public class MP4Player : IModernMedyaOynatabilen
    {
        public void OynatMP4(string dosyaAdi)
        {
            Console.WriteLine($"MP4 Player ile {dosyaAdi} dosyası oynatılıyor.");
        }
        public void OynatVLC(string dosyaAdi)
        {
        }
    }
}
