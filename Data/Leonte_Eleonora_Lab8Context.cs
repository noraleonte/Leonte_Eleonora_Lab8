using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Leonte_Eleonora_Lab8.Models;

namespace Leonte_Eleonora_Lab8.Data
{
    public class Leonte_Eleonora_Lab8Context : DbContext
    {
        public Leonte_Eleonora_Lab8Context (DbContextOptions<Leonte_Eleonora_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Leonte_Eleonora_Lab8.Models.Book> Book { get; set; }

        public DbSet<Leonte_Eleonora_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Leonte_Eleonora_Lab8.Models.BookCategory> BookCategory { get; set; }
    }
}
