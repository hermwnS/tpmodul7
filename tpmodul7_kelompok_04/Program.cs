
﻿
using System.Text.Json;

internal class Program
{

    private static void Main(string[] args)
    {
        DataMahasiswa1302213080 dataMahasiswa = ReadJSON<DataMahasiswa1302213080>("tp7_1_1302213080.json");
        Console.WriteLine("Nama : " + dataMahasiswa.nama.depan + " " + dataMahasiswa.nama.belakang + "dengan nim " 
            + dataMahasiswa.nim + "dari fakultas " + dataMahasiswa.fakultas);
    }

    public static Tipe ReadJSON<Tipe>(string filename)
    {
        string jsonString = File.ReadAllText("C:\Users\Wawan\tpmodul7_kelompok_04" + filename);
        return JsonSerializer.Deserialize<Tipe>(jsonString);
    }
}

class DataMahasiswa1302213080
{
    public NamaLengkap nama { get; set; }
    public int nim { get; set; }
    public string fakultas { get; set; }

    public DataMahasiswa1302213080(){}

    public DataMahasiswa1302213080(NamaLengkap nama, int nim, string fakultas)
    {
        this.nama = nama;
        this.nim = nim;
        this.fakultas = fakultas;
    }

    public class NamaLengkap
    {
        public string depan { get; set; }
        public string belakang { get; set; }

        public NamaLengkap() { }

        public NamaLengkap(string depan, string belakang)
        {
            this.depan = depan;
            this.belakang = belakang;
        }
    }

}


