using Google_To_Do.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections;

namespace Google_To_Do.Data
{
    public class ApplicationDbContext : DbContext
    {
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<zadanie> zadanie { get; set; }
        //public virtual DbSet<EmployeeLogin> EmployeeLogin { get; set; }
       // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       // {
          //  if (!optionsBuilder.IsConfigured)
           // {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //        optionsBuilder.UseSqlServer("Server=DESKTOP-JI65VED\\SQLEXPRESS;Database=Employee;Trusted_Connection=True;");
        //    }
       // }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<zadanie>().ToTable("Task");



           // modelBuilder.Entity<EmployeeLogin>(entity =>
           // {
            //    entity.Property(e => e.EmpoyeeName)
            //        .HasMaxLength(500)
            //        .IsUnicode(false);

          //      entity.Property(e => e.LoginId)
           //         .HasMaxLength(50)
       //             .IsUnicode(false);

         //       entity.Property(e => e.Password)
        //            .HasMaxLength(200)
          //          .IsUnicode(false);
        //    });

         //   OnModelCreatingPartial(modelBuilder);

        }

      //  private static void OnModelCreatingPartial(ModelBuilder modelBuilder)
       // {
            // implementacja metody OnModelCreatingPartial
       // }
    }
}

