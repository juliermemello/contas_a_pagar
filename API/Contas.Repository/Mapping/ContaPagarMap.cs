using Contas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Contas.Repository.Mapping
{
    public class ContaPagarMap : IEntityTypeConfiguration<ContaPagar>
    {
        public void Configure(EntityTypeBuilder<ContaPagar> builder)
        {
            builder.ToTable("ContaPagar");

            builder.HasKey(x => x.Id)
                .HasName("PK_ContaPagar_Id");

            builder.Property(x => x.Id)
                .IsRequired()
                .UseIdentityColumn();

            builder.Property(x => x.Nome)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.Valor)
                .HasColumnType("decimal(18, 2)")
                .HasDefaultValue(0)
                .IsRequired();

            builder.Property(x => x.DataVencimento)
                .IsRequired();

            builder.Property(x => x.DataPagamento)
                .IsRequired();

            builder.Property(x => x.DiasAtrasado)
                .HasDefaultValue(0)
                .IsRequired();

            builder.Property(x => x.Multa)
                .HasColumnType("decimal(18, 2)")
                .HasDefaultValue(0)
                .IsRequired();

            builder.Property(x => x.MultaValor)
                .HasColumnType("decimal(18, 2)")
                .HasDefaultValue(0)
                .IsRequired();

            builder.Property(x => x.Juros)
                .HasColumnType("decimal(18, 2)")
                .HasDefaultValue(0)
                .IsRequired();

            builder.Property(x => x.JurosValor)
                .HasColumnType("decimal(18, 2)")
                .HasDefaultValue(0)
                .IsRequired();
        }
    }
}
