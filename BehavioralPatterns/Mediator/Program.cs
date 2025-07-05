using Mediator.ConcreteMediators;

var director = new FontDialogDirector();
director.ShowDialog();

// Simülasyon: Kullanıcı farklı bir font seçerse
director.SelectFont("helvetica"); // Artık private list'e bu metotla erişiyoruz

Console.WriteLine("\n İkinci düz çağrı\n");
var director1 = new FontDialogDirector();
director1.ShowDialog(); // Aynı çıktı tekrarlanmaz

Console.WriteLine("\nSingelton Zamanı\n");
var singeltonDirector = SingeltonFontDialogDirector.Instance;
singeltonDirector.ShowDialog();
singeltonDirector.SelectFont("helvetica");

// Aynı instance'a tekrar erişim
var singeltonDirector2 = SingeltonFontDialogDirector.Instance;
singeltonDirector2.ShowDialog(); // Aynı çıktı tekrarlanmaz

// Görüldüğü gibi ilk halinde diaglodDirector her çağrıldıgında tekrar takrar oluşturuluyor bu sıkıntıydı ve bunu singelton method ile çözdük.