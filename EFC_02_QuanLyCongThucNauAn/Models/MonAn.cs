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
    public class MonAn
    {
        public int MonAnId { get; set; }
        [Required]
        public string? TenMon { get; set; }
        public string? GhiChu { get; set; }

        public int LoaiMonAnId { get; set; }
        public LoaiMonAn? LoaiMonAn { get; set; }
        public List<CongThuc>? ListCongThuc { get; set; }

        public void Input() {
            TenMon = InputHelper.InputString(CongThucNauAnRes.TenMon);
            GhiChu = InputHelper.InputString(CongThucNauAnRes.GhiChu);
            LoaiMonAnId = InputHelper.InputInt(CongThucNauAnRes.LoaiMonAnId, CongThucNauAnRes.ErrorLoaiMonAnId);
        }

        public void Output()
        {
            Console.WriteLine($"Ten mon: {TenMon}");
        }
    }
}
