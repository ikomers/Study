using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF    
{
    //TODO: Add Unity (IOC  for Dependency Injection)
    //TODO: Convert CodeFirst
    //TODO: Extract database to separated project
    //TODO: Add services for DB logic
    //TODO: Is evil
    class Program : AddEmployee
    {
        static void Main(string[] args)
        {
            var db = new EfModelContainer();

            Console.WriteLine("Enter admin department name");
            Department department1 = new Department { Name = Console.ReadLine() };
            var chiefShepherd = new Admin()
            {
                FirstName = "Boss",
                LastName = "Super",
                Email = "example@email.net",
                Level = 100500,
                Department = department1,
                //and Birthday
            };

            db.Departments.Add(department1);
            db.SaveChanges();

            CreateNewEmploee:
            Console.WriteLine("Would you like to create new Employe?");
            Console.WriteLine("Enter Y or N");
            string ch = Console.ReadLine();

            if ((ch == "y") | (ch == "Y"))
            {
                AddNewEmploye(db);
            }
            else if (!((ch == "n") | (ch == "N")) && !((ch == "y") | (ch == "Y"))) //not Yes or No
            {
                Console.WriteLine("You entered an invalid character");
                goto CreateNewEmploee;                 //CHANGE TO IF-ELSE             
            }
            

            try
            {
                db.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (DbEntityValidationResult validationError in ex.EntityValidationErrors)
                {
                    Console.Write("Object: " + validationError.Entry.Entity.ToString());
                    Console.Write(" ");
                    foreach (DbValidationError err in validationError.ValidationErrors)
                    {
                        Console.WriteLine(err.ErrorMessage + "");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write("Object: " + ex.ToString());
            }

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("chiefShepherd is: " + chiefShepherd.FirstName);

            foreach (var department in db.Departments)
            {
                Console.WriteLine("The following employees work in the "+ department.Name + " department:");
                foreach (var user in department.Users)
                {
                    Console.WriteLine("\t" + user.FirstName + " " + user.LastName + " " + user.Email);
                }
            }

            //db.Departments.RemoveRange(db.Departments);
            //db.Users.RemoveRange(db.Users);

            try
            {
                db.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (DbEntityValidationResult validationError in ex.EntityValidationErrors)
                {
                    Console.Write("Object: " + validationError.Entry.Entity.ToString());
                    Console.Write(" ");
                    foreach (DbValidationError err in validationError.ValidationErrors)
                    {
                        Console.Write(err.ErrorMessage + " ");
                        Console.ReadKey();
                    }
                }
            }
            
            Console.ReadKey();
        }
    }
}