using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmBoom
{
    class PaidMovies: IProperties
    {
        public double Cost { get; set; }
        public int Id { get; set; } = default;
        public string Name { get; set; } = "";
        public int WatchedCount { get; set; } = default;
        public bool Stared { get; set; } = default;
        public string About { get; set; } = "";
        public string Actors { get; set; } = "";

        public PaidMovies()
        {

        }
        //stugumnerna katarum 
        public PaidMovies(string janer, int watch,int money)
        {
            string check = "";
            int i = 0;
            switch (janer)
            {
                case "action":
                    Action(out IList<PaidMovies> actionfilms);
                    var actionresult = from a in actionfilms select new { Id = a.Id };
                    foreach (var d in actionresult)
                    {
                        if (actionfilms[i].Id == watch)
                        {
                            if (Cost > money)
                            {
                                Console.WriteLine("you dont have enough money to watch it");
                                break;
                            }
                            if (actionfilms[i].Stared == true || WatchedCount > 0)
                            {
                                Console.WriteLine("You have watched it before wann watch it again y/n");
                                check = Console.ReadLine();
                                Console.WriteLine($"You are watching {actionfilms[i].Name} film");

                            }
                            else
                            {
                                WatchedCount++;
                                actionfilms[i].Stared = true;
                                Console.WriteLine($"You are watching {actionfilms[i].Name} film");
                            }
                        }
                        i++;
                    }
                    break;
                case "horror":
                    Horror(out IList<PaidMovies> horrorfilms);
                    i = 0;
                    var horrorresult = from a in horrorfilms select new { Id = a.Id };
                    foreach (var d in horrorresult)
                    {
                        if (horrorfilms[i].Id == watch)
                        {
                            if (Cost > money)
                            {
                                Console.WriteLine("you dont have enough money to watch it");
                                break;
                            }
                            if (horrorfilms[i].Stared == true || WatchedCount > 0)
                            {
                                Console.WriteLine("You have watched it before wann watch it again y/n");
                                check = Console.ReadLine();
                                Console.WriteLine($"You are watching {horrorfilms[i].Name} film");

                            }
                            else
                            {
                                WatchedCount++;
                                horrorfilms[watch].Stared = true;
                                Console.WriteLine($"You are watching {horrorfilms[i].Name} film");
                            }
                        }
                        i++;
                    }
                    break;
                case "detective":
                    Detective(out IList<PaidMovies> detectivefilms);
                    i = 0;
                    var detectiveresult = from a in detectivefilms select new { Id = a.Id };
                    foreach (var d in detectiveresult)
                    {
                        if (detectivefilms[i].Id == watch)
                        {
                            if (Cost > money)
                            {
                                Console.WriteLine("you dont have enough money to watch it");
                                break;
                            }
                            if (detectivefilms[i].Stared == true || WatchedCount > 0)
                            {
                                Console.WriteLine("You have watched it before wann watch it again y/n");
                                check = Console.ReadLine();
                                Console.WriteLine($"You are watching {detectivefilms[i].Name} film");

                            }
                            else
                            {
                                WatchedCount++;
                                detectivefilms[watch].Stared = true;
                                Console.WriteLine($"You are watching {detectivefilms[i].Name} film");
                            }
                        }
                        i++;
                    }
                    break;
            }
        }
        //ashxatacnuma amen inch
        public PaidMovies(string janer, out bool check)
        {
            check = true;
            switch (janer)
            {
                case "action":
                    Action(out IList<PaidMovies> actionfilms);
                    var actionresult = from a in actionfilms
                                       select new
                                       {
                                           Id = a.Id,
                                           Name = a.Name + "\t" + a.Actors + "\t" + a.About + "\t" + a.Cost
                                       };

                    foreach (var d in actionresult)
                    {
                        Console.WriteLine(d);
                    }
                    break;
                case "horror":
                    Horror(out IList<PaidMovies> horrorfilms);
                    var horrorresult = from a in horrorfilms
                                       select new
                                       {
                                           Id = a.Id,
                                           Name = a.Name + "\t" + a.Actors + "\t" + a.About + "\t" + a.Cost
                                       };

                    foreach (var d in horrorresult)
                    {
                        Console.WriteLine(d);
                    }
                    break;
                case "detective":
                    Detective(out IList<PaidMovies> detectivefilms);
                    var detectiveresult = from a in detectivefilms
                                          select new
                                          {
                                              Id = a.Id,
                                              Name = a.Name + "\t" + a.Actors + "\t" + a.About + "\t" + a.Cost
                                          };

                    foreach (var d in detectiveresult)
                    {
                        Console.WriteLine(d);
                    }
                    break;
                case "all":
                    Detective(out IList<PaidMovies> detectivefilmsall);
                    var detectiveresultall = from a in detectivefilmsall
                                             select new
                                             {
                                                 Id = a.Id,
                                                 Name = a.Name + "\t" + a.Actors + "\t" + a.About + "\t" + a.Cost
                                             };

                    foreach (var d in detectiveresultall)
                    {
                        Console.WriteLine(d);
                    }
                    Console.WriteLine();
                    Horror(out IList<PaidMovies> horrorfilmsall);
                    var horrorresultall = from a in horrorfilmsall
                                          select new
                                          {
                                              Id = a.Id,
                                              Name = a.Name + "\t" + a.Actors + "\t" + a.About + "\t" + a.Cost
                                          };

                    foreach (var d in horrorresultall)
                    {
                        Console.WriteLine(d);
                    }
                    Console.WriteLine();
                    Action(out IList<PaidMovies> actionfilmsall);
                    var actionresultall = from a in actionfilmsall
                                          select new
                                          {
                                              Id = a.Id,
                                              Name = a.Name + "\t" + a.Actors + "\t" + a.About + "\t" + a.Cost
                                          };

                    foreach (var d in actionresultall)
                    {
                        Console.WriteLine(d);
                    }
                    break;
                default:
                    Console.WriteLine("there is no such janer in our library");
                    check = false;
                    break;
            }
        }

        public  void Action(out IList<PaidMovies> actionfilms)
        {
            actionfilms = new List<PaidMovies>()
            {
               new PaidMovies() { Id = 1, Name = "Rambo",Actors = "Silvester Stalone", About = "Rambo", Stared = false, Cost= 2000} ,
               new PaidMovies() { Id = 2, Name = "Terminato",Actors = "Arnold Shwarcneger", About = "Terminator",Stared=false, Cost = 1000}
            };
        }
        public  void Horror(out IList<PaidMovies> horrorfilms)
        {
            horrorfilms = new List<PaidMovies>()
            {
               new PaidMovies() { Id = 1, Name = "Witcher",Actors = "withches", About = "Witcher",Stared = false,Cost = 1500} ,
               new PaidMovies() { Id = 2, Name = "Anabel",Actors = "Doll", About = "Anabel",Stared = false,Cost = 2000 }
            };
        }
        public  void Detective(out IList<PaidMovies> detectivefilms)
        {
            detectivefilms = new List<PaidMovies>()
            {
               new PaidMovies() { Id = 1, Name = "Sherolc Holmes",Actors = "Tony Starck", About = "Serolc Holmes", Stared = false,Cost = 3000} ,
               new PaidMovies() { Id = 2, Name = "Snowmen",Actors = "dunno", About = "Snowman" , Stared = false, Cost = 4000}
            };
        }
    }
}
