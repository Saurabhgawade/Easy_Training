using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EntityToDatabase.Models;

namespace EntityToDatabase.Data
{
    public class EntityToDatabaseContext : DbContext
    {
        public EntityToDatabaseContext (DbContextOptions<EntityToDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<EntityToDatabase.Models.Student> Student { get; set; } = default!;
    }
}
