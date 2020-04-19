using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using EFCORECLI.MODEL.Schema;
namespace EEFCORECLI.MODEL
{
    public class DataContext : DbContext
    {
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<HocPhan> HocPhans { get; set; }
        public DbSet<LopHocPhan> LopHocPhans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Data Source=DESKTOP-OVLNOKF;Initial Catalog=FE_Core;User Id=sa;Password=123456;MultipleActiveResultSets=True;");
    }
}