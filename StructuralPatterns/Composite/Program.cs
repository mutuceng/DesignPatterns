using Composite.Component;
using Composite.Composite;
using Composite.Leafs;
using Directory = Composite.Composite.Directory;
using File = Composite.Leafs.File;

var root = new Directory("Root");
var file1 = new File("File1.txt");
var file2 = new File("File2.txt");
var subDir = new Directory("SubDir");
var subDir2 = new Directory("SubDire");
var file3 = new File("File3.txt");

root.Add(file1);
root.Add(file2);
subDir.Add(file3);
root.Add(subDir);
subDir2.Add(file1);
root.Add(subDir2);

root.Display();

Console.WriteLine("\n-----------------------------------------------------\n");

var mainCanvas = new Canvas("Main");
var subCanvas1 = new Canvas("SubCanvas1");
var subCanvas2 = new Canvas("SubCanvas2");

var circle = new Circle("RedCircle");
var square = new Square("BlueSquare");
var triangle = new Triangle("GreenTriangle");

subCanvas1.Add(circle);
subCanvas1.Add(square);

subCanvas2.Add(triangle);

mainCanvas.Add(subCanvas1);
mainCanvas.Add(subCanvas2);
mainCanvas.Add(new Square("YellowSquare"));

mainCanvas.Draw();