using EFC_02_QuanLyCongThucNauAn.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_02_QuanLyCongThucNauAn.Helper
{
    public enum LogType
    {
        Thoat, KhongCoMonAn, DanhSachTrong, ThanhCong
    }
    internal class LogHelper
    {
        public static void CongThucNauAnLog(LogType log)
        {
            switch (log)
            {
                case LogType.ThanhCong:
                    Console.WriteLine(CongThucNauAnRes.LogThanhCong);
                    break;
                case LogType.DanhSachTrong:
                    Console.WriteLine(CongThucNauAnRes.LogDanhSachTrong);
                    break;
                case LogType.KhongCoMonAn:
                    Console.WriteLine(CongThucNauAnRes.LogKhongTimThayMonAn);
                    break;
            }
        }
    }
}
