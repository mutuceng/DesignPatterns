using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.CareTaker
{
    public class History
    {
        private Stack<Memento.Memento> _mementos = new Stack<Memento.Memento>();
    
        public void Save(Memento.Memento memento)
        {
            _mementos.Push(memento);
            Console.WriteLine("Memento kaydedildi.");
        }

        public Memento.Memento Undo()
        {
            if (_mementos.Count <= 1)
            {
                Console.WriteLine("Geri alma işlemi yapılamaz, geçmişte başka durum yok.");
                return null;
            }
            // Mevcut durumu atla
            _mementos.Pop();
            // Mecvut durumun öncesine gitmek için pop'tan sonra tekrar peek yapıyoruz.
            // Bu sayede durumu stackten çıkarmadan önceki state'e erişebiliyoruz.
            var memento = _mementos.Peek();
            Console.WriteLine("Memento geri alındı.");
            return memento;
        }


    }
}
