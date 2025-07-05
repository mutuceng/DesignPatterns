using AdapterPattern.Adaptee;
using AdapterPattern.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adapter
{
    public class MedyaAdapter : IMedyaOynatabilen
    {
        private readonly IModernMedyaOynatabilen _modernMedyaPlayer;

        public MedyaAdapter(string dosyaUzantisi)
        {
            dosyaUzantisi = dosyaUzantisi.ToLower(); // Standartlaştırma
            switch (dosyaUzantisi)
            {
                case "vlc":
                    _modernMedyaPlayer = new VLCPlayer();
                    break;
                case "mp4":
                    _modernMedyaPlayer = new MP4Player();
                    break;
                default:
                    throw new NotSupportedException($"Desteklenmeyen format: {dosyaUzantisi}");
            }
        }

        public void Oynat(string dosyaUzantisi, string dosyaAdi)
        {
            // Dosya uzantısını tekrar kontrol etmeye gerek yok, yapıcıda zaten doğru player seçildi
            if (_modernMedyaPlayer is VLCPlayer)
            {
                _modernMedyaPlayer.OynatVLC(dosyaAdi);
            }
            else if (_modernMedyaPlayer is MP4Player)
            {
                _modernMedyaPlayer.OynatMP4(dosyaAdi);
            }
        }
    }
}
