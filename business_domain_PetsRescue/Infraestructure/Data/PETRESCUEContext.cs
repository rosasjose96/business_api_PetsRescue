using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace business_domain_PetsRescue.Infraestructure.Data
{
    public partial class PETRESCUEContext : DbContext
    {
        public PETRESCUEContext()
        {
        }

        public PETRESCUEContext(DbContextOptions<PETRESCUEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adoptados> Adoptados { get; set; }
        public virtual DbSet<Estados> Estados { get; set; }
        public virtual DbSet<Mascotas> Mascotas { get; set; }
        public virtual DbSet<MascotasPerdidas> MascotasPerdidas { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=161.97.123.59\\SIA;Database=PETRESCUE;User=pet;Password=A123456$");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Adoptados>(entity =>
            {
                entity.ToTable("ADOPTADOS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Codmascota)
                    .HasMaxLength(11)
                    .HasColumnName("CODMASCOTA");

                entity.Property(e => e.Descripción)
                    .HasMaxLength(255)
                    .HasColumnName("DESCRIPCIÓN");

                entity.Property(e => e.Estado).HasColumnName("ESTADO");

                entity.Property(e => e.FechaBaja)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_BAJA");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_REGISTRO");

                entity.Property(e => e.FechaUltimaActualizacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ULTIMA_ACTUALIZACION");

                entity.Property(e => e.Foto)
                    .HasColumnType("image")
                    .HasColumnName("FOTO");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(151)
                    .HasColumnName("USUARIO");
            });

            modelBuilder.Entity<Estados>(entity =>
            {
                entity.ToTable("ESTADOS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .HasColumnName("ESTADO");
            });

            modelBuilder.Entity<Mascotas>(entity =>
            {
                entity.ToTable("MASCOTAS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Codmascota)
                    .HasMaxLength(11)
                    .HasColumnName("CODMASCOTA");

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .HasColumnName("COLOR");

                entity.Property(e => e.Correo)
                    .HasMaxLength(151)
                    .HasColumnName("CORREO");

                entity.Property(e => e.Descripción)
                    .HasMaxLength(255)
                    .HasColumnName("DESCRIPCIÓN");

                entity.Property(e => e.Edad)
                    .HasMaxLength(12)
                    .HasColumnName("EDAD");

                entity.Property(e => e.Estado).HasColumnName("ESTADO");

                entity.Property(e => e.FechaBaja)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_BAJA");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_REGISTRO");

                entity.Property(e => e.FechaUltimaActualizacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ULTIMA_ACTUALIZACION");

                entity.Property(e => e.Foto)
                    .HasColumnType("image")
                    .HasColumnName("FOTO");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(80)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Propietario)
                    .HasMaxLength(10)
                    .HasColumnName("PROPIETARIO")
                    .IsFixedLength(true);

                entity.Property(e => e.Raza)
                    .HasMaxLength(80)
                    .HasColumnName("RAZA");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(255)
                    .HasColumnName("USUARIO");
            });

            modelBuilder.Entity<MascotasPerdidas>(entity =>
            {
                entity.ToTable("MASCOTAS_PERDIDAS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Codmascota)
                    .HasMaxLength(11)
                    .HasColumnName("CODMASCOTA");

                entity.Property(e => e.Descripción)
                    .HasMaxLength(255)
                    .HasColumnName("DESCRIPCIÓN");

                entity.Property(e => e.Estado).HasColumnName("ESTADO");

                entity.Property(e => e.FechaBaja)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_BAJA");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_REGISTRO");

                entity.Property(e => e.FechaUltimaActualizacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ULTIMA_ACTUALIZACION");

                entity.Property(e => e.Foto)
                    .HasColumnType("image")
                    .HasColumnName("FOTO");

                entity.Property(e => e.Informador)
                    .HasMaxLength(10)
                    .HasColumnName("INFORMADOR")
                    .IsFixedLength(true);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(255)
                    .HasColumnName("USUARIO");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.ToTable("USUARIOS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(80)
                    .HasColumnName("APELLIDO");

                entity.Property(e => e.Clave)
                    .HasMaxLength(12)
                    .HasColumnName("CLAVE");

                entity.Property(e => e.Correo)
                    .HasMaxLength(151)
                    .HasColumnName("CORREO");

                entity.Property(e => e.Dni)
                    .HasMaxLength(11)
                    .HasColumnName("DNI");

                entity.Property(e => e.Estado).HasColumnName("ESTADO");

                entity.Property(e => e.FechaBaja)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_BAJA");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_REGISTRO");

                entity.Property(e => e.FechaUltimaActualizacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ULTIMA_ACTUALIZACION");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(80)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(11)
                    .HasColumnName("TELEFONO");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
