
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasClassDanObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mobil mobil = new Mobil();

            mobil.Warna = "Merah";
            mobil.JumlahPintu = 2;
            mobil.Merek = "Toyota";
            mobil.Model = "Supra";
            mobil.TahunKeluaran = 1997;
            
            int kecepatan =  mobil.Kecepatan = 180;
            string suara = mobil.Suara = "Tiiinn";

            mobil.Gas(kecepatan);
            mobil.Klakson(suara);
            mobil.TampilkanInfo();

            Console.ReadKey();
        }
    }
}