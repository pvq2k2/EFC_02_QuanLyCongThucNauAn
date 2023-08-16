using EFC_02_QuanLyCongThucNauAn.Helper;
using EFC_02_QuanLyCongThucNauAn.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_02_QuanLyCongThucNauAn.Models
{
    public class CongThuc
    {
        public int CongThucId { get; set; }
        [Required]
        public int SoLuong { get; set; }
        [Required]
        public string? DonViTinh { get; set; }
        public int MonAnId { get; set; }
        public MonAn? MonAn { get; set; }
        public int NguyenLieuId { get; set; }
        public NguyenLieu? NguyenLieu { get; set; }

        public void Input()
        {
            SoLuong = InputHelper.InputInt(CongThucNauAnRes.SoLuong, CongThucNauAnRes.ErrorSoLuong);
            DonViTinh = InputHelper.InputString(CongThucNauAnRes.DonViTinh);
            MonAnId = InputHelper.InputInt(CongThucNauAnRes.MonAnId, CongThucNauAnRes.ErrorMonAnId);
            NguyenLieuId = InputHelper.InputInt(CongThucNauAnRes.NguyenLieuId, CongThucNauAnRes.NguyenLieuId);
        }

        public void Input(int monAnId)
        {
            SoLuong = InputHelper.InputInt(CongThucNauAnRes.SoLuong, CongThucNauAnRes.ErrorSoLuong);
            DonViTinh = InputHelper.InputString(CongThucNauAnRes.DonViTinh);
            MonAnId = monAnId;
            NguyenLieuId = InputHelper.InputInt(CongThucNauAnRes.NguyenLieuId, CongThucNauAnRes.NguyenLieuId);
        }

        public void Output()
        {
            Console.Write($"{NguyenLieu.TenNguyenLieu} - {SoLuong} - {DonViTinh}\n");
        }
    }
}
