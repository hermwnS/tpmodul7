// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using tpmodul7_kelompok_04;

internal class Program
{

    private static void Main(string[] args)
    {
        DataMahasiswa_1302213108 data = new DataMahasiswa_1302213108();
        String jsonString = File.ReadAllText("D:\\Folder kpl\\tpmodul7\\tpmodul7_kelompok_04\\tpmodul7_kelompok_04\\bin\\Debug\\net6.0\\tp7_1_1302213108.json");
        data = JsonSerializer.Deserialize<DataMahasiswa_1302213108>(jsonString);
        Console.WriteLine("Nama " + data.nama.depan + " " + data.nama.belakang + " dengan nim " + data.nim + " dari fakultas " + data.fakultas);

        String jsonString2 = File.ReadAllText("D:\\Folder kpl\\tpmodul7\\tpmodul7_kelompok_04\\tpmodul7_kelompok_04\\bin\\Debug\\net6.0\\tp7_2_1302213108.json");
        //Dezerialize 
        KuliahMahasiswa_1302213108 kuliah = JsonSerializer.Deserialize<KuliahMahasiswa_1302213108>(jsonString2);
        if (kuliah.courses != null)
        {
            int i = 1;
            foreach (MataKuliah_1302213108 matkul in kuliah.courses)
            {
                Console.WriteLine("MK"+(i) + " " +  matkul.code+" __ " + matkul.name);
                i++;
            }
        }
        else
        {
            Console.WriteLine("Kosong");
        }
    }

}
