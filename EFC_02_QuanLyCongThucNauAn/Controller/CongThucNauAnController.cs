using EFC_02_QuanLyCongThucNauAn.Helper;
using EFC_02_QuanLyCongThucNauAn.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_02_QuanLyCongThucNauAn.Controller
{
    public class CongThucNauAnController
    {
        CongThucNauAnSevices nauAnSevices;

        public CongThucNauAnController()
        {
            nauAnSevices = new CongThucNauAnSevices();
        }

        public void ThucThi(char c)
        {
            switch (c)
            {
                case '1':
                    LogHelper.CongThucNauAnLog(nauAnSevices.HienThiDanhSach());
                    break;
                case '2':
                    LogHelper.CongThucNauAnLog(nauAnSevices.TimKiemMonAn());
                    break;
                case '3':
                    LogHelper.CongThucNauAnLog(nauAnSevices.ThemMonAnVaCongThuc());
                    break;
                case '4':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Khong co chuc nang nay, vui long nhap lai!");
                    break;
            }
            Console.WriteLine("\nNhan phim bat ky de tiep tuc!");
            Console.ReadKey();
        }
    }
}
