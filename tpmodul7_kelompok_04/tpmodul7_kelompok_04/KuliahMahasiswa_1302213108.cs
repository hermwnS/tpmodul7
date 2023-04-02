using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_04
{
    internal class KuliahMahasiswa_1302213108
    {
        public List<MataKuliah_1302213108> courses { get; set; }

        public KuliahMahasiswa_1302213108(List<MataKuliah_1302213108> matkul)
        {
            this.courses = matkul;
        }
        public KuliahMahasiswa_1302213108()
        {
        }
    }
    public class MataKuliah_1302213108
    {
        public string code { get; set; }
        public string name { get; set; }

        public MataKuliah_1302213108(string kode, string nama)
        {
            code = kode;
            name = nama;
        }
        public MataKuliah_1302213108() { }

    }
}