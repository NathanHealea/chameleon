﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NathaHealea.Chameleon.Library.Contexts;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace NathaHealea.Chameleon.Library.Migrations
{
    [DbContext(typeof(ChameleonDbContext))]
    [Migration("20210322192133_CHMLN-1.0.0-Initialization")]
    partial class CHMLN100Initialization
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);
#pragma warning restore 612, 618
        }
    }
}
