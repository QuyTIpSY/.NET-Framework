using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp1.Model
{
    public partial class AppDBContext : DbContext
    {
        public AppDBContext()
            : base("name=AppDBContext")
        {
        }

        public virtual DbSet<KetQua> KetQua { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
