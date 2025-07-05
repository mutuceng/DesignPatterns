using State.Context;

var atm = new AtmMachine();

atm.InsertCard();           // Kart takıldı.
atm.EnterPin(1234);         // PIN doğru.
atm.WithdrawCash(500);      // 500 TL çekildi, kart iade edildi.

Console.WriteLine();

atm.InsertCard();           // Kart takıldı.
atm.EnterPin(1111);         // PIN yanlış.
atm.WithdrawCash(300);      // Önce PIN girilmeli.
atm.EjectCard();            // Kart çıkartıldı.