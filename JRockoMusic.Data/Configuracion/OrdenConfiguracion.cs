using JRockoMusic.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace JRockoMusic.Data.Configuracion
{
    public class OrdenConfiguracion : IEntityTypeConfiguration<Orden>
    {
        void IEntityTypeConfiguration<Orden>.Configure(EntityTypeBuilder<Orden> entity)
        {
            entity.ToTable("Orden", "tienda");

            entity.HasIndex(e => e.UsuarioId, "IX_Orden_UsuarioId");

            entity.Property(e => e.CantidadArticulos).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Usuario)
                .WithMany(p => p.Ordens)
                .HasForeignKey(d => d.UsuarioId);
        }
    }
}
