using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_04
{
    public class DataMahasiswa_1302210096
    {
        public int nim { get; set; }
        public Fullname nama { get; set; }

        public string fakultas { get; set; }
        public DataMahasiswa_1302210096()
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

        public DataMahasiswa_1302210096(Fullname name, int nim, string fakultas)
        {
            this.nama = name;
            this.nim = nim;
            this.fakultas = fakultas;
        }

        

    }
}