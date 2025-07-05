using Memento;
using Memento.CareTaker;
using Memento.Originator;

Canvas canvas = new Canvas();
History history = new History();

// İlk şekli ekle ve kaydet
canvas.AddShape(new Shape(50, 50, "Red", "Square"));
history.Save(canvas.Save());

// İkinci şekli ekle ve kaydet
canvas.AddShape(new Shape(200, 150, "Blue", "Circle"));
history.Save(canvas.Save());

// Mevcut durumu yazdır
canvas.PrintShapes();

// İlk geri alma
Console.WriteLine("\nGeri alma yapılıyor...");
var memento = history.Undo();
if (memento != null)
{
    canvas.Restore(memento);
    canvas.PrintShapes();
}

// İkinci geri alma
Console.WriteLine("\nBir kez daha geri alma yapılıyor...");
memento = history.Undo();
if (memento != null)
{
    canvas.Restore(memento);
    canvas.PrintShapes();
}