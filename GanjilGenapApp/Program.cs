namespace GanjilGenapApp
{
    internal class Program
    {
        static int Menu()
        {
            Console.WriteLine("Selamat datang di aplikasi cek angka ganjil/genap");
            Console.WriteLine("1. Cek Angka Ganjil/Genap");
            Console.WriteLine("2. Cek Angka Ganjil/Genap dengan limit ");
            Console.WriteLine("3. Keluar");
            Console.WriteLine("Pilih opsi menu : ");
            int menuOption;
            
            while (!int.TryParse(Console.ReadLine(), out menuOption))
            {
                Console.WriteLine("Input tidak valid. Masukkan angka yang benar.");
                Console.Write("Pilih opsi menu: ");
            }
            return menuOption;
        }

        static void CekAngkaGanjilGenap()
        {
            Console.WriteLine("Masukan sebuah angka : ");
            int angka;

            while (!int.TryParse(Console.ReadLine(), out angka))
            {
                Console.WriteLine("Input tidak valid. Masukkan angka yang benar.");
                Console.Write("Masukkan sebuah angka: ");
            }
            if (angka % 2 == 0)
            {
                Console.WriteLine(angka + " adalah Genap");
            }
            else if (angka % 2 != 0)
            {
                Console.WriteLine(angka + " adalah Ganjil");
            }
            else
            {
                Console.WriteLine("Inputan tidak valid");
            }
        }

        static void CekAngkaGanjilGenapLimit()
        {
            Console.WriteLine("Pilih angka Genap/Ganjil (1.Ganjil, 2.Genap) : ");
            int jenisAngka;

            while (!int.TryParse(Console.ReadLine(), out jenisAngka))
            {
                Console.WriteLine("Input tidak valid. Masukkan angka yang benar.");
                Console.WriteLine("Pilih angka Genap/Ganjil (1.Ganjil, 2.Genap) : ");
            }

            Console.WriteLine("Masukan limit angka : ");
            int batas;
            while (!int.TryParse(Console.ReadLine(), out batas))
            {
                Console.WriteLine("Input tidak valid. Masukkan angka yang benar.");
                Console.Write("Masukkan limit angka: ");
            }

            Console.WriteLine("Angka yang dipilih : ");

            if(jenisAngka == 1)
            {
                for(int i =1; i<=batas; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write(i+",");
                    }
                }
            }
            else if(jenisAngka == 2)
            {
                for(int i =1; i<=batas; i++)
                {
                    if(i% 2 == 0)
                    {
                        Console.Write(i+",");
                    }
                }
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid!");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int menuOption = 0;

            do
            {
                menuOption = Menu();
                
                switch(menuOption)
                {
                    case 1:
                        CekAngkaGanjilGenap();
                        break;
                    case 2:
                        CekAngkaGanjilGenapLimit();
                        break;
                    case 3:
                        Console.WriteLine("Anda memilih keluar, terima kasih");
                        return;
                    default:
                        Console.WriteLine("Inputan tidak valid");
                        break;

                }
                Console.WriteLine();
            } while (menuOption != 0);
        }
    }
}