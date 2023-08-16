using EFC_02_QuanLyCongThucNauAn.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_02_QuanLyCongThucNauAn.IServices
{
    public interface ICongThucNauAnSevices
    {
        public LogType HienThiDanhSach();
        public LogType TimKiemMonAn();
        public LogType ThemMonAnVaCongThuc();
    }
}
