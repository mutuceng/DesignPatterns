using State.ConcreteStates;
using State.StateInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Context
{
    public class AtmMachine
    {
        private IATMState _currentState;

        public IATMState NoCardState { get; }
        public IATMState HasCardState { get;  }
        public IATMState PinEnteredState { get; }

        public AtmMachine()
        {
            NoCardState = new NoCardState(this);
            HasCardState = new HasCardState(this);
            PinEnteredState = new PinEnteredState(this);

            _currentState = NoCardState; 
        }

        public void SetState(IATMState newState)
        {
            _currentState = newState;
        }


        public void InsertCard() => _currentState.InsertCard();
        public void EjectCard() => _currentState.EjectCard();
        public void EnterPin(int pin) => _currentState.EnterPin(pin);
        public void WithdrawCash(int amount) => _currentState.RequestCash(amount);
        public void DepositCash(int amount) => _currentState.DepositCash(amount);
    }
}
