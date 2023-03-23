using FilmBoom;

Console.WriteLine("Do you want to watch free ones or paid ones");
string question = Console.ReadLine();
if (question == "free")
{
    Console.WriteLine("Chose Your Janer/Janers");
    Console.WriteLine("there are only 3 janers action detective and horror");
    string janer = Console.ReadLine();
    FreeMovies free = new FreeMovies(janer, out bool check);
    string whilecheck = "y";
    int watch = 0;
    while (whilecheck == "y")
    {
        Console.WriteLine("enter y to contineu n to close");
        whilecheck = Console.ReadLine();
        if (check == false)
        {
            Console.WriteLine("Chose Your Janer/Janers");
            janer = Console.ReadLine();
            free = new FreeMovies(janer, out check);
            break;
        }
        Console.WriteLine("which one do you want to watch janer and id of film");
        janer = Console.ReadLine();
        watch = int.Parse(Console.ReadLine());
        free = new FreeMovies(janer, watch);
    }
}
else
{
    Console.WriteLine("Chose Your Janer/Janers");
    Console.WriteLine("there are only 3 janers action detective and horror");
    string janer = Console.ReadLine();
    PaidMovies free = new PaidMovies(janer, out bool check);
    string whilecheck = "y";
    int watch = default;
    int money = default;
    while (whilecheck == "y")
    {
        Console.WriteLine("enter y to contineu n to close");
        whilecheck = Console.ReadLine();
        if (check == false)
        {
            Console.WriteLine("Chose Your Janer/Janers");
            janer = Console.ReadLine();
            free = new PaidMovies(janer, out check);
            break;
        }
        Console.WriteLine("which one do you want to watch janer and id of film");
        janer = Console.ReadLine();
        watch = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the amonut of your money");
        money = int.Parse(Console.ReadLine());
        free = new PaidMovies(janer, watch, money);
    }
}





















