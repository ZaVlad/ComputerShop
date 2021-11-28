using System;
using System.Threading;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastracture.Interface
{
    public interface IDbContext
    {
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
       public Task<int> SaveChangesAsync(CancellationToken token = default);
    }
}
