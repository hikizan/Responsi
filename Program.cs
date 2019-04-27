using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsi
{
    class Program
    {
        static void Main(string[] args)
        {
            karyawan kry = new karyawan();

            kry.nama = "chandra";
            kry.nik = "2354";
            kry.gaji = 1000000;

            kry.nama2 = "fauzan";
            kry.nik2 = "1234";
            kry.gaji2 = 2000000;

            kry.infoGaji();
            Console.WriteLine();
            kry.kenaikanGaji();
            Console.WriteLine();
            Console.ReadKey();
            
        }
    }
}
