
using NetSatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Context
{
    public class NetSatisContext:DbContext
    {
        public DbSet<Case> Cases { get; set; }
        public DbSet<CaseMovement> CaseMovements { get; set; }
        public DbSet<Current> Currents { get; set; }
        public DbSet<Definition> Definitions { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<StockMovement> StockMovements { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
    }
}
