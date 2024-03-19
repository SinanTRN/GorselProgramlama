using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta06
{
    public class Ogrenci
    {
        private string _ogrenciNo;
        private string _ogrenciAdi;
        private string _ogrenciSoyadi;
        private double _ogrenciVize;
        private double _ogrenciFinal;

        public string OgrenciNo { get { return _ogrenciNo; } set { _ogrenciNo = value; } }
        public string OgrenciAdi { get { return _ogrenciAdi; } set { _ogrenciAdi = value; } }
        public string OgrenciSoyadi { get { return _ogrenciSoyadi; } set { _ogrenciSoyadi = value; } }
        public double OgrenciVize { get { return _ogrenciVize; } set { _ogrenciVize = value; } }
        public double OgrenciFinal { get { return _ogrenciFinal; } set { _ogrenciFinal = value; } } 
        public double OgrenciOrtalama { get { return (0.4 * _ogrenciVize) + (0.6 * _ogrenciFinal); } }

        public Ogrenci() { }

        public void tabloyaEkle(DataTable tablo) 
        {
            tablo.Rows.Add(new object[]{
                                        this.OgrenciNo,
                                        this.OgrenciAdi,
                                        this.OgrenciSoyadi,
                                        this.OgrenciVize,
                                        this.OgrenciFinal,
                                        this.OgrenciOrtalama });
        }
    }
}
