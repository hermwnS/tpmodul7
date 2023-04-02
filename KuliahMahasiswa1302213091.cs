using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MOD7_KPL_1302213091_TRIANI_PUTRI_MUMPUNI_AFF.KuliahMahasiswa1302213091
{
    internal class KuliahMahasiswa1302213091
    {
        public List<MataKuliah1302213091> courses { get; set; }

        public KuliahMahasiswa1302213091(List<MataKuliah1302213091> matkul)
        {
            this.courses = matkul;
        }
        public KuliahMahasiswa1302213091()
        {
        }
    }
    public class MataKuliah1302213091
    {
        public string code { get; set; }
        public string name { get; set; }

        public MataKuliah1302213091(string kode, string nama)
        {
            code = kode;
            name = nama;
        }
        public MataKuliah1302213091() { }

    }
}
