﻿// See https://aka.ms/new-console-template for more information

using Names_SingleResponsibilityPrinciple.DataAccess;

var names = new Names();
var path = new NamesFilePathBuilder().BuildFilePath();
var stringsTextualRepository = new StringsTextualRepository();
var namesFormatter = new NamesFormatter();


if (File.Exists(path))
{
    Console.WriteLine("Names file already exists. Loading names.");
    var stringsFromFile = stringsTextualRepository.Read(path);
    names.AddNames(stringsFromFile);
}
else
{
    Console.WriteLine("Names file does not yet exist.");

    //let's imagine they are given by the user
    names.AddName("John");
    names.AddName("not a valid name");
    names.AddName("Claire");
    names.AddName("123 definitely not a valid name");

    Console.WriteLine("Saving names to a file.");
    stringsTextualRepository.Write(path, names.All);
}

Console.WriteLine(namesFormatter.Format(names.All));
Console.ReadKey();
