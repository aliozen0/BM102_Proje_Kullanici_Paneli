using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucuncuApp
{
    public class Yemek1
    {
        public string YemekAdi { get; set; }
        public decimal Ucret { get; set; }
        public byte[] FotoData { get; set; }
        public int YemekID { get; set; }

        public Yemek1(string yemekAdi, decimal ucret, byte[] fotoData, int yemekID)
        {
            YemekAdi = yemekAdi;
            Ucret = ucret;
            FotoData = fotoData;
            YemekID = yemekID;
        }
    }
}
