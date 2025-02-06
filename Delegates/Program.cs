//ProcessString processString1 = TrimTo5Letters;
//ProcessString processString2 = ToUpper;
//Console.WriteLine(processString1("Hellooooooooo"));
//Console.WriteLine(processString2("Hellooooooooo"));
//string TrimTo5Letters(string input)
//{
//	return input.Substring(0, 5);
//}

//string ToUpper(string input)
//{
//	return input.ToUpper();
//}

//delegate string ProcessString(string input);


Print print1 = text => Console.WriteLine(text.ToUpper());
Print print2 = text => Console.WriteLine(text.ToLower());
Print print4 = text => Console.WriteLine(text.Substring(0, 3));
Print multicast = print1 + print2;
multicast += print4;
multicast("Crocodile");
Console.ReadKey();

delegate void Print(string input);