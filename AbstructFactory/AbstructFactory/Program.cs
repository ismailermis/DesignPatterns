// See https://aka.ms/new-console-template for more information
using AbstructFactory;

/****************************  1. sollution   **********************************
Console.WriteLine("Hello, World!");
IInternationalFactory factory = new EnglishFactory();
ILanguage language= factory.CreateLanguage();
ICapitalCity capitalCity= factory.CreateCapitalCity();

language.Greet();
Console.WriteLine("Total Population :" + capitalCity.GetPopulation());
Console.WriteLine("Top Atraction :" + string.Join(",",capitalCity.ListOfTopAttractions()));
/******************************************************************************/
/****************************  2. sollution   **********************************/

Country country = Country.TURK;

ILanguage language= InternationalProvider.CreateLanguage(country);
ICapitalCity capitalCity= InternationalProvider.CreateCapital(country);

Console.WriteLine(country);
Console.WriteLine(capitalCity.GetType().Name);

language.Greet();
Console.WriteLine("Total Population :" + capitalCity.GetPopulation());
Console.WriteLine("Top Atraction :" + string.Join(",",capitalCity.ListOfTopAttractions()));