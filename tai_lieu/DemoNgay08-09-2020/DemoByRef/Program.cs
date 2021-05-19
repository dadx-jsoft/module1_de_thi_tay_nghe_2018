using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoByRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int tong, hieu, tich, so1;
            double thuong;
            Console.Write("\nNhap so thu nhat: ");
            try
            {
                so1 = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ban phai nhap so thu nhat la so!");
                Console.ReadLine();
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ban phai nhap so thu nhat trong khoang -2 ty den +2ty");
                Console.ReadLine();
                return;
            }
            Console.Write("\nNhap so thu hai: ");
            int so2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nMAIN MENU: ");
            Console.WriteLine("\n1. Cong ");
            Console.WriteLine("\n2. Tru ");
            Console.WriteLine("\n3. Nhan ");
            Console.WriteLine("\n4. Chia ");
            Console.WriteLine("\n5. Thoat ");
            //gọi phương thức để tính toán 2 số
            TinhToan2So(so1, so2, out tong, out hieu, out tich, out thuong);
            Console.Write("\nNhap vao lua chon cua ban: ");
            string luaChon = Console.ReadLine();

            switch (luaChon)
            {
                case "1":
                    Console.WriteLine("\n{0} + {1} = {2}", so1, so2,tong);
                    break;

                case "2":
                    Console.WriteLine("\n{0} - {1} = {2}", so1, so2, hieu);
                    break;

                case "3":
                    Console.WriteLine("\n{0} x {1} = {2}", so1, so2, tich);
                    break;

                case "4":
                    Console.WriteLine("\n{0} : {1} = {2}", so1, so2, thuong);
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("\nBan nhap sai lua chon, moi nhap lai");
                    break;
            }

            Console.ReadLine();
        }

        static private void TinhToan2So(int so1, int so2,
            out int tong, out int hieu, out int tich, out double thuong)
        {
            tong = so1 + so2;
            hieu = so1 - so2;
            tich = so1 * so2;
            thuong =(double) so1 / so2;
        }

    }
}
