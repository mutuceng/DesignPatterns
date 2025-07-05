using State.Context;
using State.StateInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.ConcreteStates
{
    public class PinEnteredState : IATMState
    {
        private readonly AtmMachine _atmMachine;

        public PinEnteredState(AtmMachine atmMachine)
        {
            _atmMachine = atmMachine;
        }

        public void InsertCard()
        {
            Console.WriteLine("Zaten bir kart takılı.");
        }

        public void EjectCard()
        {
            Console.WriteLine("Kart çıkartıldı.");
            _atmMachine.SetState(_atmMachine.NoCardState);
        }

        public void EnterPin(int pinCode)
        {
            Console.WriteLine("PIN zaten girildi.");
        }

        public void RequestCash(int amount)
        {
            Console.WriteLine($"{amount} TL çekildi.");
            Console.WriteLine("Kart iade edildi.");
            _atmMachine.SetState(_atmMachine.NoCardState);
        }

        public void DepositCash(int amount)
        {
            Console.WriteLine($"{amount} TL yatırıldı.");
            Console.WriteLine("Kart iade edildi.");
            _atmMachine.SetState(_atmMachine.NoCardState);
        }
    }
}
