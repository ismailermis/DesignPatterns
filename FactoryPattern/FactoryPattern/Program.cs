// See https://aka.ms/new-console-template for more information
using FactoryPattern;
using Newtonsoft.Json;
using System.Collections.Generic;

using static FactoryPattern.CreatorManager;

Console.WriteLine("--------------");
CreatorManager creatorManager = new CreatorManager();
TrafficLicenses trafficLicensesA = creatorManager.FactoryMethod(VehicleTypes.LicensesA);
TrafficLicenses trafficLicensesB = creatorManager.FactoryMethod(VehicleTypes.LicensesB);
TrafficLicenses trafficLicensesC = creatorManager.FactoryMethod(VehicleTypes.LicensesC);

trafficLicensesA.Run();
Console.WriteLine("-------------");
trafficLicensesB.Run();
Console.WriteLine("-------------");
trafficLicensesC.Run();
Console.WriteLine("-------------");


int homeScore=2;
int awayScore=1;
List<string> outcome = new List<string>();

Soccer soccer = new Soccer(); 
ISoccer home = soccer.Create(nameof(HomeWin)); 
ISoccer away = soccer.Create(nameof(AwayWin)); 
ISoccer draw = soccer.Create(nameof(Draw)); 
ISoccer btc = soccer.Create(nameof(BTC)); 

outcome.Add(home.Outcome(homeScore, awayScore)); 
outcome.Add(away.Outcome(homeScore, awayScore)); 
outcome.Add(btc.Outcome(homeScore, awayScore)); 
outcome.Add(draw.Outcome(homeScore, awayScore)); 

var result = JsonConvert.SerializeObject(outcome);
Console.WriteLine(result);