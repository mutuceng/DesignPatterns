using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.StateInterface
{
    public interface IATMState
    {
        void InsertCard();
        void EjectCard();
        void EnterPin(int pin);
        void RequestCash(int amount);
        void DepositCash(int amount);
    }
}
