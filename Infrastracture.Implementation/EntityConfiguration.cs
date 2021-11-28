using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.MsSql
{
    public static class EntityConfiguration
    {
        public static void ConfigureCategory(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasKey(s => s.CategoryId);
            modelBuilder.Entity<Category>().Property(s => s.Name).IsRequired();
            modelBuilder.Entity<Category>().Property(s => s.Description).IsRequired();
        }

        public static void ConfigureComputer(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Computer>().HasKey(s => s.ComputerId);
            modelBuilder.Entity<Computer>().Property(s => s.Description).IsRequired();
            modelBuilder.Entity<Computer>().Property(s => s.Color).IsRequired();
            modelBuilder.Entity<Computer>().Property(s => s.ProcessorName).IsRequired();
            modelBuilder.Entity<Computer>().Property(s => s.VideoCardName).IsRequired();
            modelBuilder.Entity<Computer>().Property(s => s.Firm).IsRequired();

            modelBuilder.Entity<Computer>().HasOne(s => s.Guarantee)
                .WithMany()
                .HasForeignKey(s => s.GuaranteeId);

            modelBuilder.Entity<Computer>().HasOne(s => s.Supplier)
                .WithMany()
                .HasForeignKey(s => s.SupplierId);

            modelBuilder.Entity<Computer>().HasOne(s => s.Category)
                .WithMany()
                .HasForeignKey(s => s.CategoryId);

            modelBuilder.Entity<Computer>().HasOne(s => s.GoodsType)
                .WithMany()
                .HasForeignKey(s => s.GoodsTypeId).OnDelete(DeleteBehavior.NoAction); 

            modelBuilder.Entity<Computer>().HasOne(s => s.ProductCode)
                .WithMany()
                .HasForeignKey(s => s.ProductCodeId).OnDelete(DeleteBehavior.NoAction);
        }
        public static void ConfigureCustomer(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasKey(s => s.CustomerId);
            modelBuilder.Entity<Customer>().Property(s => s.Adress).IsRequired();
            modelBuilder.Entity<Customer>().Property(s => s.BillingCity).IsRequired();
            modelBuilder.Entity<Customer>().Property(s => s.BillingCountry).IsRequired();
            modelBuilder.Entity<Customer>().Property(s => s.City).IsRequired();
            modelBuilder.Entity<Customer>().Property(s => s.DateEntered).IsRequired();
            modelBuilder.Entity<Customer>().Property(s => s.Email).IsRequired();
            modelBuilder.Entity<Customer>().Property(s => s.FirstName).IsRequired();
            modelBuilder.Entity<Customer>().Property(s => s.LastName).IsRequired();
            modelBuilder.Entity<Customer>().Property(s => s.Phone).HasMaxLength(12).IsRequired();
            modelBuilder.Entity<Customer>().Property(s => s.ShipCountry).IsRequired();
            modelBuilder.Entity<Customer>().Property(s => s.ShipRegion).IsRequired();
        }
        public static void ConfigureGuarantee(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Guarantee>().HasKey(s => s.GuaranteeId);
            modelBuilder.Entity<Guarantee>().Property(s => s.ExpireDate).IsRequired();
        }
        public static void ConfigureOrder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasKey(s => s.OrderId);
            modelBuilder.Entity<Order>().Property(s => s.DeliveryStatus).IsRequired();
            modelBuilder.Entity<Order>().Property(s => s.OrderDate).IsRequired();
            modelBuilder.Entity<Order>().Property(s => s.Paid).IsRequired();
            modelBuilder.Entity<Order>().Property(s => s.PaymentDate).IsRequired();

            modelBuilder.Entity<Order>().HasOne(s => s.Customer)
                .WithMany()
                .HasForeignKey(s => s.CustomerId);

            modelBuilder.Entity<Order>().HasOne(s => s.Payment)
                .WithMany()
                .HasForeignKey(s => s.PaymentId);

            modelBuilder.Entity<Order>().HasOne(s => s.Shipper)
                .WithMany()
                .HasForeignKey(s => s.ShipperId);
        }
        public static void ConfigureOrderDetail(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>().HasKey(s => s.OrderDetailId);
            modelBuilder.Entity<OrderDetail>().Property(s => s.BillDate).IsRequired();
            modelBuilder.Entity<OrderDetail>().Property(s => s.Price).IsRequired();
            modelBuilder.Entity<OrderDetail>().Property(s => s.Quantity).IsRequired();

            modelBuilder.Entity<OrderDetail>().HasOne(s => s.ProductCode)
                .WithMany()
                .HasForeignKey(s => s.ProductCodeId);

            modelBuilder.Entity<OrderDetail>().HasOne<Order>(s => s.Order)
                .WithOne()
                .HasForeignKey<OrderDetail>(s=>s.OrderId);

        }

        public static void ConfigurePayment(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Payment>().HasKey(s => s.PaymentId);
            modelBuilder.Entity<Payment>().Property(s => s.Allowed).IsRequired();
            modelBuilder.Entity<Payment>().Property(s => s.PaymentType).IsRequired();
        }

        public static void ConfigureRepair(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Repair>().HasKey(s => s.RepairId);
            modelBuilder.Entity<Repair>().Property(s => s.RepairStage).IsRequired();
            modelBuilder.Entity<Repair>().Property(s => s.Price).IsRequired();

            modelBuilder.Entity<Repair>().HasOne(s => s.ProductCode)
                .WithMany()
                .HasForeignKey(s => s.ProductCodeId);
        }

        public static void ConfigureShipper(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shipper>().HasKey(s => s.ShipperId);
            modelBuilder.Entity<Shipper>().Property(s => s.CompanyName).IsRequired();
            modelBuilder.Entity<Shipper>().Property(s => s.Phone).HasMaxLength(12).IsRequired();
        }

        public static void ConfigureSupplier(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supplier>().HasKey(s => s.SupplierId);
            modelBuilder.Entity<Supplier>().Property(s => s.Adress).IsRequired();
            modelBuilder.Entity<Supplier>().Property(s => s.Phone).HasMaxLength(12).IsRequired();
            modelBuilder.Entity<Supplier>().Property(s => s.City).IsRequired();
            modelBuilder.Entity<Supplier>().Property(s => s.Country).IsRequired();
            modelBuilder.Entity<Supplier>().Property(s => s.Email).IsRequired();
            modelBuilder.Entity<Supplier>().Property(s => s.Name).IsRequired();
            modelBuilder.Entity<Supplier>().Property(s => s.PaymentType).IsRequired();
        }

        public static void ConfigureGoodsType(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GoodsType>().HasKey(s => s.GoodsTypeId);
            modelBuilder.Entity<GoodsType>().Property(s => s.Name).IsRequired();
        }

        public static void ConfigureProductCode(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCode>().HasKey(s => s.ProductCodeId);
            modelBuilder.Entity<ProductCode>().Property(s => s.Code).IsRequired();
            modelBuilder.Entity<ProductCode>().Property(s => s.Code).IsRequired();

            modelBuilder.Entity<ProductCode>().HasOne(s => s.GoodsType)
                .WithMany()
                .HasForeignKey(s => s.GoodsTypeId);
        }

    }
}
