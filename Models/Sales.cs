using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        { }

        public DbSet<Sales> Sales { get; set; }
    }

    public class Sales
    {
        public int id { get; set; }
        [Column(TypeName = "int")]
        public string ProductName { get; set; }
        [Column(TypeName = "nvarchar(200)")]

        public int ProductPrice { get; set; }
        [Column(TypeName = "int")]
        public string SaleItemName { get; set; }
        [Column(TypeName = "navarchar(200)")]
        public int SaleItemPrice { get; set; }
        [Column(TypeName = "int")]
        
        public string Quantity { get; set; }
        

    }
}