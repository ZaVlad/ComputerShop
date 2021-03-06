// <auto-generated />
using System;
using DataAccess.MsSql;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.MsSql.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Active = true,
                            Description = "Some words",
                            Name = "IT"
                        },
                        new
                        {
                            CategoryId = 2,
                            Active = false,
                            Description = "Some words",
                            Name = "Business"
                        },
                        new
                        {
                            CategoryId = 3,
                            Active = true,
                            Description = "Some words",
                            Name = "Cartoon"
                        });
                });

            modelBuilder.Entity("Entities.Models.Computer", b =>
                {
                    b.Property<int>("ComputerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<int>("Firm")
                        .HasColumnType("int");

                    b.Property<int>("GoodsTypeId")
                        .HasColumnType("int");

                    b.Property<int>("GuaranteeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProcessorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductCodeId")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<string>("VideoCardName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ComputerId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("GoodsTypeId");

                    b.HasIndex("GuaranteeId");

                    b.HasIndex("ProductCodeId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Computer");

                    b.HasData(
                        new
                        {
                            ComputerId = 1,
                            CategoryId = 1,
                            Color = "Red",
                            Description = "Some words",
                            Discount = 23,
                            Firm = 0,
                            GoodsTypeId = 1,
                            GuaranteeId = 1,
                            ProcessorName = "Some Processor 1",
                            ProductCodeId = 1,
                            SupplierId = 1,
                            VideoCardName = "Some VideoCard 1"
                        },
                        new
                        {
                            ComputerId = 2,
                            CategoryId = 1,
                            Color = "Blue",
                            Description = "Some words",
                            Discount = 0,
                            Firm = 1,
                            GoodsTypeId = 1,
                            GuaranteeId = 2,
                            ProcessorName = "Some Processor 2",
                            ProductCodeId = 2,
                            SupplierId = 2,
                            VideoCardName = "Some VideoCard 2"
                        },
                        new
                        {
                            ComputerId = 3,
                            CategoryId = 1,
                            Color = "Green",
                            Description = "Some words",
                            Discount = 25,
                            Firm = 1,
                            GoodsTypeId = 1,
                            GuaranteeId = 1,
                            ProcessorName = "Some Processor 3",
                            ProductCodeId = 3,
                            SupplierId = 3,
                            VideoCardName = "Some VideoCard 3"
                        },
                        new
                        {
                            ComputerId = 4,
                            CategoryId = 1,
                            Color = "Yellow",
                            Description = "Some words",
                            Discount = 80,
                            Firm = 0,
                            GoodsTypeId = 1,
                            GuaranteeId = 3,
                            ProcessorName = "Some Processor 4",
                            ProductCodeId = 4,
                            SupplierId = 1,
                            VideoCardName = "Some VideoCard 4"
                        });
                });

            modelBuilder.Entity("Entities.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillingCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillingCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateEntered")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("ShipCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipRegion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Adress = "Street1",
                            BillingCity = "City1",
                            BillingCountry = "Ukraine",
                            City = "City1",
                            DateEntered = new DateTime(2021, 11, 27, 18, 28, 36, 414, DateTimeKind.Local).AddTicks(7806),
                            Email = "Email1@gmail.com1",
                            FirstName = "Example1",
                            LastName = "LastExample1",
                            Phone = "380500653293",
                            ShipCountry = "Country 1",
                            ShipRegion = "Region 1"
                        },
                        new
                        {
                            CustomerId = 2,
                            Adress = "Street2",
                            BillingCity = "City2",
                            BillingCountry = "Ukraine",
                            City = "City2",
                            DateEntered = new DateTime(2021, 11, 27, 18, 28, 36, 414, DateTimeKind.Local).AddTicks(9123),
                            Email = "Email2@gmail.com1",
                            FirstName = "Example2",
                            LastName = "LastExample2",
                            Phone = "380500653293",
                            ShipCountry = "Country 2",
                            ShipRegion = "Region 2"
                        },
                        new
                        {
                            CustomerId = 3,
                            Adress = "Street3",
                            BillingCity = "City3",
                            BillingCountry = "Ukraine",
                            City = "City3",
                            DateEntered = new DateTime(2021, 11, 27, 18, 28, 36, 414, DateTimeKind.Local).AddTicks(9134),
                            Email = "Email3@gmail.com1",
                            FirstName = "Example3",
                            LastName = "LastExample3",
                            Phone = "380500653293",
                            ShipCountry = "Country 3",
                            ShipRegion = "Region 3"
                        });
                });

            modelBuilder.Entity("Entities.Models.GoodsType", b =>
                {
                    b.Property<int>("GoodsTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GoodsTypeId");

                    b.ToTable("GoodsType");

                    b.HasData(
                        new
                        {
                            GoodsTypeId = 1,
                            Name = "Computer"
                        },
                        new
                        {
                            GoodsTypeId = 2,
                            Name = "Example2"
                        },
                        new
                        {
                            GoodsTypeId = 3,
                            Name = "Example3"
                        });
                });

            modelBuilder.Entity("Entities.Models.Guarantee", b =>
                {
                    b.Property<int>("GuaranteeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.HasKey("GuaranteeId");

                    b.ToTable("Guarantee");

                    b.HasData(
                        new
                        {
                            GuaranteeId = 1,
                            ExpireDate = new DateTime(2022, 5, 27, 18, 28, 36, 412, DateTimeKind.Local).AddTicks(4872)
                        },
                        new
                        {
                            GuaranteeId = 2,
                            ExpireDate = new DateTime(2022, 1, 27, 18, 28, 36, 414, DateTimeKind.Local).AddTicks(2945)
                        },
                        new
                        {
                            GuaranteeId = 3,
                            ExpireDate = new DateTime(2022, 2, 27, 18, 28, 36, 414, DateTimeKind.Local).AddTicks(2969)
                        });
                });

            modelBuilder.Entity("Entities.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("DeliveryStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Paid")
                        .HasColumnType("bit");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ShipDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ShipperId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PaymentId");

                    b.HasIndex("ShipperId");

                    b.ToTable("Order");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            CustomerId = 1,
                            DeliveryStatus = 3,
                            OrderDate = new DateTime(2021, 11, 27, 18, 28, 36, 415, DateTimeKind.Local).AddTicks(2306),
                            Paid = true,
                            PaymentDate = new DateTime(2021, 11, 27, 18, 28, 36, 415, DateTimeKind.Local).AddTicks(3060),
                            PaymentId = 1,
                            ShipDate = new DateTime(2021, 11, 27, 18, 28, 36, 415, DateTimeKind.Local).AddTicks(3274),
                            ShipperId = 1
                        },
                        new
                        {
                            OrderId = 2,
                            CustomerId = 2,
                            DeliveryStatus = 0,
                            OrderDate = new DateTime(2021, 11, 27, 18, 28, 36, 415, DateTimeKind.Local).AddTicks(3670),
                            Paid = true,
                            PaymentDate = new DateTime(2021, 11, 27, 18, 28, 36, 415, DateTimeKind.Local).AddTicks(3678),
                            PaymentId = 3,
                            ShipDate = new DateTime(2021, 11, 27, 18, 28, 36, 415, DateTimeKind.Local).AddTicks(3681),
                            ShipperId = 2
                        },
                        new
                        {
                            OrderId = 3,
                            CustomerId = 3,
                            DeliveryStatus = 1,
                            OrderDate = new DateTime(2021, 11, 27, 18, 28, 36, 415, DateTimeKind.Local).AddTicks(3683),
                            Paid = true,
                            PaymentDate = new DateTime(2021, 11, 27, 18, 28, 36, 415, DateTimeKind.Local).AddTicks(3685),
                            PaymentId = 2,
                            ShipDate = new DateTime(2021, 11, 27, 18, 28, 36, 415, DateTimeKind.Local).AddTicks(3687),
                            ShipperId = 1
                        });
                });

            modelBuilder.Entity("Entities.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BillDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductCodeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.HasIndex("ProductCodeId");

                    b.ToTable("OrderDetail");

                    b.HasData(
                        new
                        {
                            OrderDetailId = 1,
                            BillDate = new DateTime(2021, 11, 27, 18, 28, 36, 415, DateTimeKind.Local).AddTicks(4489),
                            Discount = 25,
                            OrderId = 1,
                            Price = 4005m,
                            ProductCodeId = 1,
                            Quantity = 3,
                            Total = 12015
                        },
                        new
                        {
                            OrderDetailId = 2,
                            BillDate = new DateTime(2021, 11, 27, 18, 28, 36, 415, DateTimeKind.Local).AddTicks(5938),
                            Discount = 10,
                            OrderId = 2,
                            Price = 1000m,
                            ProductCodeId = 2,
                            Quantity = 2,
                            Total = 2000
                        },
                        new
                        {
                            OrderDetailId = 3,
                            BillDate = new DateTime(2021, 11, 27, 18, 28, 36, 415, DateTimeKind.Local).AddTicks(5948),
                            Discount = 15,
                            OrderId = 3,
                            Price = 6000m,
                            ProductCodeId = 3,
                            Quantity = 5,
                            Total = 30000
                        });
                });

            modelBuilder.Entity("Entities.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Allowed")
                        .HasColumnType("bit");

                    b.Property<int>("PaymentType")
                        .HasColumnType("int");

                    b.HasKey("PaymentId");

                    b.ToTable("Payment");

                    b.HasData(
                        new
                        {
                            PaymentId = 1,
                            Allowed = true,
                            PaymentType = 2
                        },
                        new
                        {
                            PaymentId = 2,
                            Allowed = true,
                            PaymentType = 2
                        },
                        new
                        {
                            PaymentId = 3,
                            Allowed = true,
                            PaymentType = 2
                        });
                });

            modelBuilder.Entity("Entities.Models.ProductCode", b =>
                {
                    b.Property<int>("ProductCodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("Code")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("GoodsTypeId")
                        .HasColumnType("int");

                    b.HasKey("ProductCodeId");

                    b.HasIndex("GoodsTypeId");

                    b.ToTable("ProductCode");

                    b.HasData(
                        new
                        {
                            ProductCodeId = 1,
                            Code = new Guid("5f1f64d5-e778-402a-874b-8c33e650b325"),
                            GoodsTypeId = 1
                        },
                        new
                        {
                            ProductCodeId = 2,
                            Code = new Guid("9233e78f-820b-4d5f-97b1-68497b3c529d"),
                            GoodsTypeId = 1
                        },
                        new
                        {
                            ProductCodeId = 3,
                            Code = new Guid("ae8f5413-0f3d-4079-a533-c6688a7e1b0a"),
                            GoodsTypeId = 1
                        },
                        new
                        {
                            ProductCodeId = 4,
                            Code = new Guid("4a6f03b9-1dd0-4b47-892c-f0436f1abb3c"),
                            GoodsTypeId = 1
                        });
                });

            modelBuilder.Entity("Entities.Models.Repair", b =>
                {
                    b.Property<int>("RepairId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("HaveGuarantee")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductCodeId")
                        .HasColumnType("int");

                    b.Property<int>("RepairStage")
                        .HasColumnType("int");

                    b.HasKey("RepairId");

                    b.HasIndex("ProductCodeId");

                    b.ToTable("Repair");

                    b.HasData(
                        new
                        {
                            RepairId = 1,
                            HaveGuarantee = true,
                            Price = 4000m,
                            ProductCodeId = 1,
                            RepairStage = 0
                        },
                        new
                        {
                            RepairId = 2,
                            HaveGuarantee = false,
                            Price = 2000m,
                            ProductCodeId = 2,
                            RepairStage = 0
                        },
                        new
                        {
                            RepairId = 3,
                            HaveGuarantee = true,
                            Price = 1000m,
                            ProductCodeId = 3,
                            RepairStage = 0
                        });
                });

            modelBuilder.Entity("Entities.Models.Shipper", b =>
                {
                    b.Property<int>("ShipperId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("ShipperId");

                    b.ToTable("Shipper");

                    b.HasData(
                        new
                        {
                            ShipperId = 1,
                            CompanyName = "Apple",
                            Phone = "380500653293"
                        },
                        new
                        {
                            ShipperId = 2,
                            CompanyName = "Samsung",
                            Phone = "380500653293"
                        });
                });

            modelBuilder.Entity("Entities.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaymentType")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("SupplierId");

                    b.ToTable("Supplier");

                    b.HasData(
                        new
                        {
                            SupplierId = 1,
                            Adress = "Example Adress1",
                            City = "Example City1",
                            Country = "Example Country 1",
                            Email = "Email1@gmail.com1",
                            Name = "SomeSupplier1",
                            PaymentType = 1,
                            Phone = "380500653293"
                        },
                        new
                        {
                            SupplierId = 2,
                            Adress = "Example Adress2",
                            City = "Example City2",
                            Country = "Example Country 2",
                            Email = "Email2@gmail.com1",
                            Name = "SomeSupplier2",
                            PaymentType = 2,
                            Phone = "380500653293"
                        },
                        new
                        {
                            SupplierId = 3,
                            Adress = "Example Adress3",
                            City = "Example City3",
                            Country = "Example Country 3",
                            Email = "Email3@gmail.com1",
                            Name = "SomeSupplier3",
                            PaymentType = 1,
                            Phone = "380500653293"
                        });
                });

            modelBuilder.Entity("Entities.Models.Computer", b =>
                {
                    b.HasOne("Entities.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.GoodsType", "GoodsType")
                        .WithMany()
                        .HasForeignKey("GoodsTypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Entities.Models.Guarantee", "Guarantee")
                        .WithMany()
                        .HasForeignKey("GuaranteeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.ProductCode", "ProductCode")
                        .WithMany()
                        .HasForeignKey("ProductCodeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Entities.Models.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("GoodsType");

                    b.Navigation("Guarantee");

                    b.Navigation("ProductCode");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Entities.Models.Order", b =>
                {
                    b.HasOne("Entities.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Payment", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Shipper", "Shipper")
                        .WithMany()
                        .HasForeignKey("ShipperId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Payment");

                    b.Navigation("Shipper");
                });

            modelBuilder.Entity("Entities.Models.OrderDetail", b =>
                {
                    b.HasOne("Entities.Models.Order", "Order")
                        .WithOne()
                        .HasForeignKey("Entities.Models.OrderDetail", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.ProductCode", "ProductCode")
                        .WithMany()
                        .HasForeignKey("ProductCodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("ProductCode");
                });

            modelBuilder.Entity("Entities.Models.ProductCode", b =>
                {
                    b.HasOne("Entities.Models.GoodsType", "GoodsType")
                        .WithMany()
                        .HasForeignKey("GoodsTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GoodsType");
                });

            modelBuilder.Entity("Entities.Models.Repair", b =>
                {
                    b.HasOne("Entities.Models.ProductCode", "ProductCode")
                        .WithMany()
                        .HasForeignKey("ProductCodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCode");
                });
#pragma warning restore 612, 618
        }
    }
}
