﻿// <auto-generated />
using Core_MVC_General.EFContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Core_MVC_General.Migrations
{
    [DbContext(typeof(LaunchCompanyContext))]
    [Migration("20210107035412_launchmodel")]
    partial class launchmodel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core_MVC_General.EFContext.LaunchCenter", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Commander")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LaunchModel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("LaunchCenter");
                });

            modelBuilder.Entity("Core_MVC_General.EFContext.Staff", b =>
                {
                    b.Property<int>("StaffID")
                        .HasColumnType("int");

                    b.Property<string>("LaunchCenterID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StaffID");

                    b.HasIndex("LaunchCenterID");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("Core_MVC_General.EFContext.Staff", b =>
                {
                    b.HasOne("Core_MVC_General.EFContext.LaunchCenter", null)
                        .WithMany("Personnel")
                        .HasForeignKey("LaunchCenterID");
                });
#pragma warning restore 612, 618
        }
    }
}
