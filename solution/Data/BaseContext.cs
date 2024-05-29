using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using solution.Models;

namespace solution.Data
{
    public class BaseContext: DbContext
    {
         public BaseContext(DbContextOptions<BaseContext> options)
            : base(options){}

    
        public DbSet<Author> Authors {get;set;}
        public DbSet<Book> Books {get;set;}
        public DbSet<Editorial> Editorials {get;set;}
    }
}