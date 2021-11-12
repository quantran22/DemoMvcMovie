using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

    public class AplicationDBContext : DbContext
    {
        public AplicationDBContext (DbContextOptions<AplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Person> Person { get; set; }

        public DbSet<MvcMovie.Models.Student> Student { get; set; }

        public DbSet<MvcMovie.Models.Employee> Employee { get; set; }

        public DbSet<MvcMovie.Models.Product> Product { get; set; }
    }
