using BLM.DataAccess.EntityModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLM.DataAccess
{
    
    class DataContext : DbContext
    {
        public DataContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=.;database=BLMBD;trusted_connection=true");
        }

        public DbSet<PublisherEntity> Publishers { get; set; }
        public DbSet<BookEntity> Books { get; set; }
        public DbSet<AuthorEntity> Authors { get; set; }
    }
}
