

using StrategyPattern.Context;
using StrategyPattern.Strategies;

NavigatorContext navigator = new NavigatorContext(new WalkingStrategy());
navigator.ExecuteStrategy("Home", "Work");

navigator = new NavigatorContext(new CycleStrategy());
navigator.ExecuteStrategy("Home", "Park");

navigator = new NavigatorContext(new PublicTransportStrategy());
navigator.ExecuteStrategy("Home", "City Center");

navigator = new NavigatorContext(new CarStrategy());
navigator.ExecuteStrategy("Home", "Airport");
