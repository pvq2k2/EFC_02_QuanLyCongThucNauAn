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
    public class LoaiMonAn
    {
        public int LoaiMonAnId { get; set; }
        [Required]
        public string? TenLoai { get; set; }

        public List<MonAn>? ListMonAn { get; set; }
        public void Input() {
            TenLoai = InputHelper.InputString(CongThucNauAnRes.TenLoai);
        }
        public void Output() {
            Console.WriteLine($"Ten loai: ${TenLoai}");
        }

    }
}
