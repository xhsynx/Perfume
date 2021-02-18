using System;
using Microsoft.EntityFrameworkCore;
using Perfume.Models;

namespace Perfume.Data
{
    public class PerfumeDbContext:DbContext
    {
        public PerfumeDbContext(DbContextOptions<PerfumeDbContext> options):base(options)
        {
        }

        public DbSet<PerfumeModel> Perfumes { get; set; }
        public DbSet<UserModel> Users { get; set; }
    }
}
