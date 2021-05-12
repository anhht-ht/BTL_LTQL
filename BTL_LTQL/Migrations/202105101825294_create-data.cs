namespace BTL_LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdata : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Congtacs",
                c => new
                    {
                        Ma_nv = c.String(nullable: false, maxLength: 128),
                        Congviec = c.String(),
                        Ngaybatdau = c.String(),
                        Ngayketthuc = c.String(),
                        Noilamviec = c.String(),
                    })
                .PrimaryKey(t => t.Ma_nv);
            
            CreateTable(
                "dbo.ChucVus",
                c => new
                    {
                        Ma_chucvu = c.String(nullable: false, maxLength: 128),
                        Ten_chucvu = c.String(),
                    })
                .PrimaryKey(t => t.Ma_chucvu);
            
            CreateTable(
                "dbo.Duans",
                c => new
                    {
                        Ma_duan = c.String(nullable: false, maxLength: 128),
                        TenDuan = c.String(),
                        Ngaybatdau = c.String(),
                        Ngayketthuc = c.String(),
                        SoLuong = c.String(),
                        Dongia = c.String(),
                        Chietkhau = c.String(),
                        Ma_nv = c.String(),
                    })
                .PrimaryKey(t => t.Ma_duan);
            
            CreateTable(
                "dbo.Hopdongs",
                c => new
                    {
                        Ma_hd = c.String(nullable: false, maxLength: 128),
                        Ma_nv = c.String(),
                        Ten_nv = c.String(),
                        Ngayky_hd = c.String(),
                        Han_hd = c.String(),
                    })
                .PrimaryKey(t => t.Ma_hd);
            
            CreateTable(
                "dbo.ktkls",
                c => new
                    {
                        Ma_nv = c.String(nullable: false, maxLength: 128),
                        Ktkl = c.String(),
                        Lydo = c.String(),
                    })
                .PrimaryKey(t => t.Ma_nv);
            
            CreateTable(
                "dbo.Nhanviens",
                c => new
                    {
                        Ma_nv = c.String(nullable: false, maxLength: 128),
                        Ma_chucvu = c.String(),
                        Ten_nv = c.String(),
                        Sodienthoai = c.String(),
                        Ngaysinh = c.String(),
                        Gioitinh = c.String(),
                        Quequan = c.String(),
                        Dantoc = c.String(),
                        Phongban = c.String(),
                        Trinhdo = c.String(),
                    })
                .PrimaryKey(t => t.Ma_nv);
            
            CreateTable(
                "dbo.Phongbans",
                c => new
                    {
                        Ma_phong = c.String(nullable: false, maxLength: 128),
                        Ten_phong = c.String(),
                    })
                .PrimaryKey(t => t.Ma_phong);
            
            CreateTable(
                "dbo.Trinhdos",
                c => new
                    {
                        Ma_trinhdo = c.String(nullable: false, maxLength: 128),
                        Ten_trinhdo = c.String(),
                    })
                .PrimaryKey(t => t.Ma_trinhdo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Trinhdos");
            DropTable("dbo.Phongbans");
            DropTable("dbo.Nhanviens");
            DropTable("dbo.ktkls");
            DropTable("dbo.Hopdongs");
            DropTable("dbo.Duans");
            DropTable("dbo.ChucVus");
            DropTable("dbo.Congtacs");
        }
    }
}
