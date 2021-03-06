// <auto-generated />
using Demo.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Demo.Migrations
{
    [DbContext(typeof(EntireContext))]
    [Migration("20210215171623_AddedProductReferences")]
    partial class AddedProductReferences
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Demo.Models.Authentication.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users","Authentication");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Key = "DFE27E47-2BBE-4C7D-B419-25AC7835881F",
                            UserName = "me"
                        },
                        new
                        {
                            Id = 2,
                            Key = "C8A9EFD2-F350-4437-ADA0-1CCB8C0DFA55",
                            UserName = "neighbor"
                        });
                });

            modelBuilder.Entity("Demo.Models.Content.FriendConnection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FriendKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Friends","Content");
                });

            modelBuilder.Entity("Demo.Models.Content.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products","Content");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Key = "5D1C71A1-2723-4FB6-B067-66F3BF5D0B60",
                            Name = "one",
                            OwnerKey = "DFE27E47-2BBE-4C7D-B419-25AC7835881F"
                        },
                        new
                        {
                            Id = 2,
                            Key = "910500A0-F873-4B12-BFE0-73648AD89929",
                            Name = "two",
                            OwnerKey = "DFE27E47-2BBE-4C7D-B419-25AC7835881F"
                        },
                        new
                        {
                            Id = 3,
                            Key = "2231D5B8-264D-4486-BCA3-E94D6FAA9F22",
                            Name = "three",
                            OwnerKey = "DFE27E47-2BBE-4C7D-B419-25AC7835881F"
                        },
                        new
                        {
                            Id = 4,
                            Key = "E306E9B6-D5E3-4714-B6BA-082C0F370F81",
                            Name = "square",
                            OwnerKey = "C8A9EFD2-F350-4437-ADA0-1CCB8C0DFA55"
                        },
                        new
                        {
                            Id = 5,
                            Key = "B2FF8A9E-A177-4929-A546-3BF014250394",
                            Name = "pointy",
                            OwnerKey = "C8A9EFD2-F350-4437-ADA0-1CCB8C0DFA55"
                        },
                        new
                        {
                            Id = 6,
                            Key = "B6D1FEF5-9DA2-4DCC-860C-BB07DDF7BF88",
                            Name = "round",
                            OwnerKey = "C8A9EFD2-F350-4437-ADA0-1CCB8C0DFA55"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
