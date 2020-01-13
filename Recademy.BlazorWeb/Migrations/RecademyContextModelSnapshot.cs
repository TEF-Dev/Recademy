﻿// <auto-generated />

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Recademy.BlazorWeb.Context;

namespace Recademy.BlazorWeb.Migrations
{
    [DbContext(typeof(RecademyContext))]
    partial class RecademyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Recademy.Models.ProjectInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GithubLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("ProjectInfos");
                });

            modelBuilder.Entity("Recademy.Models.ProjectSkill", b =>
                {
                    b.Property<string>("SkillName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("SkillName", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectSkills");
                });

            modelBuilder.Entity("Recademy.Models.ReviewRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("ReviewRequests");
                });

            modelBuilder.Entity("Recademy.Models.ReviewResponse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReviewRequestId")
                        .HasColumnType("int");

                    b.Property<int>("ReviewerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReviewRequestId")
                        .IsUnique();

                    b.ToTable("ReviewResponses");
                });

            modelBuilder.Entity("Recademy.Models.Skill", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Name");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Recademy.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GithubLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Recademy.Models.UserSkill", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("SkillName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "SkillName");

                    b.HasIndex("SkillName");

                    b.ToTable("UserSkills");
                });

            modelBuilder.Entity("Recademy.Models.ProjectInfo", b =>
                {
                    b.HasOne("Recademy.Models.User", "User")
                        .WithMany("ProjectInfos")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Recademy.Models.ProjectSkill", b =>
                {
                    b.HasOne("Recademy.Models.ProjectInfo", "ProjectInfo")
                        .WithMany("Skills")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Recademy.Models.Skill", "Skill")
                        .WithMany("ProjectSkills")
                        .HasForeignKey("SkillName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Recademy.Models.ReviewRequest", b =>
                {
                    b.HasOne("Recademy.Models.ProjectInfo", "ProjectInfo")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Recademy.Models.User", "User")
                        .WithMany("ReviewRequests")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Recademy.Models.ReviewResponse", b =>
                {
                    b.HasOne("Recademy.Models.ReviewRequest", "ReviewRequest")
                        .WithOne("ReviewResponse")
                        .HasForeignKey("Recademy.Models.ReviewResponse", "ReviewRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Recademy.Models.UserSkill", b =>
                {
                    b.HasOne("Recademy.Models.Skill", "Skill")
                        .WithMany("UserSkills")
                        .HasForeignKey("SkillName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Recademy.Models.User", "User")
                        .WithMany("UserSkills")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
