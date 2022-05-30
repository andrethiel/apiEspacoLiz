﻿using apiEspacoLiz.Models;
using Microsoft.EntityFrameworkCore;

namespace apiEspacoLiz.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Users> Users { get; set; }
    }
}
