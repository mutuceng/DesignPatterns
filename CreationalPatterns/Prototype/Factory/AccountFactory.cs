using Prototype.Clone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Factory
{
    public class AccountFactory : IAccountFactory
    {
        public Account CreateFrozenAccount(Customer owner, double balance)
        {
            var account = AccountPrototypes.FrozenPrototype.Clone();
            account.Owner = owner;
            account.Balance = balance;
            return account;
        }

        public Account CreateNegativeAccount(Customer owner, double balance)
        {
            var account = AccountPrototypes.NegativePrototype.Clone();
            account.Owner = owner;
            account.Balance = balance;
            return account;
        }

        public Account CreateNormalAccount(Customer owner, double balance)
        {
            var account = AccountPrototypes.NormalPrototype.Clone();
            account.Owner = owner; // Default owner is null
            account.Balance = balance; // Default balance is 0
            return account;
        }

        public Account CreateSavingsAccount(Customer owner, double balance, double interestRate)
        {
            var account = AccountPrototypes.SavingsPrototype.Clone();
            account.Owner = owner;
            account.Balance = balance;
            if (account is SavingsAccount savings)
            {
                savings.InterestRate = interestRate;
                savings.Duration = 12; // Default duration, can be adjusted as needed
            }
            
            return account;
        }


        public Account CreateCheckingAccount(Customer owner, double balance, double interestRate, double overdraftLimit)
        {
            var account = AccountPrototypes.NormalPrototype.Clone();
            account.Owner = owner;
            account.Balance = balance;
            if (account is CheckingAccount checks)
            {
                checks.InterestRate = interestRate;
                checks.OverdraftLimit = overdraftLimit; 
            }
            return account;
        }


        private static class AccountPrototypes
        {
            public static readonly Account NormalPrototype =
                new CheckingAccount("TR0000000001", 0, 1000, null, true, true, true,10000,5);

            public static readonly Account NegativePrototype =
                new CheckingAccount("TR0000000001", 0, 1000, null, true, true, false,0,0);

            public static readonly Account FrozenPrototype =
                new CheckingAccount("TR0000000001", -1000, 1000, null, false, false, false,0,0);

            public static readonly Account SavingsPrototype =
                new SavingsAccount("TR0000000001", 0, 1000, null, true, true, true, 48,12);
        }
    }
}
