using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Fungsi
{
    class AnggotaPerpus : Mahasiswa
    {
        #region Atribut
        private string kode;
        private string BukuYangDiPinjam;
         
        #endregion
        #region Properties
        public string Kode
        {
            get
            {
                return this.kode;
            }
            set
            {
                this.kode = value;
            }
        }
        public string Bukuyangdipinjam
        {
            get
            {
                return this.BukuYangDiPinjam;
            }
            set
            {
                this.BukuYangDiPinjam = value;
            }
        }
        #endregion

        #region CONSTRUCTOR
        public AnggotaPerpus (string _npm, string _nama, string _alamat, string _urlfoto, string _kode)
        {
            //Informasi yang dimasukan untuk class Mahasiswa
            this.NPM = _npm;
            this.NAMA = _nama;
            this.ALAMAT = _alamat;
            this.URLFOTO = _urlfoto;

            //Informasi yang dimasukan untuk class AnggotaPerpus
            this.Kode = _kode;
        }
        #endregion
        #region Fungsi
        public bool Login(string KodeMasukan)
        {
            bool balikan = false;
            if(KodeMasukan == this.kode) balikan = true;

            return balikan;
        }

        public void TampilkanDataAnggota()
        {
            Console.WriteLine("INFORMASI ANGGOTA PERPUS");
            Console.WriteLine("NPM: " + this.NPM);
            Console.WriteLine("Nama: " + this.NAMA);
            Console.WriteLine("Alamat: " + this.ALAMAT);
            Console.WriteLine("URL Foto: " + this.URLFOTO);
            Console.WriteLine("Kode: " + this.Kode);

        }

        public bool PinjamBuku(string _kodemasukan)
        {
            bool result = false;
            if(Login(_kodemasukan))
            {
                result = true;
            }
            return result;
        }
        public void TampilkanDataPinjamanBuku()
        {
            TampilkanDataAnggota();
            Console.WriteLine("Judul Buku: " + this.BukuYangDiPinjam);
        }
        #endregion

    }
}
