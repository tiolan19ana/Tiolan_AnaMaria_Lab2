using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tiolan_AnaMaria_Lab2.Models;

namespace Tiolan_AnaMaria_Lab2.Data
{
    public class Tiolan_AnaMaria_Lab2Context : DbContext
    {
        public Tiolan_AnaMaria_Lab2Context (DbContextOptions<Tiolan_AnaMaria_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Tiolan_AnaMaria_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Tiolan_AnaMaria_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
