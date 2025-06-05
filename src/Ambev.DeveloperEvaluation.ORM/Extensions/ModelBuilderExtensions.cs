using Ambev.DeveloperEvaluation.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.ORM.Extensions
{
    internal static class ModelBuilderExtensions
    {
        public static void ConfigureBaseEntity<TEntity>(this EntityTypeBuilder<TEntity> builder) where TEntity : BaseEntity
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id)
                .HasColumnType("uuid");

            builder.Property(u => u.CreatedAt)
                .HasColumnType("timestamp with time zone")
                .IsRequired();

            builder.Property(u => u.UpdatedAt)
                .HasColumnType("timestamp with time zone")
                .IsRequired(false);
        }
    }
}
