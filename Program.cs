using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihanclassdanobject
{
    class Program
    {
        static void Main(string[] args)
        {
            mahasiswa saya = new mahasiswa();
            mahasiswa kamu = new mahasiswa();

            saya.Nim = "19.11.2272";
            saya.Nama = "jono";
            saya.Ipk = 3.95f;

            kamu.Nim = "19.11.2276";
            kamu.Nama = "Paijo";
            kamu.Ipk = 3.70f;

            saya.Registrasi();
            saya.IsiKrs();

            kamu.Registrasi();
            kamu.IsiKrs();

            Console.ReadKey();


        }
    }
}