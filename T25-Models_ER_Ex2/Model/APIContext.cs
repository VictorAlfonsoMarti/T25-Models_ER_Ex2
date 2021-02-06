using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace T25_Models_ER_Ex2.Model
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> options) : base(options) { }

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departamento>(departamento =>
            {
                // NOMBRE DE LA TABLATABLA
                departamento.ToTable("DEPARTAMENTOS");

                //  DEFINICIÓN COLUMNA
                departamento.Property(p => p.Codigo)
                    .HasColumnName("Codigo");

                departamento.Property(p => p.Nombre)
                    .HasColumnName("Nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);
                departamento.Property(p => p.Presupuesto)
                    .HasColumnName("Presupuesto");

                // DEFINICIÓN DE CLAVES
                departamento.HasKey(p => p.Codigo);
            });

            modelBuilder.Entity<Empleado>(empleado =>
            {
                // NOMBRE DE LA TABLATABLA
                empleado.ToTable("EMPLEADOS");

                //  DEFINICIÓN COLUMNA
                empleado.Property(p => p.Dni)
                    .HasColumnName("DNI");

                empleado.Property(p => p.Nombre)
                    .HasColumnName("Nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);
                empleado.Property(p => p.Apellidos)
                    .HasColumnName("Apellidos")
                    .HasMaxLength(255)
                    .IsUnicode(false);
                empleado.Property(p => p.Departamento)
                    .HasColumnName("Departamento");

                // DEFINICIÓN DE CLAVES
                empleado.HasKey(p => p.Dni);

                // RELACIONES
                empleado.HasOne(e => e.Departamentos)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.Departamento)
                    .HasConstraintName("Departamento_pk");
            });
        }
    }
}
