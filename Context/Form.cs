using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzCelebrates.Models;
using Microsoft.EntityFrameworkCore;

namespace AzCelebrates.Context
{
    public class FormContext : DbContext
    {
        public FormContext(
            DbContextOptions<FormContext> options
        ) : base(options)
        {

        }
        public DbSet<Form> Forms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Form>(e => e.HasKey(i => i.Id));


            base.OnModelCreating(modelBuilder);


        }




    }
}