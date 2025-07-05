using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Clone
{
    public class Customer
    {
        public string Name { get; set; }
        public Customer(string name)
        {
            Name = name;
        }
    }
    public abstract class Account
    {
        public string Iban { get; set; }
        public double Balance { get; set; }
        public double Credit { get; set; }
        public Customer? Owner { get; set; } // Nullable
        public bool OpenToWithdraw { get; set; }
        public bool OpenToPayment { get; set; }
        public bool OpenToTransfer { get; set; }

        public Account(string iban, double balance, double credit, Customer? owner,
                          bool openToWithdraw, bool openToPayment, bool openToTransfer)
        {
            Iban = iban;
            Balance = balance;
            Credit = credit;
            Owner = owner;
            OpenToWithdraw = openToWithdraw;
            OpenToPayment = openToPayment;
            OpenToTransfer = openToTransfer;
        }

        public abstract Account Clone();

        // Abstratt sınıfın içerisinde return eden bişi olamaz o yüzden virtual yerine abstract


        public virtual void Display()
        // buradaki virtual'ın sebebi de fonksiyonu override edebilmek
        {
            Console.WriteLine($"Account IBAN: {Iban}");
            Console.WriteLine($"Balance: {Balance}");
            Console.WriteLine($"Credit: {Credit}");
            Console.WriteLine($"Owner: {(Owner != null ? Owner.Name : "No Owner")}");
            Console.WriteLine($"Open to Withdraw: {OpenToWithdraw}");
            Console.WriteLine($"Open to Payment: {OpenToPayment}");
            Console.WriteLine($"Open to Transfer: {OpenToTransfer}");
            Console.WriteLine();

        }
    }
}
