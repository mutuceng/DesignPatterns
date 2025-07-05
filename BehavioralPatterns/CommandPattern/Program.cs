// Alıcı (Document) oluşturuluyor
using CommandPattern.CommandInterface;
using CommandPattern.ConcreteCommands;
using CommandPattern.Invoker;
using CommandPattern.Receiver;

Document document = new Document();

// Başlangıç içeriği ekleniyor
document.addText("Merhaba Dünya!\n");

// Komutlar oluşturuluyor
ICommand kopyalaKomut = new CopyCommand(document, 0, 7); // "Merhaba" kopyalanacak
ICommand kesKomut = new CutCommand(document, 8,6); // "Dünya" kesilecek
ICommand yapistirKomut = new PasteCommand(document, 8); // Kopyalanan metin yapıştırılacak

// Arayüz komutları kuyruğa alıyor
TextEditor arayuz = new TextEditor();
arayuz.addCommand(kopyalaKomut);
arayuz.addCommand(kesKomut);
arayuz.addCommand(yapistirKomut);

// Komutlar çalıştırılıyor
arayuz.executeCommands();

// Son komut geri alınıyor (yapıştırma)
Console.WriteLine("\nGeri alma testi:");
arayuz.undoLastCommand();

// Bir komut daha geri alınıyor (kesme)
arayuz.undoLastCommand();
