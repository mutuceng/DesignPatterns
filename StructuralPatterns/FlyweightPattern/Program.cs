using FlyweightPattern.Extrinsic;
using FlyweightPattern.Flyweight_Factory;
using System.Net.Http.Headers;

var factory = new SoldierFactory();

// 5 farklı asker tipi: ortak kullanılır
var knightType = factory.GetSoldierType("Şövalye", "heavy_knight.model", "walk_shield.anim", "8");
var archerType = factory.GetSoldierType("Archer", "archer.model", "bow_arrow.anim","40");
var cavalaryType = factory.GetSoldierType("Cavalary", "cavalary.model", "horse_riding.anim", "20");

// Stark hanesi için bir şövalye
var starkKnight = new Soldier(
    x: 10, y: 20,
    armor: "kürklü demir zırh",
    weapon: "balta",
    emblem: "kurt simgeli kask",
    climate: "soğuk",
    house: "Stark",
    type: knightType
);

// Martell hanesi için bir şövalye
var martellKnight = new Soldier(
    x: 30, y: 40,
    armor: "hafif tunik",
    weapon: "mızrak",
    emblem: "güneş-mızrak amblemli kask",
    climate: "sıcak",
    house: "Martell",
    type: knightType
);

var starkArcher = new Soldier(
    x: 15, y: 25,
    armor: "hafif deri zırh",
    weapon: "uzun yay",
    emblem: "kurt simgeli kask",
    climate: "soğuk",
    house: "Stark",
    type: archerType
);

starkKnight.Draw();
martellKnight.Draw();
starkArcher.Draw();
