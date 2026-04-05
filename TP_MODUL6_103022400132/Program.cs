using System;

namespace TugasMusicApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaMusicTrack lagu = new SayaMusicTrack("Hati-Hati di Jalan");
            lagu.PrintTrackDetails();
            bool isSuccess = false;

            while (!isSuccess)
            {
                try
                {
                    Console.Write("\nMasukkan jumlah penambahan Play Count: ");
                    string input = Console.ReadLine();

                    int jumlah = int.Parse(input);
                    lagu.IncreasePlayCount(jumlah);

                    Console.WriteLine("Berhasil menambahkan Play Count!");
                    isSuccess = true; 
                }
                catch (FormatException)
                {
                    Console.WriteLine("[Error] Input harus berupa angka!");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"[Error] {ex.Message}");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("[Error] Total Play Count melebihi batas maksimal (Overflow)!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[Error] Terjadi kesalahan: {ex.Message}");
                }
            }

            lagu.PrintTrackDetails();
            Console.WriteLine("\nTekan sembarang tombol untuk keluar...");
            Console.ReadKey();
        }
    }
}