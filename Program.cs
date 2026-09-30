//game
//genre : fighting
//Karakter : nama, kesehatan

using System;
namespace KerangkaGame
{
    class Karakter
    {
       // public string senjata;
        public int totalsenjata, power;

        //enkapsulasi 
        public string nama{get; private set;}
        public int kesehatan{get; private set;}
        public int senjata{get; private set;}

        //membuat konstruktor
        public Karakter(string nama, int kesehatan, int senjata)
        {
            this.nama = nama;
            this.kesehatan = kesehatan;
            this.senjata = senjata;
        }

        public void Serang(Karakter target) //membuat method menyerang
        {
            Console.WriteLine("==> Mulai Serangan");
            target.TerimaSerangan(this.senjata);
        }

        public void TerimaSerangan(int jumlahSerangan) //objek menerima serangan
        {
            kesehatan -= jumlahSerangan;
            Console.WriteLine($"{nama} diserang dengan {jumlahSerangan} . Sisa Kesehatan {kesehatan}");
        }

        public void HealDarah(int healing) // menambah darah
        {
            kesehatan += healing;
            Console.WriteLine($"{nama} Healing Sebanyak {healing} . Kesehatan Sekarang : {kesehatan}");
        }

       public void getData()
        {
            Console.WriteLine($"Karakter : {nama}");
            Console.WriteLine($"Kesehatan : {kesehatan}");
            Console.WriteLine($"senjata : {senjata}");
        }

public void CekStatus()
{
    if (kesehatan > 0)
    {
        Console.WriteLine($"{nama} masih hidup | Kesehatan: {kesehatan}");

        string pilihan = "";

        // Perulangan  pengguna memasukkan 'y' atau 'n'
        while (pilihan != "y" && pilihan != "n")
        {
            Console.Write("Apakah ingin menyelamatkan Karakter ini? (y/n): ");
            pilihan = Console.ReadLine()?.ToLower().Trim();

            if (pilihan != "y" && pilihan != "n")
            {
                Console.WriteLine("Input salah! Harap masukkan hanya 'y' atau 'n'.");
            }
        }

        if (pilihan == "y")
        {
            HealDarah(20);
        }
        else
        {
            Console.WriteLine($"{nama} tidak diselamatkan.");
        }
    }
    else
    {
        Console.WriteLine($"{nama} sudah mati!");
    }
}


    }


    class MainProgram
    {
        static void Main(string[] args)
        {

           Karakter player1 = new Karakter("Geo", 100, 10); //membuat objek
           Karakter Musuh = new Karakter("Ultramen", 100, 100);
            player1.getData(); 

        //intraksi
        // player1.Serang(Musuh);
        Musuh.Serang(player1);
        player1.HealDarah(10);
        player1.CekStatus();
        player1.getData();


     }
        }
}