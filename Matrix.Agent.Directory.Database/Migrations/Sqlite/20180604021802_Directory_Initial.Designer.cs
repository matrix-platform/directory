﻿// <auto-generated />
using Matrix.Agent.Directory.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Matrix.Agent.Directory.Database.Migrations.Sqlite
{
    [DbContext(typeof(SqliteDirectoryDbContext))]
    [Migration("20180604021802_Directory_Initial")]
    partial class Directory_Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("Matrix.Agent.Directory.Database.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("Application");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(1024);

                    b.Property<string>("Phone")
                        .HasMaxLength(16);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Matrix.Agent.Directory.Database.Entities.UserGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("Application");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1024);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("UserGroups");
                });

            modelBuilder.Entity("Matrix.Agent.Directory.Database.Entities.UserGroupMapping", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("GroupId");

                    b.HasKey("UserId", "GroupId");

                    b.HasIndex("GroupId");

                    b.ToTable("UserGroupMapping");
                });

            modelBuilder.Entity("Matrix.Agent.Directory.Database.Entities.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("Application");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1024);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Matrix.Agent.Directory.Database.Entities.UserRoleMapping", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoleMapping");
                });

            modelBuilder.Entity("Matrix.Agent.Directory.Database.Entities.UserGroupMapping", b =>
                {
                    b.HasOne("Matrix.Agent.Directory.Database.Entities.UserGroup", "Group")
                        .WithMany("UserGroupMappings")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Matrix.Agent.Directory.Database.Entities.User", "User")
                        .WithMany("UserGroupMappings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Matrix.Agent.Directory.Database.Entities.UserRoleMapping", b =>
                {
                    b.HasOne("Matrix.Agent.Directory.Database.Entities.UserRole", "Role")
                        .WithMany("UserRoleMappings")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Matrix.Agent.Directory.Database.Entities.User", "User")
                        .WithMany("UserRoleMappings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
