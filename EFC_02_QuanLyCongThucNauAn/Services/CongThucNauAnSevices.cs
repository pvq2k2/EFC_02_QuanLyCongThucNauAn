using EFC_02_QuanLyCongThucNauAn.Helper;
using EFC_02_QuanLyCongThucNauAn.IServices;
using EFC_02_QuanLyCongThucNauAn.Models;
using EFC_02_QuanLyCongThucNauAn.Resources;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_02_QuanLyCongThucNauAn.Services
{
    public class CongThucNauAnSevices : ICongThucNauAnSevices
    {
        private readonly AppDbContext dbContext;

        public CongThucNauAnSevices()
        {
            dbContext = new AppDbContext();
        }
        public LogType HienThiDanhSach()
        {
            List<MonAn> ListMonAn = dbContext.MonAn.Include(x => x.ListCongThuc).ThenInclude(x => x.NguyenLieu).ToList();

            if (ListMonAn.Count == 0) return LogType.DanhSachTrong;
            ListMonAn.ForEach(x =>
            {
                x.Output();
                x.ListCongThuc.ForEach(x => x.Output());
            });
            return LogType.ThanhCong;
        }

        public LogType ThemMonAnVaCongThuc()
        {
            MonAn monAn = new MonAn();
            monAn.Input();

            var FindLoaiMonAn = dbContext.LoaiMonAn.FirstOrDefault(x => x.LoaiMonAnId == monAn.LoaiMonAnId);
            if (FindLoaiMonAn == null)
            {
                Console.WriteLine("Khong tim thay loai mon an! Vui long nhap moi loai mon an");
                LoaiMonAn loaiMonAn = new LoaiMonAn();
                loaiMonAn.Input();
                monAn.LoaiMonAnId = loaiMonAn.LoaiMonAnId;
                dbContext.MonAn.Add(monAn);
                dbContext.SaveChanges();
                dbContext.LoaiMonAn.Add(loaiMonAn); 
                dbContext.SaveChanges();
            } else
            {
                dbContext.MonAn.Add(monAn);
                dbContext.SaveChanges();
            }

            int soLuong = InputHelper.InputInt("Nhap so luong cong thuc: ", "Vui long nhap vao la so!");
            var listCongThuc = new List<CongThuc>();
            for (int i = 0; i < soLuong; i++)
            {
                int id = InputHelper.InputInt("Nhap id cong thuc: ", "Vui long nhap vao la so!");
                var FindCongThuc = dbContext.CongThuc.FirstOrDefault(x => x.CongThucId == id);
                if (FindCongThuc == null)
                {
                    Console.WriteLine("Khong tim thay cong thuc! Vui long nhap moi cong thuc");
                    CongThuc congThuc = new CongThuc();
                    congThuc.Input(monAn.MonAnId);
                    var FindNguyenLieu = dbContext.NguyenLieu.FirstOrDefault(x => x.NguyenLieuId == congThuc.NguyenLieuId);
                    if (FindNguyenLieu == null)
                    {
                        Console.WriteLine("Khong tim thay nguyen lieu! Vui long nhap moi nguyen lieu");
                        NguyenLieu nguyenLieu = new NguyenLieu();
                        nguyenLieu.Input();
                        dbContext.NguyenLieu.Add(nguyenLieu);
                        dbContext.SaveChanges();
                        congThuc.NguyenLieuId = nguyenLieu.NguyenLieuId;
                    }
                }
                else
                {
                    listCongThuc.Add(FindCongThuc);
                }
            }
            dbContext.CongThuc.AddRange(listCongThuc);
            dbContext.SaveChanges();
            return LogType.ThanhCong;
        }

        public LogType TimKiemMonAn()
        {
            var FindMonAn = dbContext.MonAn
                .Where(m => m.ListCongThuc.Any(ct => dbContext.NguyenLieu.Any(nl => nl.NguyenLieuId == ct.NguyenLieuId && (nl.TenNguyenLieu.Contains("Hanh") || nl.TenNguyenLieu.Contains("Toi")))))
                .ToList();
            Console.WriteLine("Cac mon an chua nguyen lieu Hanh hoac Toi:");

            if (FindMonAn.Count() == 0) return LogType.KhongCoMonAn;
            foreach (var monAn in FindMonAn)
            {
                Console.WriteLine("MonAn [{0}]", monAn.TenMon);
            }
            return LogType.ThanhCong;
        }
    }
}
