using JRockoMusic.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace JRockoMusic.Data.Configuracion
{
    public class PerfilConfiguracion : IEntityTypeConfiguration<Perfil>
    {
        void IEntityTypeConfiguration<Perfil>.Configure(EntityTypeBuilder<Perfil> entity)
        {
            entity.ToTable("Perfil", "tienda");

            entity.Property(e => e.Nombre).HasMaxLength(50);
        }
    }
}
