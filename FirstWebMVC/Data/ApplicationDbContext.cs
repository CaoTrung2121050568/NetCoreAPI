using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstWebMVC.Models.Entities;

namespace FirstWebMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; } = default!;
    }
}
