using FizzBuzz_WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz_WebApp.Data
{
    public class FBContext : DbContext
    {
        public FBContext(DbContextOptions options) : base(options) { }
        public DbSet<Main> FizzBuzzTable { get; set; }
        public DbSet<Person> Person { get; set; }

    }
}
