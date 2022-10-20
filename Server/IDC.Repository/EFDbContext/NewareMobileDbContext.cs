using IDC.Repository.Core;
using IDC.Repository.Entities.Assets;
using IDC.Repository.Entities.Nwcali;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IDC.Repository.EFDbContext
{
    [DbConnectionStringAttribute("NewareMobileDbContext", DbType = "MySql")]
    public partial class NewareMobileDbContext : DbContext
    {

        public NewareMobileDbContext(DbContextOptions<NewareMobileDbContext> options)
            : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //当主键为联合主键时，需要把这里的内容拷贝到对应的位置
            // modelBuilder.Entity<Asset>().HasKey(c => new { c.Id });
        }
        public virtual DbSet<LaboratoryAsset> LaboratoryAsset { get; set; }
        public virtual DbSet<LaboratoryAssetCategory> LaboratoryAssetCategory { get; set; }
        public virtual DbSet<LaboratoryAssetInspect> LaboratoryAssetInspect { get; set; }
        public virtual DbSet<LaboratoryAssetOperation> LaboratoryAssetOperation { get; set; }

        public virtual DbSet<PortfolioAssets> PortfolioAssets { get; set; }
        public virtual DbSet<PortfolioAssetsMap> PortfolioAssetsMap { get; set; }

        public virtual DbSet<assets> assets { get; set; }
        public virtual DbSet<assets_category> assets_category { get; set; }
        public virtual DbSet<assets_book> assets_book { get; set; }
        public virtual DbSet<assets_return_log> assets_return_log { get; set; }

        public virtual DbSet<assets_room_map> assets_room_map { get; set; }
        public virtual DbSet<room> room { get; set; }
        public virtual DbSet<user> user { get; set; }
        public virtual DbSet<assets_admin_user> assets_admin_user { get; set; }
        public virtual DbSet<assets_maintain_user> assets_maintain_user { get; set; }
        public virtual DbSet<assets_spec_val> assets_spec_val { get; set; }
        public virtual DbSet<assets_incubator_map> assets_incubator_map { get; set; }
        public virtual DbSet<assets_positioner_bind> assets_positioner_bind { get; set; }
        public virtual DbSet<sys_log> sys_log { get; set; }
        public virtual DbSet<assets_cate_spec_map> assets_cate_spec_map { get; set; }
        public virtual DbSet<assets_spec> assets_spec { get; set; }
        public virtual DbSet<sys_config> sys_config { get; set; }
        public virtual DbSet<sys_app_push> sys_app_push { get; set; }
        public virtual DbSet<app_notice> app_notice { get; set; }

    }
}
