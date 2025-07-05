using Bridge.Abstraction;
using Bridge.Concrete___Implementors;
using Bridge.Refined_Abstractions;



var tv = new Television();
var tvRemote = new TVController(tv);

tvRemote.TogglePower();       // TV açıldı
tvRemote.ChangeChannel(7);    // Kanal 7’ye geçildi
tvRemote.Mute();              // TV sessize alındı

var ac = new AirConditioner();
var acRemote = new AirConditionerController(ac);

acRemote.TogglePower();       // Klima açıldı
acRemote.IncreaseTemp();      // Sıcaklık artırıldı
acRemote.SetCoolingMode();    // Cooling modu aktif
acRemote.DecreaseTemp();      // Sıcaklık azaltıldı