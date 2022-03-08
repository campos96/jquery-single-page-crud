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
        public JQuerySinglePageCrudContext (DbContextOptions<JQuerySinglePageCrudContext> options)
            : base(options)
        {
        }

        public DbSet<JQuerySinglePageCrud.Models.User> User { get; set; }
    }
}
