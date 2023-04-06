
using System;
using System.Text.Json;
using tpmodul7_kelompok_04;

internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa_1302213080 data = new DataMahasiswa_1302213080();

        String jsonString = File.ReadAllText("D:\\kuliah\\semester 4\\praktikum konstruksi PL\\tpmodul7\\tpmodul7_kelompok_04\\tpmodul7_kelompok_04\\tp7_1_130221080.json");

        DataMahasiswa_1302213080 mhs = JsonSerializer.Deserialize<DataMahasiswa_1302213080>(jsonString);
        Console.WriteLine("Nama " + mhs.nama.depan + " " + mhs.nama.belakang + " dengan nim " + mhs.nim + " dari fakultas " + mhs.fakultas);

        String jsonString2 = File.ReadAllText("C:\\Users\\arzaq\\OneDrive\\Documents\\GUI\\tpmodul7\\tpmodul7\\tpmodul7_kelompok_04\\bin\\Debug\\net6.0\\tp7_2_1302210096.json");
        //Deserialize 2
        KuliahMahasiswa_1302210096 kuliah = JsonSerializer.Deserialize<KuliahMahasiswa_1302210096>(jsonString2);
        if (kuliah.courses != null)
        {
            int i = 1;
            foreach (MataKuliah_1302210096 matkul in kuliah.courses)
            {
                Console.WriteLine("MK " + (i) + " " + matkul.code + " - " + matkul.name);
                i++;
            }
        }
        else
        {
            Console.WriteLine("EMPTY");
        }
    }
 }
