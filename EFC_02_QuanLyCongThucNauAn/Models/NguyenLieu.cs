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
    public class NguyenLieu
    {
        public int NguyenLieuId { get; set; }
        [Required]
        public string? TenNguyenLieu { get; set; }
        public List<CongThuc>? ListCongThuc { get; set; }

        public void Input()
        {
            TenNguyenLieu = InputHelper.InputString(CongThucNauAnRes.TenNguyenLieu);
        }

        public void Output()
        {
            Console.Write($"${TenNguyenLieu} ");
        }
    }
}
