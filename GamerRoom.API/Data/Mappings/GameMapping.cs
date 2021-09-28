using GamerRoom.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerRoom.API.Data.Mappings
{
    public class GameMapping : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.ToTable("TB_GAMES"); // Nome Tabela

            // Propriedades
            builder.HasKey(p => p.Id); // PK

            builder.Property(p => p.Id)
                .IsRequired()
                .HasColumnName("ID");

            builder.Property(p => p.Name)
                .IsRequired()
                .HasColumnName("Name");

            builder.Property(p => p.Description)
                .IsRequired()
                .HasColumnName("Description");

            builder.Property(p => p.Developer)
                .IsRequired()
                .HasColumnName("Developer");

            builder.Property(p => p.Publisher)
                .IsRequired()
                .HasColumnName("Publisher");

            builder.Property(p => p.Platform)
                .IsRequired()
                .HasColumnName("Platform");

            builder.Property(p => p.Genre)
                .IsRequired()
                .HasColumnName("Genre");

            builder.Property(p => p.Mode)
                .IsRequired()
                .HasColumnName("Mode");

            builder.Property(p => p.ReleaseDate)
                .IsRequired()
                .HasColumnName("ReleaseDate");

            builder.Property(p => p.ImageUri)
                .IsRequired()
                .HasColumnName("ImageUri");

            builder.Property(p => p.TrailerUri)
               .IsRequired()
               .HasColumnName("TrailerUri");
        }
    }
}
