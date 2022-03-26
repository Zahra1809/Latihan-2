using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek dari class Mahasiswa
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            //mengeset nilai properties objek saya dan kamu
            saya.Nim = "12345";
            saya.Nama = "Jono";
            saya.Ipk = 3.95f;

            kamu.Nim = "12346";
            kamu.Nama = "Paijo";
            kamu.Ipk = 3.70f;

            //memanggil method registrasi dan isi krs
            saya.Registrasi();
            saya.IsiKrs();

            kamu.Registrasi();
            kamu.IsiKrs();

            Console.ReadKey();

        }
    }
}
