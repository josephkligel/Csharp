var countryToCurrencyMapping = new Dictionary<string, string>()
{
	["USA"] = "USD",
	["India"] = "INR",
	["Spain"] = "EUR"
};
//countryToCurrencyMapping.Add("USA", "USD");
//countryToCurrencyMapping.Add("India", "INR");
//countryToCurrencyMapping.Add("Spain", "EUR");

if (countryToCurrencyMapping.ContainsKey("Spain"))
{
	Console.WriteLine($"Currency in Spain is {countryToCurrencyMapping["Spain"]}");
}

countryToCurrencyMapping["Poland"] = "PLN";

foreach(var countryCurrencyPair in countryToCurrencyMapping)
{
	Console.WriteLine(
		$"Country: {countryCurrencyPair.Key}, " +
		$"currency: {countryCurrencyPair.Value}"
		);
}
{
	Console.WriteLine();
}

Console.ReadKey();