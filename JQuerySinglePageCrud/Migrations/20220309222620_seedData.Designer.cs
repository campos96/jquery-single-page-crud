﻿// <auto-generated />
using JQuerySinglePageCrud.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JQuerySinglePageCrud.Migrations
{
    [DbContext(typeof(JQuerySinglePageCrudContext))]
    [Migration("20220309222620_seedData")]
    partial class seedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JQuerySinglePageCrud.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ID");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Active = true,
                            Email = "johndoe@mail.com",
                            FirstName = "John",
                            LastName = "Doe",
                            Username = "johndoe"
                        },
                        new
                        {
                            ID = 2,
                            Active = true,
                            Email = "janedoe@mail.com",
                            FirstName = "Jane",
                            LastName = "Doe",
                            Username = "janedoe"
                        },
                        new
                        {
                            ID = 3,
                            Active = true,
                            Email = "johnroe@mail.com",
                            FirstName = "John",
                            LastName = "Roe",
                            Username = "johnroe"
                        },
                        new
                        {
                            ID = 4,
                            Active = true,
                            Email = "richardroe@mail.com",
                            FirstName = "Richard",
                            LastName = "Roe",
                            Username = "richardroe"
                        },
                        new
                        {
                            ID = 5,
                            Active = true,
                            Email = "janeroe@mail.com",
                            FirstName = "Jane",
                            LastName = "Roe",
                            Username = "janeroe"
                        },
                        new
                        {
                            ID = 6,
                            Active = true,
                            Email = "babydoe@mail.com",
                            FirstName = "Baby",
                            LastName = "Doe",
                            Username = "babydoe"
                        },
                        new
                        {
                            ID = 7,
                            Active = true,
                            Email = "janedoe@mail.com",
                            FirstName = "Janie",
                            LastName = "Doe",
                            Username = "janiedoe"
                        },
                        new
                        {
                            ID = 8,
                            Active = true,
                            Email = "jhonnydoe@mail.com",
                            FirstName = "Jhonny",
                            LastName = "Doe",
                            Username = "jhonnydoe"
                        },
                        new
                        {
                            ID = 9,
                            Active = true,
                            Email = "joebloggs@mail.com",
                            FirstName = "Joe",
                            LastName = "Bloggs",
                            Username = "joebloggs"
                        },
                        new
                        {
                            ID = 10,
                            Active = true,
                            Email = "janesmith@mail.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            Username = "janesmith"
                        },
                        new
                        {
                            ID = 11,
                            Active = true,
                            Email = "joeschmoe@mail.com",
                            FirstName = "Joe",
                            LastName = "Schmoe",
                            Username = "joeschmoe"
                        },
                        new
                        {
                            ID = 12,
                            Active = true,
                            Email = "tomdoe@mail.com",
                            FirstName = "Tom",
                            LastName = "Doe",
                            Username = "tomdoe"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
