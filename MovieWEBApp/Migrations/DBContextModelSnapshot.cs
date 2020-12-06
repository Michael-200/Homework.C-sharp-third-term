﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieWEBApp.Data;

namespace MovieWEBApp.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MovieStaff", b =>
                {
                    b.Property<string>("actorsStaffID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("isActorMovieID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("actorsStaffID", "isActorMovieID");

                    b.HasIndex("isActorMovieID");

                    b.ToTable("MovieStaff");
                });

            modelBuilder.Entity("MovieStaff1", b =>
                {
                    b.Property<string>("directorsStaffID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("isDirectorMovieID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("directorsStaffID", "isDirectorMovieID");

                    b.HasIndex("isDirectorMovieID");

                    b.ToTable("MovieStaff1");
                });

            modelBuilder.Entity("MovieTag", b =>
                {
                    b.Property<string>("moviesMovieID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("tagsTagID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("moviesMovieID", "tagsTagID");

                    b.HasIndex("tagsTagID");

                    b.ToTable("MovieTag");
                });

            modelBuilder.Entity("MovieWEBApp.Models.Movie", b =>
                {
                    b.Property<string>("MovieID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("averageRating")
                        .HasColumnType("real");

                    b.Property<string>("language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MovieWEBApp.Models.Staff", b =>
                {
                    b.Property<string>("StaffID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("fullName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StaffID");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("MovieWEBApp.Models.Tag", b =>
                {
                    b.Property<string>("TagID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagID");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("MovieStaff", b =>
                {
                    b.HasOne("MovieWEBApp.Models.Staff", null)
                        .WithMany()
                        .HasForeignKey("actorsStaffID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieWEBApp.Models.Movie", null)
                        .WithMany()
                        .HasForeignKey("isActorMovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieStaff1", b =>
                {
                    b.HasOne("MovieWEBApp.Models.Staff", null)
                        .WithMany()
                        .HasForeignKey("directorsStaffID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieWEBApp.Models.Movie", null)
                        .WithMany()
                        .HasForeignKey("isDirectorMovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieTag", b =>
                {
                    b.HasOne("MovieWEBApp.Models.Movie", null)
                        .WithMany()
                        .HasForeignKey("moviesMovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieWEBApp.Models.Tag", null)
                        .WithMany()
                        .HasForeignKey("tagsTagID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}