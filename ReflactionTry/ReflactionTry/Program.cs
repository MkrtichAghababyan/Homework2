using System.Reflection;
string a = "16545454";
Console.WriteLine(a.GetHashCode());
Assembly info = typeof(int).Assembly;
Console.WriteLine(info);
string s = "a";
string s1 = "a";
var q = s.Normalize();
Console.WriteLine(s1.GetHashCode());
Console.WriteLine(s.GetHashCode());
Console.WriteLine(q.GetHashCode());
Console.WriteLine();
List<object> list = new List<object>();
list.Add(1);
list.Add("2");
list.Add(3d);
list.Add(5l);
foreach (object obj in list)
{
    Console.WriteLine();
}
