using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;

namespace EntityFrameworkTest
{
    class Seeder
    {
        public static void Seed(DataContext context)
        {
            var users = new List<User>
            {
                new User
                {
                    Forename = "Viqas",
                    Surname = "Hussain"
                }
            };
            users.ForEach(u => context.User.Add(u));
            context.SaveChanges();
        }
    }
}
