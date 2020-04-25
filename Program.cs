using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Fungsi
{
    class Program
    {
        static void Main(string[] args)
        {
            //PENDAFTARAN ANGGOTA PERPUS
            Console.Write("NPM: "); string _npm = Console.ReadLine();
            Console.Write("Nama: "); string _nama = Console.ReadLine();
            Console.Write("Alamat: "); string _alamat = Console.ReadLine();
            Console.Write("URL Foto: "); string _url = Console.ReadLine();
            Console.Write("Kode: "); string _kode = Console.ReadLine();

            //Membuat Objek Anggota Perpus
            AnggotaPerpus anggota1 = new AnggotaPerpus(_npm, _nama, _alamat, _url, _kode);

            //Menampilkan Informasi
            anggota1.TampilkanDataAnggota();

            //Anggota Perpus Login
            Console.Write("Masukan Kode: "); string _kodemasukan = Console.ReadLine();

            //Melakukan Pengecekan Login
            bool hasillogin = anggota1.Login(_kodemasukan);
          
            if (hasillogin == true)
            {
                Console.WriteLine("SELAMAT DATANG");
            }
            else
            {
                Console.WriteLine("KODE SALAH");
            }

            #region Peminjaman Buku
            //Masukan Judul yang akan dipinjam
            Console.Write("Masukan Kode Anda"); string _kodeuntukpinjam = Console.ReadLine();

            //Akses Fungi Peminjaman
            if(anggota1.PinjamBuku(_kodeuntukpinjam) == true)
            {
                //Menginput judul Buku
                Console.Write("Masukan Judul Buku yang Dipinjam: "); string _judul = Console.ReadLine();
                anggota1.Bukuyangdipinjam = _judul;

            }
            else
            {
                //GAGAL
                Console.WriteLine("Kode Yang Anda Masukan Salah, Anda Tidak dapat Meminjam Buku");

                //Menampilkan Data Buku Pinjam
                anggota1.TampilkanDataPinjamanBuku();k
                 
            }
            #endregion
            Console.ReadKey();
        }
    }
}
