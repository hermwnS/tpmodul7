using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TP_MOD7_KPL_1302213091_TRIANI_PUTRI_MUMPUNI_AFF.DataMahasiswa1302213091
{
    public class DataMahasiswa1302213091
    {
        public int nim { get; set; }
        public Fullname nama { get; set; }

        public string fakultas { get; set; }
        public DataMahasiswa1302213091()
        {

        }
        public class Fullname
        {
            public string depan { get; set; }
            public string belakang { get; set; }

            public Fullname(string depan, string belakang)
            {
                this.depan = depan;
                this.belakang = belakang;
            }
            public Fullname()
            {
            }
        }
        public DataMahasiswa1302213091(Fullname name, int nim, string fakultas)
        {
            this.nama = name;
            this.nim = nim;
            this.fakultas = fakultas;
        }
    }
}
