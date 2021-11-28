using System;
using System.Collections.Generic;
using Entities.Models;
using Entities.Models.Enums;
using Infrastracture.Interface;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.MsSql
{
    public class AppDbContext : DbContext, IDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Computer> Computer { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Guarantee> Guarantee { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Repair> Repair { get; set; }
        public DbSet<Shipper> Shipper { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<GoodsType> GoodsType { get; set; }
        public DbSet<ProductCode> ProductCode { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ConfigureModel(modelBuilder);
        }

        private void ConfigureModel(ModelBuilder modelBuilder)
        {

            //GoodsType
            EntityConfiguration.ConfigureGoodsType(modelBuilder);

            // ProductCode
            EntityConfiguration.ConfigureProductCode(modelBuilder);

            //Category
            EntityConfiguration.ConfigureCategory(modelBuilder);

            //Computer
            EntityConfiguration.ConfigureComputer(modelBuilder);

            //Customer
            EntityConfiguration.ConfigureCustomer(modelBuilder);

            //Guarantee
            EntityConfiguration.ConfigureGuarantee(modelBuilder);

            //Order
            EntityConfiguration.ConfigureOrder(modelBuilder);

            //OrderDetail
            EntityConfiguration.ConfigureOrderDetail(modelBuilder);

            //Payment
            EntityConfiguration.ConfigurePayment(modelBuilder);

            //Repair
            EntityConfiguration.ConfigureRepair(modelBuilder);

            //Shipper
            EntityConfiguration.ConfigureShipper(modelBuilder);

            //Supplier
            EntityConfiguration.ConfigureSupplier(modelBuilder);

            SeedData(modelBuilder);

        }

        private void SeedData(ModelBuilder modelBuilder)
        {
             modelBuilder.Entity<GoodsType>().HasData(new List<GoodsType>()
             {
                 new GoodsType(){GoodsTypeId = 1,Name = "Computer"},
                 new GoodsType(){GoodsTypeId = 2,Name = "Example2"},
                 new GoodsType(){GoodsTypeId = 3,Name = "Example3"}
             });

             modelBuilder.Entity<ProductCode>().HasData(new List<ProductCode>()
             {
                 new ProductCode(){GoodsTypeId = 1,Code = Guid.NewGuid(),ProductCodeId = 1},
                 new ProductCode(){GoodsTypeId = 1,Code = Guid.NewGuid(),ProductCodeId = 2},
                 new ProductCode(){GoodsTypeId = 1,Code = Guid.NewGuid(),ProductCodeId = 3},
                 new ProductCode(){GoodsTypeId = 1,Code = Guid.NewGuid(),ProductCodeId = 4},
             });

             modelBuilder.Entity<Category>().HasData(new List<Category>()
             {
                 new Category(){CategoryId = 1,Name = "IT",Active = true,Description = "Some words"},
                 new Category(){CategoryId = 2,Name = "Business",Active = false,Description = "Some words"},
                 new Category(){CategoryId = 3,Name = "Cartoon",Active = true,Description = "Some words"}
             });

            modelBuilder.Entity<Supplier>().HasData(new List<Supplier>()
            {
                new Supplier(){Adress = "Example Adress1",City = "Example City1",Country = "Example Country 1",
                    Email = "Email1@gmail.com1",Name = "SomeSupplier1",PaymentType =PaymentType.PayPal,Phone = "380500653293",SupplierId = 1},

                new Supplier(){Adress = "Example Adress2",City = "Example City2",Country = "Example Country 2",
                    Email = "Email2@gmail.com1",Name = "SomeSupplier2",PaymentType =PaymentType.Qiwi,Phone = "380500653293",SupplierId = 2},

                new Supplier(){Adress = "Example Adress3",City = "Example City3",Country = "Example Country 3",
                    Email = "Email3@gmail.com1",Name = "SomeSupplier3",PaymentType =PaymentType.PayPal,Phone = "380500653293",SupplierId = 3},
            });
            modelBuilder.Entity<Guarantee>().HasData(new List<Guarantee>()
            {
                new Guarantee(){GuaranteeId = 1,ExpireDate = DateTime.Now.AddMonths(6)},
                new Guarantee(){GuaranteeId = 2,ExpireDate = DateTime.Now.AddMonths(2)},
                new Guarantee(){GuaranteeId = 3,ExpireDate = DateTime.Now.AddMonths(3)},
            });

            modelBuilder.Entity<Computer>().HasData(new List<Computer>()
             {
                 new Computer(){CategoryId = 1,Color = "Red",ComputerId = 1,Description = "Some words",
                     Discount = 23,Firm = Firm.Samsung,GoodsTypeId = 1,ProductCodeId = 1,ProcessorName = "Some Processor 1", 
                     SupplierId = 1,VideoCardName = "Some VideoCard 1",GuaranteeId = 1},

                 new Computer(){CategoryId = 1,Color = "Blue",ComputerId = 2,Description = "Some words",
                     Discount = 0,Firm = Firm.Apple,GoodsTypeId = 1,ProductCodeId =2 ,ProcessorName = "Some Processor 2",
                     SupplierId = 2,VideoCardName = "Some VideoCard 2",GuaranteeId = 2},

                 new Computer(){CategoryId = 1,Color = "Green",ComputerId = 3,Description = "Some words",
                     Discount = 25,Firm = Firm.Apple,GoodsTypeId = 1,ProductCodeId =3,ProcessorName = "Some Processor 3",
                     SupplierId = 3,VideoCardName = "Some VideoCard 3",GuaranteeId = 1 },

                 new Computer(){CategoryId = 1,Color = "Yellow",ComputerId = 4,Description = "Some words",
                     Discount = 80,Firm = Firm.Samsung,GoodsTypeId = 1,ProductCodeId = 4,ProcessorName = "Some Processor 4",
                     SupplierId = 1,VideoCardName = "Some VideoCard 4",GuaranteeId = 3}
             });

             modelBuilder.Entity<Customer>().HasData(new List<Customer>()
             {
                 new Customer(){Adress = "Street1",BillingCountry = "Ukraine",BillingCity = "City1",City = "City1",CustomerId = 1,
                     DateEntered = DateTime.Now,Email = "Email1@gmail.com1",FirstName = "Example1",LastName = "LastExample1",Phone = "380500653293",
                     ShipCountry = "Country 1",ShipRegion = "Region 1"
                 },

                 new Customer(){Adress = "Street2",BillingCountry = "Ukraine",BillingCity = "City2",City = "City2",CustomerId = 2,
                     DateEntered = DateTime.Now,Email = "Email2@gmail.com1",FirstName = "Example2",LastName = "LastExample2",Phone = "380500653293",
                     ShipCountry = "Country 2",ShipRegion = "Region 2"
                 },

                 new Customer(){Adress = "Street3",BillingCountry = "Ukraine",BillingCity = "City3",City = "City3",CustomerId = 3,
                     DateEntered = DateTime.Now,Email = "Email3@gmail.com1",FirstName = "Example3",LastName = "LastExample3",Phone = "380500653293",
                     ShipCountry = "Country 3",ShipRegion = "Region 3"
                 }
             });

             

             modelBuilder.Entity<Payment>().HasData(new List<Payment>()
             {
                 new Payment(){Allowed = true,PaymentId = 1,PaymentType = PaymentType.Qiwi},
                 new Payment(){Allowed = true,PaymentId = 2,PaymentType = PaymentType.Qiwi},
                 new Payment(){Allowed = true,PaymentId = 3,PaymentType = PaymentType.Qiwi}
             });


             modelBuilder.Entity<Shipper>().HasData(new List<Shipper>()
             {
                 new Shipper(){ShipperId = 1,CompanyName = "Apple",Phone = "380500653293"},
                 new Shipper(){ShipperId = 2,CompanyName = "Samsung",Phone = "380500653293"},
             });

            modelBuilder.Entity<Order>().HasData(new List<Order>()
             {
                 new Order()
                 {
                     CustomerId = 1,DeliveryStatus = DeliveryStatus.ReadyToDeliver,OrderDate = DateTime.Now,
                     OrderId = 1,Paid = true,PaymentId = 1,PaymentDate = DateTime.Now,ShipDate = DateTime.Now,
                     ShipperId = 1,
                 },

                 new Order()
                 {
                     CustomerId = 2,DeliveryStatus = DeliveryStatus.Delivered,OrderDate = DateTime.Now,
                     OrderId = 2,Paid = true,PaymentId = 3,PaymentDate = DateTime.Now,ShipDate = DateTime.Now,
                     ShipperId = 2,
                 },

                 new Order()
                 {
                     CustomerId = 3,DeliveryStatus = DeliveryStatus.Received,OrderDate = DateTime.Now,
                     OrderId = 3,Paid = true,PaymentId = 2,PaymentDate = DateTime.Now,ShipDate = DateTime.Now,
                     ShipperId = 1,
                 }


             });

            
             modelBuilder.Entity<OrderDetail>().HasData(new List<OrderDetail>()
             {
                 new OrderDetail()
                 {
                     OrderId = 1,BillDate = DateTime.Now,Discount = 25,Price = 4005,ProductCodeId = 1,Quantity = 3,Total = 12015,
                     OrderDetailId = 1
                 },
                 new OrderDetail()
                 {
                     OrderId = 2,BillDate = DateTime.Now,Discount = 10,Price = 1000,ProductCodeId = 2,Quantity = 2,Total = 2000,
                     OrderDetailId = 2
                 },
                 new OrderDetail()
                 {
                 OrderId = 3,BillDate = DateTime.Now,Discount = 15,Price = 6000,ProductCodeId = 3,Quantity = 5,Total = 30000,
                 OrderDetailId = 3
             }
             });

             modelBuilder.Entity<Repair>().HasData(new List<Repair>()
             {
                 new Repair(){RepairId = 1,RepairStage = RepairStage.NotStarted,Price = 4000,HaveGuarantee = true,ProductCodeId = 1},
                 new Repair(){RepairId = 2,RepairStage = RepairStage.NotStarted,Price = 2000,HaveGuarantee = false,ProductCodeId = 2},
                 new Repair(){RepairId = 3,RepairStage = RepairStage.NotStarted,Price = 1000,HaveGuarantee = true,ProductCodeId = 3}
             });
        }
    }
}
