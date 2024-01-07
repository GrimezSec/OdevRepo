using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkinNTPOdev.OdevModel
{
    public class Ogrenci
    {
        public int OgrenciId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Numara { get; set; }
            
    }

    public class Ogretmen
    {
        public int OgretmenId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get;set; }
        public string TC {  get; set; }
        
        }
}
