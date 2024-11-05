using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ToDoApi.Model;

namespace ToDoApi.Data
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Todo> Todos { get; set; }
    }
}
