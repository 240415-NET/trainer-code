﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrackMyStuff.API.Data;

#nullable disable

namespace TrackMyStuff.API.Migrations
{
    [DbContext(typeof(TrackMyStuffContext))]
    partial class TrackMyStuffContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TrackMyStuff.API.Models.Item", b =>
                {
                    b.Property<Guid>("itemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("originalCost")
                        .HasColumnType("float");

                    b.Property<DateTime>("purchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("userId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("itemId");

                    b.HasIndex("userId");

                    b.ToTable("Items", (string)null);

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("TrackMyStuff.API.Models.User", b =>
                {
                    b.Property<Guid>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userId");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("TrackMyStuff.API.Models.Document", b =>
                {
                    b.HasBaseType("TrackMyStuff.API.Models.Item");

                    b.Property<string>("documentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("expirationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("userId1")
                        .HasColumnType("uniqueidentifier");

                    b.HasIndex("userId1");

                    b.ToTable("Documents", (string)null);
                });

            modelBuilder.Entity("TrackMyStuff.API.Models.Pet", b =>
                {
                    b.HasBaseType("TrackMyStuff.API.Models.Item");

                    b.Property<int?>("age")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("species")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("userId1")
                        .HasColumnType("uniqueidentifier");

                    b.HasIndex("userId1");

                    b.ToTable("Pets", (string)null);
                });

            modelBuilder.Entity("TrackMyStuff.API.Models.Item", b =>
                {
                    b.HasOne("TrackMyStuff.API.Models.User", "user")
                        .WithMany("items")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("TrackMyStuff.API.Models.Document", b =>
                {
                    b.HasOne("TrackMyStuff.API.Models.User", null)
                        .WithMany("documents")
                        .HasForeignKey("userId1");
                });

            modelBuilder.Entity("TrackMyStuff.API.Models.Pet", b =>
                {
                    b.HasOne("TrackMyStuff.API.Models.User", null)
                        .WithMany("pets")
                        .HasForeignKey("userId1");
                });

            modelBuilder.Entity("TrackMyStuff.API.Models.User", b =>
                {
                    b.Navigation("documents");

                    b.Navigation("items");

                    b.Navigation("pets");
                });
#pragma warning restore 612, 618
        }
    }
}
