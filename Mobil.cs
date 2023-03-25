using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasClassDanObject
{
    internal class Mobil
    {
        public string Warna { get; set; }
        public string Merek { get; set; }
        public string Model { get; set; }
        public int TahunKeluaran { get; set; }
        public int JumlahPintu { get; set; }
        public int Kecepatan { get; set; }
        public string Suara { get; set; }

        public void Gas(int a)
        {
            Console.WriteLine("Mobil {0} berjalan dengan kecepatan {1}\n", Model, a);
        }
        public void Klakson(string a)
        {
            Console.WriteLine("{0}\n", Suara);
        }

        public void TampilkanInfo()
        {
            Console.WriteLine("Mobil saya berwarna {0}, merek {1} model {2} keluaran tahun {3}" + "\ndengan jumlah pintu sebanyak {4}.", Warna, Merek, Model, TahunKeluaran, JumlahPintu);
        }
       
    }
}
