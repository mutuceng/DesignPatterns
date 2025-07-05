using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Target
{
    public interface IMedyaOynatabilen
    {
        void Oynat(string dosyaUzantisi, string dosyaAdi);
    }
}
