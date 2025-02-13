﻿using Microsoft.EntityFrameworkCore;
using LMS.WEB.Models;
namespace LMS.WEB.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Author> Authors { get; set; }
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options)
            : base(options) { }
        public DbSet<LMS.WEB.Models.Author> Author { get; set; }
    }
}
