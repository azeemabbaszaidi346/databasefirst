﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace databasefirst.Models
{
    public partial class databasefirstContext : DbContext
    {
        public databasefirstContext()
        {
        }

        public databasefirstContext(DbContextOptions<databasefirstContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
    }
}

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=CHETUIWK802\\SQLEXPRESS;Initial Catalog=databasefirst;Integrated Security=True;Pooling=False");
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

//            modelBuilder.Entity<Employee>(entity =>
//            {
//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.Address)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Email)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Gender)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.Name)
//                    .HasMaxLength(30)
//                    .IsUnicode(false);
//            });

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    }
//}
