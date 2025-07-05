using State.Context;
using State.StateInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.ConcreteStates
{
    public class NoCardState : IATMState
    {
        private readonly AtmMachine _atm;

        public NoCardState(AtmMachine atm)
        {
            _atm = atm;
        }

        public void InsertCard()
        {
            Console.WriteLine("Kart başarıyla takıldı.");
            _atm.SetState(_atm.HasCardState);
        }

        public void EjectCard()
        {
            Console.WriteLine("ATM makinesinde kart olmadığı için çıkarılamaz.");
        }
        public void EnterPin(int pin)
        {
            Console.WriteLine("ATM makinesinde kart olmadığı için PIN girilemez.");
        }
        public void DepositCash(int amount)
        {
            Console.WriteLine("ATM makinesinde kart olmadığı için para yatırılamaz.");
        }

        public void RequestCash(int amount)
        {
            Console.WriteLine("ATM makinesinde kart olmadığı için para çekilemez.");
        }
    }
}
