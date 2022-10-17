using IDC.Repository.Core;
using IDC.Repository.Entities.Material;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.EFDbContext
{
    [DbConnectionStringAttribute("Nsap4MaterialDbContext", DbType = "MySql")]
    internal class Nsap4MaterialDbContext : DbContext
    {
        public Nsap4MaterialDbContext(DbContextOptions<Nsap4MaterialDbContext> options)
         : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //当主键为联合主键时，需要把这里的内容拷贝到对应的位置
            // modelBuilder.Entity<Asset>().HasKey(c => new { c.Id });
        }

        public virtual DbSet<snguidmap> snguidmap { get; set; }
    }
}
