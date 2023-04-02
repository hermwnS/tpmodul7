using System;
using System.Text.Json;
using TP_MOD7_KPL_1302213091_TRIANI_PUTRI_MUMPUNI_AFF.DataMahasiswa1302213091;
using TP_MOD7_KPL_1302213091_TRIANI_PUTRI_MUMPUNI_AFF.KuliahMahasiswa1302213091;

internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa1302213091 data = new DataMahasiswa1302213091();

        String jsonString = File.ReadAllText("C:\\Users\\Asus\\Documents\\SEMESTER4\\KONSTRUKSI PERANGKAT LUNAK\\TP_MOD7_KPL_1302213091_TRIANI PUTRI MUMPUNI_AFF\\TP_MOD7_KPL_1302213091_TRIANI PUTRI MUMPUNI_AFF\\DataMahasiswa1302213091\\tp7_1_1302213091.json");

        DataMahasiswa1302213091 Mahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302213091>(jsonString);
        Console.WriteLine("Nama " + Mahasiswa.nama.depan + " " + Mahasiswa.nama.belakang + " dengan nim " + Mahasiswa.nim + " dari fakultas " + Mahasiswa.fakultas);

        String jsonString2 = File.ReadAllText("C:\\Users\\Asus\\Documents\\SEMESTER4\\KONSTRUKSI PERANGKAT LUNAK\\TP_MOD7_KPL_1302213091_TRIANI PUTRI MUMPUNI_AFF\\TP_MOD7_KPL_1302213091_TRIANI PUTRI MUMPUNI_AFF\\KuliahMahasiswa1302213091\\tp7_2_1302213091.json");

        KuliahMahasiswa1302213091 college = JsonSerializer.Deserialize<KuliahMahasiswa1302213091>(jsonString2);
        if (college.courses != null)
        {
            int i = 1;
            foreach (MataKuliah1302213091 matkul in college.courses)
            {
                Console.WriteLine("Mata Kuliah " + (i) + " " + matkul.code + " - " + matkul.name);
                i++;
            }
        }
        else
        {
            Console.WriteLine("EMPTY");
        }
    }
}