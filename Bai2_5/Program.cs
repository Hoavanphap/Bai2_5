using System;
namespace Bai2_5
{
    class BaiTapVeNha
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Nhap vao do dai canh thu nhat:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao do dai canh thu hai:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao do dai canh thu ba:");
            c = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("{0}{1}{2}",a,b,c);
            if (a < (b + c) || b < (a + c) || c < (a + b))
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Day la tam gia deu");
                }
                else if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == b * b + a * a)
                {
                    Console.WriteLine("Day la tam giac vuong !");
                }
                else if (a == c || b == c || a == b)
                {
                    Console.WriteLine("Day la tam giac can");
                }
                
                else Console.WriteLine("Day la tam giac thuong");
            
            }
            else 
            { 
                Console.WriteLine("Do dai 3 canh vua nhap khong tao duoc thanh tam giac !");
            }

        }
        
    }
}