using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikdortkenNesneOlusturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen(13, 40);
            Console.WriteLine("Dikdörtgenin Alanı="+dikdortgen.AlanHesapla());
            Console.WriteLine("Dikdörtgenin Çevresi="+dikdortgen.CevreHesapla());
        }
    }
    class Dikdortgen
    {
        private int kisaKenar, uzunKenar;
        public Dikdortgen(int kisaKenar, int uzunKenar)
        {
            this.kisaKenar = kisaKenar;
            this.uzunKenar = uzunKenar;
        }
        public int AlanHesapla()
        {
            return kisaKenar * uzunKenar;
        }
        public int CevreHesapla()
        {
            return 2 * (kisaKenar + uzunKenar);
        }
    }

}
