using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adaptee
{
    public interface IModernMedyaOynatabilen
    {
        void OynatVLC(string dosyaAdi);
        void OynatMP4(string dosyaAdi);

    }
}
