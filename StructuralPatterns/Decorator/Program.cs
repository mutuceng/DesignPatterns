using Decorator.ConcreteDecorators;
using Decorator.ConcreteProduct;
using Decorator.Interface;


IPizza pizza = new BasePizza();
Console.WriteLine($"Description: {pizza.GetDescription()}, Cost: ${pizza.GetCost():F2}");
// Çıktı: Description: Basic Pizza, Cost: $10.00

// Peynir ekle
pizza = new CheeseTopping(pizza);
Console.WriteLine($"Description: {pizza.GetDescription()}, Cost: ${pizza.GetCost():F2}");
// Çıktı: Description: Basic Pizza, Extra Cheese, Cost: $12.50

// Zeytin ekle
pizza = new OliveTopping(pizza);
Console.WriteLine($"Description: {pizza.GetDescription()}, Cost: ${pizza.GetCost():F2}");
// Çıktı: Description: Basic Pizza, Extra Cheese, Olives, Cost: $14.00

// Sucuk ekle
pizza = new SausageTopping(pizza);
Console.WriteLine($"Description: {pizza.GetDescription()}, Cost: ${pizza.GetCost():F2}");
// Çıktı: Description: Basic Pizza, Extra Cheese, Olives, Sausage, Cost: $17.00