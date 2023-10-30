// Create an integer array with the values 0 through 9 inside.
int[] intArr = {0,1,2,3,4,5,6,7,8,9};
// Create a string array with the names "Tim", "Martin", "Nikki", and "Sara".
string[] stringArr = {"Tim","Martin", "Nikki", "Sara"};
// Create a boolean array of length 10. Then fill it with alternating true/false values, starting with true. (Tip: do this using logic! Do not hard-code the values in!)
bool[] boolArr = new bool[10];
for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0) 
    {
        boolArr[i] = true;
    } 
    else 
    {
        boolArr[i] = false;
    }
}
// Create a string List of ice cream flavors that holds at least 5 different flavors. (Feel free to add more than 5!)
List<string> iceCream = new List<string>
{
    "Rocky Road", "Vanilla", "Chocolate", "Cookies and Cream", "Pistachio"
};

// Output the length of the List after you added the flavors.
Console.WriteLine(iceCream.Count);
// Output the third flavor in the List.
Console.WriteLine(iceCream[2]);
// Now remove the third flavor using its index location.
iceCream.RemoveAt(2);
// Output the length of the List again. It should now be one fewer.
Console.WriteLine(iceCream.Count);

// Create a dictionary that will store string keys and string values.
Dictionary<string, string> names = new Dictionary<string, string>();
// Add key/value pairs to the dictionary where:
// Each key is a name from your names array (this can be done by hand or using logic)
// Each value is a randomly selected flavor from your flavors List (remember Random from earlier?)
Random randNum = new Random();
foreach (string name in stringArr)
{
    names.Add(name, iceCream[randNum.Next(0,4)]);
}
// Loop through the dictionary and print out each user's name and their associated ice cream flavor.
foreach(KeyValuePair<string, string> name in names)
{
    Console.WriteLine($"{name.Key}'s favorite icecream is {name.Value}");
}