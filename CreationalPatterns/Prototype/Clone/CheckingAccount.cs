using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Clone
{
    public class CheckingAccount : Account // vadesiz
    {
        public double OverdraftLimit { get; set; }
        public double InterestRate { get; set; }
        public CheckingAccount(string iban, double balance, double credit, Customer? owner, bool openToWithdraw,
            bool openToPayment, bool openToTransfer, double overdraftLimit, double interestRate)
            : base(iban, balance, credit, owner, openToWithdraw, openToPayment, openToTransfer)
        {
            OverdraftLimit = overdraftLimit;
            InterestRate = interestRate;
        }

        public override Account Clone()
        {
            var clonedOwner = Owner != null ? new Customer(Owner.Name) : null;
            return new CheckingAccount(Iban, Balance, Credit, clonedOwner,
                OpenToWithdraw, OpenToPayment, OpenToTransfer, OverdraftLimit, InterestRate);
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Overdraft Limit: {OverdraftLimit}");
            Console.WriteLine($"Interest Rate: {InterestRate}");
        }
    }
}
