Console.WriteLine("Iterate and print values");

static void PrintList(List<string> MyList)
{
    foreach (string name in MyList)
    {
        Console.WriteLine(name);
    }
}

List<string> TestStringList = new List<string>() { "Harry", "Steve", "Carla", "Jeanne" };

PrintList(TestStringList);



Console.WriteLine("Print Sum");

static void SumOfNumbers(List<int> IntList)
{
    int sum = 0;
    foreach (int num in IntList)
    {
        sum += num;
    }
    Console.WriteLine(sum);
}

List<int> TestIntList = new List<int>() { 2, 7, 12, 9, 3 };

SumOfNumbers(TestIntList);



Console.WriteLine("Find Max");

static int FindMax(List<int> IntList)
{
    int max = IntList[0];
    foreach (int num in IntList)
    {
        if (max < num)
        {
            max = num;
        }
    }
    return max;
}

List<int> TestIntList2 = new List<int> { -9, 12, 10, 3, 17, 5 };

Console.WriteLine(FindMax(TestIntList2));



Console.WriteLine("Square the Values");

static List<int> SquareValues(List<int> IntList)
{
    for (int i = 0; i < IntList.Count; i++)
    {
        IntList[i] = IntList[i] * IntList[i];
    }
    return IntList;
}

List<int> TestIntList3 = new List<int>() { 1, 2, 3, 4, 5 };

List<int> SquaredValues = SquareValues(TestIntList3);

Console.WriteLine(string.Join(",", SquaredValues));



Console.WriteLine("Replace Negative Numbers with 0");

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

int[] TestIntArray = new int[] { -1, 2, 3, -4, 5 };

int[] NonNegValues = NonNegatives(TestIntArray);

Console.WriteLine(string.Join(",", NonNegValues));



Console.WriteLine("Print Dictionary");

static void PrintDictionary(Dictionary<string, string> MyDictionary)
{
    foreach (KeyValuePair<string, string> item in MyDictionary)
    {
        Console.WriteLine($"{item.Key} - {item.Value}");
    }
}

Dictionary<string, string> TestDict = new Dictionary<string, string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and Intelligence");

PrintDictionary(TestDict);



Console.WriteLine("Find Key");

static bool FindKey(Dictionary<string, string> MyDictionary, string SearchTerm)
{
    foreach (KeyValuePair<string, string> item in MyDictionary)
    {
        if (item.Key == SearchTerm)
        {
            return true;
        }
    }
    return false;
}

Console.WriteLine(FindKey(TestDict, "RealName"));
Console.WriteLine(FindKey(TestDict, "Name"));



Console.WriteLine("Generate a Dictionary");

static Dictionary<string, int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    Dictionary<string, int> Results = new Dictionary<string, int>();
    for (int i = 0; i < Names.Count; i++)
    {
        Results.Add(Names[i], Numbers[i]);
    }
    return Results;
}

List<string> TestNames = new List<string> { "Julie", "Harold", "James", "Monica" };

List<int> TestInts = new List<int> { 6, 12, 7, 10 };

Dictionary<string, int> NewDict = GenerateDictionary(TestNames, TestInts);

Console.WriteLine(string.Join(",", NewDict));