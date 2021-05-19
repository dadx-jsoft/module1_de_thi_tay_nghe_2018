using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nNhap so thu nhat: ");
            int so1 = int.Parse(Console.ReadLine());
            Console.Write("\nNhap so thu hai: ");
            int so2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nMAIN MENU: ");
            Console.WriteLine("\n1. Cong ");
            Console.WriteLine("\n2. Tru ");
            Console.WriteLine("\n3. Nhan ");
            Console.WriteLine("\n4. Chia ");
            Console.WriteLine("\n5. Thoat ");
            Console.Write("\nNhap vao lua chon cua ban: ");

            string luaChon = Console.ReadLine();

            switch (luaChon)
            {
                case "1":
                    Console.WriteLine("\n{0} + {1} = {2}", so1, so2, Cong2So(so1, so2));
                    break;

                case "2":
                    Console.WriteLine("\n{0} - {1} = {2}", so1, so2, Tru2So(so1, so2));
                    break;

                case "3":
                    Nhan2So(so1, so2);
                    break;

                case "4":
                    Console.WriteLine("\n{0} : {1} = {2}", so1, so2, (double)so1 / so2);
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("\nBan nhap sai lua chon, moi nhap lai");
                    break;
            }

            Console.ReadLine();
        }

        private static void Nhan2So(int so1, int so2)
        {
            Console.WriteLine("\n{0} x {1} = {2}", so1, so2, so1 * so2);
        }

        private static int Tru2So(int so1, int so2)
        {
            return so1 - so2;
        }

        //phương thức cộng 2 số nguyên
        static private int Cong2So(int soThuNhat, int soThuHai)
        {
            return soThuNhat + soThuHai;
        }
    }
}
