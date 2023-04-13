using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BooksCatalogue.Models;

namespace BooksCatalogue.Data
{
    public class BooksCatalogueContext : DbContext
    {
        public BooksCatalogueContext (DbContextOptions<BooksCatalogueContext> options)
            : base(options)
        {
        }

        public DbSet<BooksCatalogue.Models.Book> Book { get; set; } = default!;
    }
}
