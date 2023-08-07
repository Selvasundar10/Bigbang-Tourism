﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserAPI.DB;

#nullable disable

namespace UserAPI.Migrations
{
    [DbContext(typeof(UserContext))]
    partial class UserContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ModelsLibrary.Gallery", b =>
                {
                    b.Property<int?>("Image_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Image_Id"));

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TravelerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Id")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Image_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("Gallery");
                });

            modelBuilder.Entity("ModelsLibrary.Travel_Agent", b =>
                {
                    b.Property<string>("Agent_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AgencyImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Agency_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Agent_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Contact_Number")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Agent_Id");

                    b.ToTable("Travel_Agent");
                });

            modelBuilder.Entity("ModelsLibrary.User", b =>
                {
                    b.Property<string>("User_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("HashKey")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Password")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("User_Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ModelsLibrary.Gallery", b =>
                {
                    b.HasOne("ModelsLibrary.User", "User")
                        .WithMany()
                        .HasForeignKey("User_Id");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}