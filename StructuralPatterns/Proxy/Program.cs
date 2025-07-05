using Proxy.zNetwork_Example;
using Proxy.CommonInterface;
using Proxy.RealObject;
using Proxy.ProxyObject;

Console.WriteLine("=== Network Proxy Örneği ===");
var proxy = new ProxyServer();

try
{
    proxy.ftp("172.16.1.10", "10.0.0.5");
}
catch (YasakKardesimException ex)
{
    Console.WriteLine("Hata: " + ex.Message);
}

try
{
    proxy.ftp("172.16.1.10", "192.168.1.1");
}
catch (YasakKardesimException ex)
{
    Console.WriteLine("Hata: " + ex.Message);
}

try
{
    proxy.telnet("172.16.1.10", "192.168.1.1");
}
catch (YasakKardesimException ex)
{
    Console.WriteLine("Hata: " + ex.Message);
}

try
{
    proxy.telnet("172.16.1.10", "10.0.0.5");
}
catch (YasakKardesimException ex)
{
    Console.WriteLine("Hata: " + ex.Message);
}

Console.WriteLine("\n=== Başbakan Proxy Örneği ===");
Basbakan gercekBasbakan = new GercekBasbakan();
Basbakan vekil = new VekilBasbakan(gercekBasbakan);

vekil.dertDinle("Ekonomi çok kötü");
vekil.dertDinle("Bana iş bulur musunuz?");
vekil.isBul("Kuzenim");

Console.WriteLine("\n=== YouTube Proxy Örneği ===");
IThirdPartyYouTubeLib realYouTube = new ThirdPartyYouTubeClass();
IThirdPartyYouTubeLib cachedYouTube = new CachedYouTubeClass(realYouTube);


cachedYouTube.getVideoInfo("video1");
cachedYouTube.downloadVideo("video1");

// Aynı işlemler tekrar çağrıldığında cache devreye girer
cachedYouTube.getVideoInfo("video1");
cachedYouTube.downloadVideo("video1");
