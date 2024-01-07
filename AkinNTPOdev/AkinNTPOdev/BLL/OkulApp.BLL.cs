using AkinNTPOdev.OdevModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkinNTPOdev.BLL
{
    public class OgrenciBL
    {
        private Helper hlp;

        public OgrenciBL()
        {
            hlp = new Helper();
        }

        public bool OgrenciEkle(Ogrenci ogr)
        {
            SqlParameter[] parameters = {
            new SqlParameter("@Ad", ogr.Ad),
            new SqlParameter("@Soyad", ogr.Soyad),
            new SqlParameter("@Numara", ogr.Numara)
        };

            return hlp.ExecuteNonQuery("INSERT INTO tblOgrenciler (Ad, Soyad, Numara) VALUES (@Ad, @Soyad, @Numara)", parameters) > 0;
        }

        public List<Ogrenci> OgrenciListele()
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();

            using (SqlDataReader dr = hlp.ExecuteReader("SELECT OgrenciId, Ad, Soyad, Numara FROM tblOgrenciler"))
            {
                while (dr.Read())
                {
                    Ogrenci ogr = new Ogrenci
                    {
                        OgrenciId = Convert.ToInt32(dr["OgrenciId"]),
                        Ad = dr["Ad"].ToString(),
                        Soyad = dr["Soyad"].ToString(),
                        Numara = dr["Numara"].ToString()
                    };
                    ogrenciler.Add(ogr);
                }
            }



            return ogrenciler;
        }
        public Ogrenci OgrenciBul(string numara)
        {
            SqlParameter[] parameters = { new SqlParameter("@Numara", numara) };

            using (SqlDataReader dr = hlp.ExecuteReader("SELECT OgrenciID, Ad, Soyad, Numara FROM tblOgrenciler WHERE Numara=@Numara", parameters))
            {
                if (dr.Read())
                {
                    return new Ogrenci
                    {
                        OgrenciId = Convert.ToInt32(dr["OgrenciID"]),
                        Ad = dr["Ad"].ToString(),
                        Soyad = dr["Soyad"].ToString(),
                        Numara = dr["Numara"].ToString()
                    };
                }
            }

            return null;
        }
    }


}
    
// OgretmenBL sınıfı
public class OgretmenBL
{
    private Helper hlp;

    public OgretmenBL()
    {
        hlp = new Helper();
    }

    public bool OgretmenEkle(Ogretmen ogrt)
    {
        SqlParameter[] parameters = {
            new SqlParameter("@Ad", ogrt.Ad),
            new SqlParameter("@Soyad", ogrt.Soyad),
            new SqlParameter("@TC", ogrt.TC)
        };

        return hlp.ExecuteNonQuery("INSERT INTO tblOgretmenler (Ad, Soyad, TC) VALUES (@Ad, @Soyad, @TC)", parameters) > 0;
    }

    public List<Ogretmen> OgretmenListele()
    {
        List<Ogretmen> ogretmenler = new List<Ogretmen>();

        using (SqlDataReader dr = hlp.ExecuteReader("SELECT OgretmenId, Ad, Soyad, TC FROM tblOgretmenler"))
        {
            while (dr.Read())
            {
                Ogretmen ogrt = new Ogretmen
                {
                    OgretmenId = Convert.ToInt32(dr["OgretmenId"]),
                    Ad = dr["Ad"].ToString(),
                    Soyad = dr["Soyad"].ToString(),
                    TC = dr["TC"].ToString()
                };
                ogretmenler.Add(ogrt);
            }
        }

        return ogretmenler;
    }
    public Ogretmen OgretmenBul(string tc)
    {
        SqlParameter[] parameters = { new SqlParameter("@TC", tc) };

        using (SqlDataReader dr = hlp.ExecuteReader("SELECT OgretmenID, Ad, Soyad, TC FROM tblOgretmenler WHERE TC=@TC", parameters))
        {
            if (dr.Read())
            {
                return new Ogretmen
                {
                    OgretmenId = Convert.ToInt32(dr["OgretmenID"]),
                    Ad = dr["Ad"].ToString(),
                    Soyad = dr["Soyad"].ToString(),
                    TC = dr["TC"].ToString()
                };
            }
        }

        return null;
    }
}
