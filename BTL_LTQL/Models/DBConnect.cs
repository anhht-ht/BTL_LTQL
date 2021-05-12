using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BTL_LTQL.Models
{
    public partial class DBConnect : DbContext
    {
        public DBConnect()
            : base("name=DBConnect")
        {
        }
        public virtual DbSet<Nhanvien>Nhanviens { get; set; }
        public virtual DbSet<ChucVu>ChucVus { get; set; }
        public virtual DbSet<Phongban>Phongbans { get; set; }
        public virtual DbSet<KTKL>ktkls { get; set; }
        public virtual DbSet<DuAn>Duans { get; set; }
        public virtual DbSet<TrinhDo>Trinhdos { get; set; }
        public virtual DbSet<CongTac>Congtacs { get; set; }
        public virtual DbSet<HopDong>Hopdongs { get; set; }
        public virtual DbSet<Account>Accounts { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
