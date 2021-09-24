using GamerRoom.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerRoom.API.Data.Mappings
{
    public class UserGameMapping : IEntityTypeConfiguration<UserGame>
    {
        public void Configure(EntityTypeBuilder<UserGame> builder)
        {
            builder.ToTable("TB_USERGAMES");

            // PROPS
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("ID")
                .ValueGeneratedOnAdd();

            builder.Property(p => p.Rating)
                .IsRequired()
                .HasColumnName("RATING");

            builder.HasOne(p => p.User)
                .WithMany()
                .HasForeignKey(fk => fk.Id)
                .HasConstraintName("FK_USER_ID");

            builder.HasOne(p => p.Game)
                .WithMany()
                .HasForeignKey(fk => fk.GameId)
                .HasConstraintName("FK_GAME_ID");
        }
    }
}
