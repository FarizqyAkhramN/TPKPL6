using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL6_103022400132
{
    public class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;
        public SayaMusicTrack(string title)
        {
            this.title = title;
            this.playCount = 0;
            Random rand = new Random();
            this.id = rand.Next(10000, 100000);
        }
        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
        }
        public void PrintTrackDetails()
        {
            Console.WriteLine("=== Detail Music Track ===");
            Console.WriteLine($"ID          : {this.id}");
            Console.WriteLine($"Judul Lagu  : {this.title}");
            Console.WriteLine($"Play Count  : {this.playCount}");
            Console.WriteLine("--------------------------\n");
        }
    }
}
