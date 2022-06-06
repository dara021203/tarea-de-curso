using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Prestamo.Domain.Entities;

#nullable disable

namespace Prestamo.Domain.PrestamoEntities
{
    public partial class SistemaPrestamoContext : DbContext
    {
        public SistemaPrestamoContext()
        {
        }

        public SistemaPrestamoContext(DbContextOptions<SistemaPrestamoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Prestamo> Prestamos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-8E5163N\\SERVIDORSQL;Initial Catalog=SistemaPrestamo;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Prestamo>(entity =>
            {
                entity.ToTable("prestamo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CuotaPrestamo).HasColumnName("cuotaPrestamo");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InteresPrestamo).HasColumnName("interesPrestamo");

                entity.Property(e => e.MontoPrestamo).HasColumnName("montoPrestamo");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PagoPrestamo).HasColumnName("pagoPrestamo");

                entity.Property(e => e.TiempoPrestamo).HasColumnName("tiempoPrestamo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
