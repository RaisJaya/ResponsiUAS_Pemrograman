using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        HapusMahasiswa();
                        break;

                    case 3:
                        TampilMahasiswa();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih menu Aplikasi");
            Console.WriteLine("======================");
            Console.WriteLine("\n1. Tambah Mahasiswa");
            Console.WriteLine("2. Hapus Mahasiswa");
            Console.WriteLine("3. Tampilkan Mahasiswa");
            Console.WriteLine("4. Keluar");

            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection
            Mahasiswa mahasiswa = new Mahasiswa();
            Console.WriteLine("Tambah Data Mahasiswa");
            Console.WriteLine("---------------------");
            Console.Write("NIM                 : ");
            mahasiswa.NIM = Console.ReadLine();
            Console.Write("Nama                : ");
            mahasiswa.nama = Console.ReadLine();
            Console.Write("Jenis Kelamin [L/P] : ");
            mahasiswa.jenis = Console.ReadLine();
            Console.Write("IPK                 : ");
            mahasiswa.ipk = double.Parse(Console.ReadLine());
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus objek mahasiswa dari dalam collection
            int no = -1, hapus = -1;
            Console.WriteLine("Hapus Data Mahasiswa");
            Console.WriteLine("---------------------");
            Console.Write("NIM : ");
            string nim = Console.ReadLine();
            foreach(Mahasiswa mahasiswa in daftarMahasiswa)
            {
                no++;
                if (mahasiswa.NIM == nim)
                {
                    hapus = no;
                }
            }
            if (hapus != -1)
            {
                daftarMahasiswa.RemoveAt(hapus);
                Console.WriteLine("\nData Mahasiswa Berhasil dihapus");
            }
            else
            {
                Console.WriteLine("\nNim tidak ditemukan!");
            }
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection
            int no = 0;
            Console.WriteLine("Data Mahasiswa");
            Console.WriteLine("---------------------");
            foreach (Mahasiswa mahasiswa in daftarMahasiswa)
            {
                no++;
                string jenis;
                if(mahasiswa.jenis== "L")
                {
                    jenis = "Laki-Laki";
                }
                else if(mahasiswa.jenis == "P")
                {
                    jenis = "Perempuan";
                }
                else
                {
                    jenis = "Jenis Kelamin tidak terdefinisi";
                }
                Console.WriteLine("{0}.\t{1}\t{2} \t{3}\t{4}", no, mahasiswa.NIM, mahasiswa.nama, jenis, mahasiswa.ipk);
                if (no < 1)
                {
                    Console.WriteLine("Data Mahasiswa Kosong");
                }
            }
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
