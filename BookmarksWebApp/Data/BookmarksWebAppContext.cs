using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookmarksWebApp.Models;

namespace BookmarksWebApp.Data
{
    public class BookmarksWebAppContext : DbContext
    {
        public BookmarksWebAppContext (DbContextOptions<BookmarksWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<BookmarksWebApp.Models.Bookmarks> Bookmarks { get; set; }
    }
}
