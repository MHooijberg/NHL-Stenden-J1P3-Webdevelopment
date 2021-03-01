using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyMeals.Models;
namespace MyMeals.Data
{
    public class ContactDbContext : DbContext
    {
        public ContactDbContext(DbContextOptions options) : base(options) {}
        public DbSet<ContactRequest> ContactRequests { get; set; }
    }
}
