using System;

namespace QUIZ09092019
{
    class BangunRuang
    {
        //Volume Balok
        public void volumebalok()
        {
            Console.WriteLine("    ");

            int panjang, lebar, tinggi;

            Console.WriteLine("Menghitung Volume Balok");
           Console.WriteLine("-----------------------");

            Console.Write("Masukkan Nilai Panjang : ");
            panjang = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Nilai Lebar : ");
            lebar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Nilai Tinggi : ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            int volume;

            volume = panjang * lebar * tinggi;

            Console.Write("Volume Balok Adalah : "+volume);
            Console.WriteLine("    ");
        }


        //Volume Kubus

        public void volumekubus()
        {
            Console.WriteLine("    ");
            int sisi;

            Console.WriteLine("Menghitung Volume Kubus");
            Console.WriteLine("-----------------------");

            Console.Write("Masukkan Nilai Sisi : ");
            sisi = Convert.ToInt32(Console.ReadLine());

            int volume;

            volume = sisi * sisi * sisi;

            Console.Write("Volume Kubus Adalah : "+volume);
            Console.WriteLine("    ");
        }
    }
}