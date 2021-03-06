﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CleanArchitecture.Services.Order.API.Entities;

namespace CleanArchitecture.Services.Order.API.Data
{
    public class OrderDbContext : DbContext
    {
        //public OrderDbContext(DbContextOptions<OrderDbContext> options)
        //    : base(options)
        //{ }
        public const string ConnectionString = "Server=(local);Database=OrderDb;Trusted_Connection=True;";


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
        public DbSet<Entities.Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
