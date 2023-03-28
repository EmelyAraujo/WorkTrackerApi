using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WorkTrackerApi.Models;
namespace WorkTrackerApi.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Materiales> materiales => Set<Materiales>();

        public Contexto(DbContextOptions<Contexto> options)
                : base(options) { }
    }

}
