using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JQuerySinglePageCrud.Models;

namespace JQuerySinglePageCrud.Data
{
    public class JQuerySinglePageCrudContext : DbContext
    {
        public JQuerySinglePageCrudContext(DbContextOptions<JQuerySinglePageCrudContext> options) : base(options)
        {
        }
        
        public DbSet<JQuerySinglePageCrud.Models.User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var users = new List<User> {
                    new User { ID = 1, FirstName = "John", LastName = "Doe", Username = "johndoe", Active = true, Email = "johndoe@mail.com" },
                    new User { ID = 2, FirstName = "Jane", LastName = "Doe", Username = "janedoe", Active = true, Email = "janedoe@mail.com" },
                    new User { ID = 3, FirstName = "John", LastName = "Roe", Username = "johnroe", Active = true, Email = "johnroe@mail.com" },
                    new User { ID = 4, FirstName = "Richard", LastName = "Roe", Username = "richardroe", Active = true, Email = "richardroe@mail.com" },
                    new User { ID = 5, FirstName = "Jane", LastName = "Roe", Username = "janeroe", Active = true, Email = "janeroe@mail.com" },
                    new User { ID = 6, FirstName = "Baby", LastName = "Doe", Username = "babydoe", Active = true, Email = "babydoe@mail.com" },
                    new User { ID = 7, FirstName = "Janie", LastName = "Doe", Username = "janiedoe", Active = true, Email = "janedoe@mail.com" },
                    new User { ID = 8, FirstName = "Jhonny", LastName = "Doe", Username = "jhonnydoe", Active = true, Email = "jhonnydoe@mail.com" },
                    new User { ID = 9, FirstName = "Joe", LastName = "Bloggs", Username = "joebloggs", Active = true, Email = "joebloggs@mail.com" },
                    new User { ID = 10, FirstName = "Jane", LastName = "Smith", Username = "janesmith", Active = true, Email = "janesmith@mail.com" },
                    new User { ID = 11, FirstName = "Joe", LastName = "Schmoe", Username = "joeschmoe", Active = true, Email = "joeschmoe@mail.com" },
                    new User { ID = 12, FirstName = "Tom", LastName = "Doe", Username = "tomdoe", Active = true, Email = "tomdoe@mail.com" }
                };

            modelBuilder.Entity<User>().HasData(users);
        }
    }
}
