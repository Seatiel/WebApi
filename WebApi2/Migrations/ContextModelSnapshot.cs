using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebApi2.Models;

namespace WebApi2.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApi2.Models.Cobros", b =>
                {
                    b.Property<int>("IdCobro")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("EsNulo");

                    b.Property<DateTime>("Fecha");

                    b.Property<int>("IdRemoto");

                    b.Property<int>("IdRuta");

                    b.Property<decimal>("Latitud");

                    b.Property<decimal>("Longitud");

                    b.Property<decimal>("Monto");

                    b.Property<decimal>("Mora");

                    b.Property<string>("Referencia");

                    b.HasKey("IdCobro");

                    b.ToTable("Cobros");
                });
        }
    }
}
