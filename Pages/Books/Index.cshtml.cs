using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BooksCatalogue.Data;
using BooksCatalogue.Models;

namespace BooksCatalogue.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly BooksCatalogue.Data.BooksCatalogueContext _context;

        public IndexModel(BooksCatalogue.Data.BooksCatalogueContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book.ToListAsync();
            }
        }
    }
}
