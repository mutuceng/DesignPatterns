using Builder.Builder;
using Builder.Director;

var gamingPC = new ComputerBuilder()
    .SetCPU("Intel Core i9")
    .SetRAM(32)
    .SetStorage("1TB SSD")
    .SetGPU("NVIDIA RTX 4080")
    .SetOperatingSystem("Windows 11")
    .EnableWiFi(true)
    .Build();

Console.WriteLine("Gaming PC:");
Console.WriteLine(gamingPC);

var officePC = new ComputerBuilder()
    .SetCPU("Intel Core i5")
    .SetRAM(16)
    .SetStorage("512GB SSD")
    .SetOperatingSystem("Windows 10")
    .EnableWiFi(false)
    .Build();

Console.WriteLine("\nOffice PC:");
Console.WriteLine(officePC);

var builder = new ComputerBuilder();
var director = new ComputerDirector(builder);

var gamingPCD = director.BuildGamingComputer();
Console.WriteLine("\nDirector Gaming PC:\n" + gamingPCD);

var officePCD = director.BuildOfficeComputer();
Console.WriteLine("\nDirector Office PC:\n" + officePCD);

var devLaptopD = director.BuildLinuxDeveloperLaptop();
Console.WriteLine("\nDirector Developer Laptop:\n" + devLaptopD);