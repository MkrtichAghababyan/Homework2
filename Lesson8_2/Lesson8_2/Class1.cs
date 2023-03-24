using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_2
{
    class Class1
    {
        public Class1()
        {
            Films(out Hashtable namejaner, out Hashtable nameprice);
            foreach (string key in namejaner.Keys)
            {
                Console.WriteLine(String.Format("{0}: {1} : {2}", key, namejaner[key], nameprice[key]));
            }
            Console.WriteLine("Which Oen Do You Want To Watch");
        }
        public Class1(string filmname,int money)
        {
            Films(out Hashtable namejaner, out Hashtable nameprice);
            switch (filmname) 
            {
                case "Terminator":
                    if (money < Convert.ToInt32(nameprice[filmname]))
                    {
                        Console.WriteLine("You Dont Have Enough Money");
                    }
                    else
                    {
                        Console.WriteLine($"You Are Watching {namejaner[filmname]}");
                    }
                    break;
                case "Rambo":
                    if (money < Convert.ToInt32(nameprice[filmname]))
                    {
                        Console.WriteLine("You Dont Have Enough Money");
                    }
                    else
                    {
                        Console.WriteLine($"You Are Watching {namejaner[filmname]}");
                    }
                    break;
                default:
                    Console.WriteLine("There Is No Such Film");
                        break;
            }
        }
        public void Films(out Hashtable namejaner,out Hashtable nameprice)
        {
            namejaner = new Hashtable()
            {
                { "Terminator","Action" },
                { "Rambo","Action"}
            };
            
            nameprice = new Hashtable()
            {
                { "Terminator",2000 },
                { "Rambo",3000 }
            };

        }
    }
}
