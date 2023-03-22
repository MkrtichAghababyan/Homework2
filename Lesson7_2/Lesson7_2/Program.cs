using Lesson7_2;
using System.Runtime.InteropServices;








Gen<dynamic> gen = new Gen<dynamic>();
string s = "a";
string s1 = "s";
bool b = default;
gen.Check(s, ref b);
gen.Check1(s1, ref b);
if (b == true)
{
    Console.WriteLine(s + s1);
}
else
{
    Console.WriteLine("string chi menk u mkey");
}
Console.WriteLine(b);