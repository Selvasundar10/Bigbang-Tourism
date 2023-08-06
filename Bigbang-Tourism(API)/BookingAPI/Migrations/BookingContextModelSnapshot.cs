﻿// <auto-generated />
using System;
using BookingAPI.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookingAPI.Migrations
{
    [DbContext(typeof(BookingContext))]
    partial class BookingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ModelsLibrary.Booking_Details", b =>
                {
                    b.Property<int>("Booking_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Booking_Id"));

                    b.Property<decimal?>("BillingPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HotelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Hotel_Id")
                        .HasColumnType("int");

                    b.Property<int>("No_of_persons")
                        .HasColumnType("int");

                    b.Property<int?>("TourPackageId")
                        .HasColumnType("int");

                    b.Property<int?>("Tour_Id")
                        .HasColumnType("int");

                    b.Property<string>("TransportMode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TravelAgencyId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Travel_AgentAgent_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TravelerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Id")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Booking_Id");

                    b.HasIndex("Hotel_Id");

                    b.HasIndex("Tour_Id");

                    b.HasIndex("Travel_AgentAgent_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("ModelsLibrary.Feedbacks", b =>
                {
                    b.Property<int>("Feedback_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Feedback_Id"));

                    b.Property<string>("FeedbackMessage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("TravelerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Id")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Feedback_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("ModelsLibrary.Hotel", b =>
                {
                    b.Property<int>("Hotel_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Hotel_Id"));

                    b.Property<string>("Contact_Details")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Hotel_Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Hotel_Id");

                    b.ToTable("Hotel");
                });

            modelBuilder.Entity("ModelsLibrary.Tour", b =>
                {
                    b.Property<int>("Tour_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Tour_Id"));

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Hotel_Id")
                        .HasColumnType("int");

                    b.Property<string>("Itinerary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Spot_Id")
                        .HasColumnType("int");

                    b.Property<string>("TourDescription")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<int?>("TourSpotSpot_Id")
                        .HasColumnType("int");

                    b.Property<string>("Tour_Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tour_Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tour_Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("TravelAgencyId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Travel_AgentAgent_Id")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Tour_Id");

                    b.HasIndex("Hotel_Id");

                    b.HasIndex("TourSpotSpot_Id");

                    b.HasIndex("Travel_AgentAgent_Id");

                    b.ToTable("Tour");
                });

            modelBuilder.Entity("ModelsLibrary.TourSpot", b =>
                {
                    b.Property<int>("Spot_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Spot_Id"));

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Specialty")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("SpotName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Spot_Id");

                    b.ToTable("TourSpot");
                });

            modelBuilder.Entity("ModelsLibrary.Travel_Agent", b =>
                {
                    b.Property<string>("Agent_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AgencyImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Agency_Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Agent_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Contact_Number")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
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

            modelBuilder.Entity("ModelsLibrary.Booking_Details", b =>
                {
                    b.HasOne("ModelsLibrary.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("Hotel_Id");

                    b.HasOne("ModelsLibrary.Tour", "Tour")
                        .WithMany()
                        .HasForeignKey("Tour_Id");

                    b.HasOne("ModelsLibrary.Travel_Agent", "Travel_Agent")
                        .WithMany()
                        .HasForeignKey("Travel_AgentAgent_Id");

                    b.HasOne("ModelsLibrary.User", "User")
                        .WithMany()
                        .HasForeignKey("User_Id");

                    b.Navigation("Hotel");

                    b.Navigation("Tour");

                    b.Navigation("Travel_Agent");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ModelsLibrary.Feedbacks", b =>
                {
                    b.HasOne("ModelsLibrary.User", "User")
                        .WithMany()
                        .HasForeignKey("User_Id");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ModelsLibrary.Tour", b =>
                {
                    b.HasOne("ModelsLibrary.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("Hotel_Id");

                    b.HasOne("ModelsLibrary.TourSpot", "TourSpot")
                        .WithMany()
                        .HasForeignKey("TourSpotSpot_Id");

                    b.HasOne("ModelsLibrary.Travel_Agent", "Travel_Agent")
                        .WithMany()
                        .HasForeignKey("Travel_AgentAgent_Id");

                    b.Navigation("Hotel");

                    b.Navigation("TourSpot");

                    b.Navigation("Travel_Agent");
                });
#pragma warning restore 612, 618
        }
    }
}