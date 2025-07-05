using AdapterPattern.Adapter;
using AdapterPattern.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Client
{
    public class MedyaPlayer : IMedyaOynatabilen
    {
        MedyaAdapter MedyaAdapter;
        //public void Oynat(string dosyaUzantisi, string dosyaAdi)
        //{
        //    // ilk etapta sadece mp3 formatını destekliyoruz
        //    if (dosyaUzantisi == "mp3")
        //    {
        //        Console.WriteLine("MP3 formatında oynatılıyor: " + dosyaAdi);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Bu format desteklenmiyor: " + dosyaUzantisi);
        //    }
        //}

        public void Oynat(string dosyaUzantisi, string dosyaAdi)
        {
            dosyaUzantisi = dosyaUzantisi.ToLower();
            if (dosyaUzantisi.Equals("mp3"))
            {
                Console.WriteLine("MP3 formatında oynatılıyor: " + dosyaAdi);
            }
            else if (dosyaUzantisi.Equals("mp4") || dosyaUzantisi.Equals("vlc"))
            {
                MedyaAdapter = new MedyaAdapter(dosyaUzantisi);
                MedyaAdapter.Oynat(dosyaUzantisi, dosyaAdi);
            }
            else
            {
                Console.WriteLine("Bu format desteklenmiyor: " + dosyaUzantisi);
            }
        }
    }
}
