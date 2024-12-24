using System;

class TesBackend
{
    static void Main()
    {
        try
        {
            Console.Write("Masukkan jumlah jam kerja dalam seminggu: ");
            double jamKerja = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan tarif per jam: ");
            double tarifPerJam = Convert.ToDouble(Console.ReadLine());

            double totalGaji = HitungGaji(jamKerja, tarifPerJam);

            Console.WriteLine($"Total gaji karyawan: Rp {totalGaji:F2}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Harap masukkan angka yang valid.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
        }
    }

    static double HitungGaji(double jamKerja, double tarifPerJam)
    {
        if (jamKerja > 40)
        {
            double jamLembur = jamKerja - 40;
            double gajiLembur = jamLembur * tarifPerJam * 1.5;
            double gajiPokok = 40 * tarifPerJam;
            return gajiPokok + gajiLembur;
        }
        else
        {
            return jamKerja * tarifPerJam;
        }
    }
}
