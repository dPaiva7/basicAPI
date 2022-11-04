using System;
using BasicAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicAPI.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Fornecedor> Fornecedor { get; set; }
    }
}

