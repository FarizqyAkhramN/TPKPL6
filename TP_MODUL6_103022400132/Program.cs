using System;
using TP_MODUL6_103022400132;

namespace TugasMusicApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaMusicTrack lagu1 = new SayaMusicTrack("Hati-Hati di Jalan");
            Console.WriteLine("Kondisi Awal:");
            lagu1.PrintTrackDetails();
            lagu1.IncreasePlayCount(150);
            Console.WriteLine("Setelah Update Play Count:");
            lagu1.PrintTrackDetails();
            Console.WriteLine("Tekan sembarang tombol untuk keluar...");
            Console.ReadKey();
        }
    }
}