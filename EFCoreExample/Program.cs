// See https://aka.ms/new-console-template for more information

using EFCoreExample;

Console.WriteLine("Hello, World!");

var context = new AppDbContext();
var country1 = new Country() {ID=994, CountryName="Azerbaijian", TimeZone= "GMT+4", Currency= "Azerbaijani manat", CountryPopulation=10};
var city1 = new City() { ID = 994012, CityName = "Baku", CityPopulation = 2, IsCapitalCity = true, Country=country1};
var location1 = new Location() { ID=1, LocationLatitude= "40°8'35.2'' N", LocationLongitude= "47°34'36.9'' E", Country=country1};
var language1 = new Language() { ID=1, SpokenLanguage = "Azerbaijani" };
country1.Languages.Add(language1);
language1.Countries.Add(country1);
context.Add(country1);
context.Add(city1);
context.Add(location1);
context.Add(language1);
context.Countries.First(x => x.ID == 994).CountryPopulation = 12;
context.Countries.Remove(country1);
context.SaveChanges();
