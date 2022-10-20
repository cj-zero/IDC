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
    [DbConnectionStringAttribute("NewarePassport2DbContext", DbType = "MySql")]

    public partial class NewarePassport2DbContext : DbContext
    {
        public NewarePassport2DbContext(DbContextOptions<NewarePassport2DbContext> options)
           : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //当主键为联合主键时，需要把这里的内容拷贝到对应的位置
            // modelBuilder.Entity<Asset>().HasKey(c => new { c.Id });
        }
        public virtual DbSet<accounts> accounts { get; set; }
    }
}
