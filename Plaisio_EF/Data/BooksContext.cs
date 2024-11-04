using Microsoft.EntityFrameworkCore;
using System;
using Plaisio_EF.Domain;

namespace Plaisio_EF.Data
{
    public class BooksContext : DbContext
    {
        DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                ("Data Source = 192.168.1.89; Initial Catalog = Plaisio_EF; User ID='sa'; Password = '!Abc123456'; Encrypt = false;"); //Integrated Security = true;
        }
    }
}
