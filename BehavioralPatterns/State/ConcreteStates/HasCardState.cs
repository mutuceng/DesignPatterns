using State.Context;
using State.StateInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.ConcreteStates
{
    public class HasCardState: IATMState
    {
        private readonly AtmMachine _atm;

        public HasCardState(AtmMachine atm)
        {
            _atm = atm;
        }

        public void InsertCard()
        {
            Console.WriteLine("Kart zaten ATM'de olduğu için kartı tekrar takamazsınız");
        }

        public void EjectCard()
        {
            Console.WriteLine("Kart iade edildi");
        }
        public void EnterPin(int pin)
        {
            if (pin != 1234)
            {
                Console.WriteLine("Yanlış pin numarası");
                return;
            }
            _atm.SetState(_atm.PinEnteredState);
            Console.WriteLine("Pin numarası doğru girildi");
        }
        public void DepositCash(int amount)
        {
            Console.WriteLine("Önce pin girmeniz gerekiyor");
        }

        public void RequestCash(int amount)
        {
            Console.WriteLine("Önce pin girmeniz gerekiyor");
        }
    }
}
