using api.fatarrow.io.Data.Configurations;
using api.fatarrow.io.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.fatarrow.io.Data
{
    public class Db : DbContext
    {

        public DbSet<Article> Articles { get; set; }
        public DbSet<Author> Authors { get; set; }

        static Db()
        {
            Database.SetInitializer<Db>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new ArticlesConfiguration());
            modelBuilder.Configurations.Add(new AuthorsConfiguration());

        }
    }
}
