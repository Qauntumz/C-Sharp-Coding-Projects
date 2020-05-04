using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new WebContext())
            {
                Console.WriteLine("Enter your desired Username");
                var name = Console.ReadLine();

                Console.WriteLine("Enter your First Name");
                var fname = Console.ReadLine();

                Console.WriteLine("Enter your Last Name");
                var lname = Console.ReadLine();

                Console.WriteLine("Enter your Email Address");
                var emaddress = Console.ReadLine();


                var user = new User { UserName = name, FirstName = fname, LastName = lname, EmailAddress = emaddress };
                db.Users.Add(user);
                db.SaveChanges();

                Console.WriteLine("Enter your favorite number");
                int fnum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your favorite word");
                var fword = Console.ReadLine();

                var favorite = new Favorite { FavNum = fnum, FavWord = fword };

                db.Favorites.Add(favorite);
                db.SaveChanges();

                var query = from b in db.Users orderby b.UserName select b;

                var query2 = from c in db.Favorites orderby c.FavNum select c;

                Console.WriteLine("All Users in the database");
                foreach (var item in query)
                {
                    Console.Write(" " + item.UserName  + " " + item.FirstName + " " + item.LastName + " " + item.EmailAddress + "\n");
                }

                Console.WriteLine("And here is all the chosen Favorite numbers so far");


                foreach (var item2 in query2)
                {
                    Console.Write(" " + item2.FavNum + " ");
                    Console.WriteLine(" ");
                }


                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                


            }
        }
    }
}
