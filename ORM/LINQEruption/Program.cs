List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!

// Use LINQ to find the first eruption that is in Chile and print the result.
Eruption firstInChile = eruptions.First(p => p.Location == "Chile");

// // Find the first eruption from the "Hawaiian Is" location and print it. If none is found, print "No Hawaiian Is Eruption found."
Eruption? firstInHawaiian = eruptions.FirstOrDefault(p => p.Location == "Hawaiian Is");
// if (firstInHawaiian != null)
// {
//     Console.WriteLine(firstInHawaiian);
// }
// else
// {
//     Console.WriteLine("No Hawaiian Is Eruption found.");
// }

// Find the first eruption from the "Greenland" location and print it. If none is found, print "No Greenland Eruption found."
Eruption? firstInGreenland = eruptions.FirstOrDefault(p => p.Location == "Greenland");
// if (firstInGreenland != null)
// {
//     Console.WriteLine(firstInGreenland);
// }
// else
// {
//     Console.WriteLine("No Greenland Eruption found.");
// }

// Find the first eruption that is after the year 1900 AND in "New Zealand", then print it.
Eruption? firstNZafter1900 = eruptions.Where(y => y.Year > 1900).FirstOrDefault(l => l.Location == "New Zealand");
// Console.WriteLine(firstNZafter1900);

// Find all eruptions where the volcano's elevation is over 2000m and print them.
IEnumerable<Eruption> eruptionsOver2000m = eruptions.Where(e => e.ElevationInMeters > 2000);
// PrintEach(eruptionsOver2000m, "these are the eruptions over 2000m");

// Find all eruptions where the volcano's name starts with "L" and print them. Also print the number of eruptions found.
IEnumerable<Eruption> eruptionsStartWithL = eruptions.Where(n => n.Volcano[0] == 'L');
// Console.WriteLine(eruptionsStartWithL.Count());

// Find the highest elevation, and print only that integer (Hint: Look up how to use LINQ to find the max!)
int? highestEruptionElev = eruptions.Max(e => e.ElevationInMeters);
// Console.WriteLine(highestEruptionElev);


// Use the highest elevation variable to find and print the name of the Volcano with that elevation.
string? highestVolcano = eruptions.Where(v => v.ElevationInMeters == highestEruptionElev).Select(v => v.Volcano).FirstOrDefault();
// Console.WriteLine(highestVolcano);


// Print all Volcano names alphabetically.
IEnumerable<string> volcanoNames = eruptions.OrderBy(n => n.Volcano).Select(n => n.Volcano);
// PrintEachString(volcanoNames, "Names of all volcanos in alphebetical order");

// Print the sum of all the elevations of the volcanoes combined.
int? sumOfAllVolcanoElev = eruptions.Sum(v => v.ElevationInMeters);
// Console.WriteLine(sumOfAllVolcanoElev);

// Print whether any volcanoes erupted in the year 2000 (Hint: look up the Any query)
bool eruptedIn2000 = eruptions.Any(v => v.Year == 2000);
// Console.WriteLine(eruptedIn2000);

// Find all stratovolcanoes and print just the first three (Hint: look up Take)
IEnumerable<Eruption> firstThreeStrato = eruptions.Where(v => v.Type == "Stratovolcano").Take(3);
// PrintEach(firstThreeStrato, "First three Stratovolcanos");

// Print all the eruptions that happened before the year 1000 AD alphabetically according to Volcano name.
IEnumerable<Eruption> eruptedBefore1000 = eruptions.Where(v => v.Year < 1000).OrderBy(v => v.Volcano);
// PrintEach(eruptedBefore1000, "Volcanos erupted before 1000 AD");

// Redo the last query, but this time use LINQ to only select the volcano's name so that only the names are printed.
IEnumerable<string> eruptedBefore1000Names = eruptions.Where(v => v.Year < 1000).OrderBy(v => v.Volcano).Select(v => v.Volcano);
// PrintEachString(eruptedBefore1000Names);

// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (Eruption item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
static void PrintEachString(IEnumerable<string> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (string item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
