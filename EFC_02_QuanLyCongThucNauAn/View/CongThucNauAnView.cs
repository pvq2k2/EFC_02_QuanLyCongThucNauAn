using EFC_02_QuanLyCongThucNauAn.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_02_QuanLyCongThucNauAn.View
{
    public class CongThucNauAnView
    {
        CongThucNauAnController controller;

        public CongThucNauAnView()
        {
            controller = new CongThucNauAnController();
        }

        public void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("----------Menu----------");
                Console.WriteLine("1. Hien thi danh sach cong thuc nau an");
                Console.WriteLine("2. Tim kiem mon an co nguyen lieu la Hanh hoac Toi");
                Console.WriteLine("3. Them mon an va kem theo cong thuc");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon chuc nang: ");
                char c = Console.ReadKey().KeyChar;
                Console.WriteLine();
                controller.ThucThi(c);
            }
        }
    }
}
