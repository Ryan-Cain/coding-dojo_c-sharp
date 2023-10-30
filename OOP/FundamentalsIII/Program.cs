// Given a List of strings, iterate through the List and print out all the values.
static void PrintList(List<string> MyList)
{
    foreach (string name in MyList)
    {
        Console.WriteLine(name);
    }
}
List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};
PrintList(TestStringList);


// // Given a List of integers, calculate and print the sum of the values.
static void SumOfNumbers(List<int> IntList)
{
    int total = 0;
    foreach (int num in IntList)
    {
        total += num;
    }
    Console.WriteLine(total);
}
List<int> TestIntList = new List<int>() {2,7,12,9,3};
// You should get back 33 in this example
SumOfNumbers(TestIntList);


// Given a List of integers, find and return the largest value in the List.
static int FindMax(List<int> IntList)
{
    int highest = IntList[0];
    foreach (int num in IntList)
    {
        if (num > highest)
        {
            highest = num;
        }
    }
    return highest;
}
List<int> TestIntList2 = new List<int>() {-9,12,10,3,17,5};
// // You should get back 17 in this example
Console.WriteLine(FindMax(TestIntList2));


// // Given a List of integers, return the List with all the values squared.
static List<int> SquareValues(List<int> IntList)
{
    for (int i =0; i < IntList.Count; i++)
    {
        IntList[i] = IntList[i] * IntList[i];
    }
    return IntList;
}
List<int> TestIntList3 = new List<int>() {1,2,3,4,5};
// // You should get back [1,4,9,16,25], think about how you will show that this worked
List<int> squaredList = SquareValues(TestIntList3);
foreach (int square in squaredList)
{
    Console.WriteLine(square);
}


// Given an array of integers, return the array with all values below 0 replaced with 0.
static int[] NonNegatives(int[] IntArray)
{
    for (int i = 0; i < IntArray.Length; i++)
    {
        if (IntArray[i] < 0)
        {
            IntArray[i] = 0; 
        }
    }
    return IntArray;
}
int[] TestIntArray = new int[] {-1,2,3,-4,5};
// // You should get back [0,2,3,0,5], think about how you will show that this worked
NonNegatives(TestIntArray);


// // Given a dictionary, print the contents of the said dictionary.
static void PrintDictionary(Dictionary<string,string> MyDictionary)
{
    foreach (KeyValuePair<string, string> name in MyDictionary)
    {
        Console.WriteLine($"Superhero {name.Key}: {name.Value}");
    }
}
Dictionary<string,string> TestDict = new Dictionary<string,string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
// PrintDictionary(TestDict);


// Given a search term, return true or false whether the given term is a key in a dictionary. (Hint: figuring this one out may require some research!)
static bool FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
{
    bool keyInDict = false;
    foreach (KeyValuePair<string, string> name in MyDictionary)
    {
        if (name.Key == SearchTerm)
        {
            keyInDict = true;
        }
    }
    return keyInDict;
}
// Use the TestDict from the earlier example or make your own
// This should print true
Console.WriteLine(FindKey(TestDict, "RealName"));
// This should print false
Console.WriteLine(FindKey(TestDict, "Name"));


// Given a List of names and a List of integers, create a dictionary where the key is a name from the List of 
// names and the value is a number from the List of numbers. Assume that the two Lists will be of the same length.
//  Don't forget to print your results to make sure it worked.
// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//	"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 
static Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    Dictionary<string, int> people = new();
    for (int i = 0; i < Names.Count; i++)
    {
        people.Add(Names[i], Numbers[i]);
    }
    return people;
}
// We've shown several examples of how to set your tests up properly, it's your turn to set it up!
// Your test code here
List<string> TestStringList4 = new List<string>() {"John", "Wick", "Mario", "Luigi"};
List<int> TestIntList4 = new List<int>() {34,45,28,26};

Dictionary<string, int> NewDict = GenerateDictionary(TestStringList4, TestIntList4);
foreach (KeyValuePair<string, int> name in NewDict)
    {
        Console.WriteLine($"Name: {name.Key}, Number: {name.Value}");
    }
