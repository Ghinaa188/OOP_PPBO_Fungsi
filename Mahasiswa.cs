using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Fungsi
{
    class Mahasiswa
    {
        private string npm;
        private string nama;
        private string alamat;
        private string urlFoto;

        public string NPM
        {
            get
            {
                return this.npm;
            }
            set
            {
                this.npm = value;
            }
        }
        public string NAMA
        {
            get
            {
                return this.nama;
            }
            set
            {
                this.nama = value;
            }
        }
        public string ALAMAT
        {
            get
            {
                return this.alamat;
            }
            set
            {
                this.alamat = value;
            }
        }
        public string URLFOTO
        {
            get
            {
                return this.urlFoto;
            }
            set
            {
                this.urlFoto = value;
            }
        }
    }
}
