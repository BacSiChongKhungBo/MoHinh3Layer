using System;
using System.Collections.Generic;
using DAL.DALVersion1.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace DAL.DALVersion1.Context;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Hang> Hangs { get; set; }

    public virtual DbSet<Nuocngot> Nuocngots { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source= LAPTOP-S8183VSG\\SQLEXPRESS ;Initial Catalog= NUOCNGOTDB;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Hang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__hang__3213E83F28D79F1D");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Nuocngot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NUOCNGOT__3213E83F248190C6");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdHangNavigation).WithMany(p => p.Nuocngots).HasConstraintName("FK__NUOCNGOT__idHang__267ABA7A");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
