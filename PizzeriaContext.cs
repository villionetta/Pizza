using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Pizzeria;

public partial class PizzeriaContext : DbContext
{
    public PizzeriaContext()
    {
    }

    public PizzeriaContext(DbContextOptions<PizzeriaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Pizza> Pizzas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=C:\\Users\\Виолетта\\source\\repos\\Pizzeria\\pizzeria.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pizza>(entity =>
        {
            entity.ToTable("pizzas");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ingredients).HasColumnName("ingredients");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Picture).HasColumnName("picture");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Weight).HasColumnName("weight");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
