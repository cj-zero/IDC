using IDC.Repository.Core;
using IDC.Repository.Entities.Nwcali;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.EFDbContext
{
    [DbConnectionStringAttribute("Nsap4NwcaliDbContext", DbType = "MySql")]
    public partial class Nsap4NwcaliDbContext : DbContext
    {

        public Nsap4NwcaliDbContext(DbContextOptions<Nsap4NwcaliDbContext> options)
            : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //当主键为联合主键时，需要把这里的内容拷贝到对应的位置
           // modelBuilder.Entity<Asset>().HasKey(c => new { c.Id });
            //modelBuilder.Entity<NwcaliBaseInfo>().Ignore(c => c.FlowInstance);
        }
        //public virtual DbSet<LaboratoryAsset> Asset { get; set; }
        //public virtual DbSet<LaboratoryAssetCategory> AssetCategory { get; set; }
        //public virtual DbSet<LaboratoryAssetInspect> AssetInspect { get; set; }
        //public virtual DbSet<LaboratoryAssetOperation> AssetOperation { get; set; }



        //public virtual DbSet<assets> assets { get; set; }
        

    }
}
