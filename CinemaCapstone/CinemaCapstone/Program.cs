// See https://aka.ms/new-console-template for more information
using Capstone;
using Capstone.Menus;

Console.WriteLine("Hello, Capstone!");

/*
 * This program is provided as a starting point to the capstone project.
 * It shows an example of how you can create business objects (in this case an instance of ExampleSumObject and
 * interact with them using the ConsoleMenu and MenuItem objects.
 * 
 * You do not have to use this menuing system for the capstone project if you don't want to, but if you do this 
 * might provide a good starting point.
 * 
 */

ExampleSumObject mySum = new ExampleSumObject();

ExampleConsoleMenu myMenu = new ExampleConsoleMenu(mySum);
myMenu.Select();

string[] options = { "option 1", "option 2", "option 3" };

int selection = ConsoleHelpers.GetSelectionFromMenu(options, "Please select an option");
Console.WriteLine($"{options[selection]} was selected.");

string path = $@"{Environment.CurrentDirectory}\Resources";
string[] resourceFiles = Directory.GetFiles(path, "*.txt");

selection = ConsoleHelpers.GetSelectionFromMenu(resourceFiles, "Select a file to load");

string[] fileLines = File.ReadAllLines(resourceFiles[selection]);

foreach(string line in fileLines)
{
	Console.WriteLine(line);
}