using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Clone
{
    public class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        public int Duration { get; set; } // Assuming duration is in months or years, depending on your context

        public SavingsAccount(string iban, double balance, double credit, Customer? owner, bool openToWithdraw, 
            bool openToPayment, bool openToTransfer, double interestRate, int duration): base(iban, balance, credit, owner, openToWithdraw, openToPayment, openToTransfer)
        {
            InterestRate = interestRate;
            Duration = duration;
        }
        public override Account Clone()
        {
            var clonedOwner = Owner != null ? new Customer(Owner.Name) : null;
            return new SavingsAccount(Iban, Balance, Credit, clonedOwner, 
                OpenToWithdraw, OpenToPayment, OpenToTransfer, InterestRate, Duration);
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Interest Rate: {InterestRate}");
            Console.WriteLine($"Duration: {Duration}");
        }
    }
}
