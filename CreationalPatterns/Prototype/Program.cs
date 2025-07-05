// Normal hesap
using Prototype.Clone;
using Prototype.Factory;


var factory = new AccountFactory();

// Normal hesap (vadesiz)
var normalAccount = factory.CreateNormalAccount(new Customer("Nuri"),2000);
normalAccount.Iban = "TR123456789";
Console.WriteLine("Normal Hesap:");
normalAccount.Display();

// Negatif hesap
var negativeAccount = factory.CreateNegativeAccount(new Customer("Mustafa"), -750);
negativeAccount.Iban = "TR987654321";
Console.WriteLine("\nNegatif Hesap:");
negativeAccount.Display();

// Dondurulmuş hesap
var frozenAccount = factory.CreateFrozenAccount(new Customer("Şükran"), -1000);
frozenAccount.Iban = "TR456789123";
Console.WriteLine("\nDondurulmuş Hesap:");
frozenAccount.Display();

// Vadeli hesap
var savingsAccount = factory.CreateSavingsAccount(new Customer("Ayşe"), 5000, 2.0);
savingsAccount.Iban = "TR789123456";
Console.WriteLine("\nVadeli Hesap:");
savingsAccount.Display();
