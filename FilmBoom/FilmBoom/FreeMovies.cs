using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FilmBoom
{
    class FreeMovies : IProperties
    {
        public int Id { get; set; } = default;
        public string Name { get; set; } = "";
        public int WatchedCount { get; set; } = default;
        public bool Stared { get; set; } = default;
        public string About { get; set; } = "";
        public string Actors { get; set; } = "";

        public FreeMovies()
        {
            
        }
        public FreeMovies(string janer,int watch)
        {
            string check = "";
            int i = 0;
            switch (janer)
            {
                case "action":
                    Action(out IList<FreeMovies> actionfilms);
                    var actionresult = from a in actionfilms select new { Id = a.Id };
                    foreach (var d in actionresult)
                    {
                        if (actionfilms[i].Id == watch)
                        {
                            if(actionfilms[i].Stared == true || WatchedCount>0)
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
                    Horror(out IList<FreeMovies> horrorfilms);
                    i = 0;
                    var horrorresult = from a in horrorfilms select new { Id = a.Id };
                    foreach (var d in horrorresult)
                    {
                        if (horrorfilms[i].Id == watch)
                        {
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
                    Detective(out IList<FreeMovies> detectivefilms);
                    i = 0;
                    var detectiveresult = from a in detectivefilms select new { Id = a.Id };
                    foreach (var d in detectiveresult)
                    {
                        if (detectivefilms[i].Id == watch)
                        {
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
        public FreeMovies(string janer,out bool check)
        {
            check = true;
            switch (janer)
            {
                case "action":
                    Action(out IList<FreeMovies> actionfilms);
                    var actionresult = from a in actionfilms
                                       select new
                                       {
                                           Id = a.Id,
                                           Name = a.Name + "\t" + a.Actors + "\t" + a.About
                                       };

                    foreach (var d in actionresult)
                    {
                        Console.WriteLine(d);
                    }
                    break;
                case "horror":
                    Horror(out IList<FreeMovies> horrorfilms);
                    var horrorresult = from a in horrorfilms
                                       select new
                                       {
                                           Id = a.Id,
                                           Name = a.Name + "\t" + a.Actors + "\t" + a.About
                                       };

                    foreach (var d in horrorresult)
                    {
                        Console.WriteLine(d);
                    }
                    break;
                case "detective":
                    Detective(out IList<FreeMovies> detectivefilms);
                    var detectiveresult = from a in detectivefilms
                                          select new
                                          {
                                              Id = a.Id,
                                              Name = a.Name + "\t" + a.Actors + "\t" + a.About
                                          };

                    foreach (var d in detectiveresult)
                    {
                        Console.WriteLine(d);
                    }
                    break;
                case "all":
                    Detective(out IList<FreeMovies> detectivefilmsall);
                    var detectiveresultall = from a in detectivefilmsall
                                             select new
                                             {
                                                 Id = a.Id,
                                                 Name = a.Name + "\t" + a.Actors + "\t" + a.About
                                             };

                    foreach (var d in detectiveresultall)
                    {
                        Console.WriteLine(d);
                    }
                    Console.WriteLine();
                    Horror(out IList<FreeMovies> horrorfilmsall);
                    var horrorresultall = from a in horrorfilmsall
                                          select new
                                          {
                                              Id = a.Id,
                                              Name = a.Name + "\t" + a.Actors + "\t" + a.About
                                          };

                    foreach (var d in horrorresultall)
                    {
                        Console.WriteLine(d);
                    }
                    Console.WriteLine();
                    Action(out IList<FreeMovies> actionfilmsall);
                    var actionresultall = from a in actionfilmsall
                                          select new
                                          {
                                              Id = a.Id,
                                              Name = a.Name + "\t" + a.Actors + "\t" + a.About 
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

        public  void Action(out IList<FreeMovies> actionfilms)
        {
            actionfilms = new List<FreeMovies>()
            {
               new FreeMovies() { Id = 1, Name = "Avengers",Actors = "Tony Stark,Captain America", About = "Avengeing someone", Stared = false} ,
               new FreeMovies() { Id = 2, Name = "Maze Runner",Actors = "dunno", About = "running in maze",Stared=false }
            };
        }
        public  void Horror(out IList<FreeMovies> horrorfilms)
        {
            horrorfilms = new List<FreeMovies>()
            {
               new FreeMovies() { Id = 1, Name = "Something",Actors = "dunno", About = "about aliens",Stared = false} ,
               new FreeMovies() { Id = 2, Name = "It",Actors = "Cloun", About = "About killer cloun",Stared = false }
            };
        }
        public  void Detective(out IList<FreeMovies> detectivefilms)
        {
            detectivefilms = new List<FreeMovies>()
            {
               new FreeMovies() { Id = 1, Name = "12",Actors = "dunno", About ="rusakan hetaqrqir ban", Stared = false} ,
               new FreeMovies() { Id = 2, Name = "Legend",Actors = "Tom Hardy", About = "About Criminals" , Stared = false}
            };
        }

    }
}
