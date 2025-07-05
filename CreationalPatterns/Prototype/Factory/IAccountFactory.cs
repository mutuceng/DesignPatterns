using Prototype.Clone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Factory
{
    public interface IAccountFactory
    {
        Account CreateNormalAccount(Customer owner, double balance);
        Account CreateNegativeAccount(Customer owner, double balance);
        Account CreateFrozenAccount(Customer owner, double balance);
    }
}
