using static Lesson6_2.Class1;
using System.IO;
using Lesson6_2;
using System.Linq.Expressions;

//-------------------------------------Main Start

Kextot k = new Kextot(ZinvoriPox);
k += Tokos;
int i = int.Parse(Console.ReadLine());
k(ref i);
Console.WriteLine(i);




//-----------------------------------Main End
void Add<T>(T a, T b)
{
    Console.WriteLine((T)Covert.ChangeType  );
}
int ZinvoriPox(ref int i)
{
    i -= i * 10 / 100;
    return i;
}
int Tokos(ref int i)
{
    i -= i * 5 / 100;

    return i;
}
string? Stra(string str)
{
    Console.WriteLine("Stra");
    return str;
}
string? Stra2(string str)
{
    Console.WriteLine("Stra2");
    return str;
}
string? Stra1(string str)
{
    Console.WriteLine("Stra1");
    return str;
}
public delegate int Kextot(ref int i);
public delegate string? DelString(string str);