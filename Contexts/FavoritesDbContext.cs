using EMF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMF.Contexts
{
    public class FavoritesDbContext : DbContext
    {

        public FavoritesDbContext(DbContextOptions<FavoritesDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Favorite> Favorites { get; set; }
    }
}
