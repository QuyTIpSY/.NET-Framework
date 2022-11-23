using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AppQuanLySinhVien.Model
{
    public partial class AppDBContext : DbContext
    {
        public AppDBContext()
            : base("name=AppDBContext")
        {
        }

        public virtual DbSet<LopHoc> LopHoc { get; set; }
        public virtual DbSet<SinhVien> SinhVien { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LopHoc>()
                .HasMany(e => e.SinhVien)
                .WithOptional(e => e.LopHoc)
                .HasForeignKey(e => e.IDLopHoc);
        }
    }
}
