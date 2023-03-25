using System;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.Arm;
using System.Transactions;


string abcTrue = "abcdefghijklmnopqrstuvwxyz";
string AbcTrue = abcTrue.ToUpper();
Console.WriteLine(abcTrue);
int[] index = new int[abcTrue.Length];
int ind = 0;
foreach (var s in UniqueRandom(0,abcTrue.Length-1))
{
    index[ind] = s;
    ind++;
}
string abcKey = "";
for (int i = 0; i < index.Length; i++)
{
    abcKey += abcTrue[index[i]];
}
string AbcKey = abcKey.ToUpper();
Console.WriteLine(abcKey);
Console.Write("Enter Text:");
string text = Console.ReadLine();
string output = "";
for (int i = 0; i < text.Length; i++)
{
    for (int j = 0; j < abcKey.Length; j++)
    {
        if (text[i]== abcTrue[j])
        {
            output += abcKey[j];
            break;
        }
        if (text[i]== AbcTrue[j])
        {
            output += AbcKey[j];
            break;
        }
    }
}
Console.WriteLine("Output:{0}",output);







IEnumerable<int> UniqueRandom(int minInclusive, int maxInclusive)
{
    List<int> candidates = new List<int>();
    for (int i = minInclusive; i <= maxInclusive; i++)
    {
        candidates.Add(i);
    }
    Random rnd = new Random();
    while (candidates.Count > 0)
    {
        int index = rnd.Next(candidates.Count);
        yield return candidates[index];
        candidates.RemoveAt(index);
    }
}
