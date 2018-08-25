using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    class AddEmployee
    {
        public static User CreateNewUser(EfModelContainer db)
        {
            User user = new User();                             // it named "User" cause f##king model refuses to work properly

            try
            {
                Console.WriteLine("Enter name of employee");
                user.FirstName = Console.ReadLine();

                Console.WriteLine("Enter last name of employee");
                user.LastName = Console.ReadLine();

                Console.WriteLine("Enter Email");
                user.Email = Console.ReadLine();

                Console.WriteLine("Enter department name of employee");
                string employeeDepartment = Console.ReadLine();

                //if (db.Departments.)
                //{

               // }
                //var createdEmployee = db.Departments.                   //here mb needed to add checking for not null
                //    Where(c => c.Name == employeeDepartment).
                //     FirstOrDefault();

                // user.Department = createdEmployee;
                user.Department = new Department()
                {
                    Name = employeeDepartment,
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Something went wrong when create an employee");
            }
            return user;
        }

        public static void AddNewEmploye(EfModelContainer db)
        {
            db.Users.Add(CreateNewUser(db));
        }
    }
}
