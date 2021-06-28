using Infrastructure;
using Microsoft.EntityFrameworkCore;
using OpenAuth.Repository.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAuth.Repository
{
    [ConnectionString("NsapBaseDbContext")]
    public class NsapBaseDbContext : DbContext
    {
        public NsapBaseDbContext(DbContextOptions<NsapBaseDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //当主键为联合主键时，需要把这里的内容拷贝到对应的位置
            modelBuilder.Entity<sbo_user>().HasKey(o => new { o.sbo_id, o.user_id });
            modelBuilder.Entity<base_user>().HasKey(o => o.user_id);
            modelBuilder.Entity<base_dep>().HasKey(o => o.dep_id);
            modelBuilder.Entity<base_post>().HasKey(o => o.post_id);
            modelBuilder.Entity<base_user_detail>().HasKey(o => o.user_id);
        }
        public virtual DbSet<base_user> BaseUsers { get; set; }
        public virtual DbSet<sbo_user> SboUsers { get; set; }
        public virtual DbSet<base_dep> base_deps { get; set; }
        public virtual DbSet<base_post> base_posts { get; set; }
        public virtual DbSet<base_user_detail> base_user_details { get; set; }
    }
}
