using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Truget.Data;

namespace Truget.Data.Migrations
{
    [DbContext(typeof(TrucksContext))]
    [Migration("20170722143104_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Truget.Data.Models.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<int?>("CountryId");

                    b.Property<string>("Name");

                    b.Property<int>("Number");

                    b.Property<string>("Street");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Truget.Data.Models.Company", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("AddressId");

                    b.Property<string>("ContactName");

                    b.Property<string>("Email");

                    b.Property<string>("Logo");

                    b.Property<string>("Name");

                    b.Property<string>("PLCNumber");

                    b.Property<string>("PhoneNumber");

                    b.Property<int>("TotalTrucks");

                    b.Property<string>("TrucksSizes");

                    b.Property<string>("TrucksTypes");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Truget.Data.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Truget.Data.Models.Truck", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("CompanyId");

                    b.Property<string>("Image");

                    b.Property<float>("MaxHeight");

                    b.Property<float>("MaxLength");

                    b.Property<float>("MaxWeight");

                    b.Property<float>("MaxWidth");

                    b.Property<string>("Sizes");

                    b.Property<string>("Types");

                    b.Property<string>("UDID")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Trucks");
                });

            modelBuilder.Entity("Truget.Data.Models.TruckSize", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("SizeName");

                    b.HasKey("Id");

                    b.ToTable("TruckSizes");
                });

            modelBuilder.Entity("Truget.Data.Models.TruckType", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TypeName");

                    b.HasKey("Id");

                    b.ToTable("TruckTypes");
                });

            modelBuilder.Entity("Truget.Data.Models.Address", b =>
                {
                    b.HasOne("Truget.Data.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");
                });

            modelBuilder.Entity("Truget.Data.Models.Company", b =>
                {
                    b.HasOne("Truget.Data.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");
                });

            modelBuilder.Entity("Truget.Data.Models.Truck", b =>
                {
                    b.HasOne("Truget.Data.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");
                });
        }
    }
}
