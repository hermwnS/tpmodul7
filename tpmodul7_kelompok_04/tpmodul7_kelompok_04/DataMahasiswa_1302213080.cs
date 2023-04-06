using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_04
{
    public class DataMahasiswa_1302213080
    {
        public int nim { get; set; }
        public namaLengkap nama { get; set; }

        public string fakultas { get; set; }
        public DataMahasiswa_1302213080()
        {

        }
        public class namaLengkap
        {
            public string depan { get; set; }
            public string belakang { get; set; }

            public namaLengkap(string depan, string belakang)
            {
                this.depan = depan;
                this.belakang = belakang;
            }
            public namaLengkap()
            {

            }
        }

        public DataMahasiswa_1302213080(namaLengkap nama, int nim, string fakultas)
        {
            this.nama = nama;
            this.nim = nim;
            this.fakultas = fakultas;
        }

        

    }
}