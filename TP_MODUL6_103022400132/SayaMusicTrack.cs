using System;
using System.Diagnostics;

namespace TugasMusicApp
{
    public class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;

        public SayaMusicTrack(string title)
        {
            Debug.Assert(title != null, "Judul tidak boleh null!");
            this.title = title;
            this.playCount = 0;
            this.id = new Random().Next(10000, 100000);
        }
        public void IncreasePlayCount(int count)
        {
            if (count > 10000000)
            {
                throw new ArgumentOutOfRangeException("count", "Input maksimal adalah 10.000.000!");
            }

            checked
            {
                this.playCount += count;
            }
        }
        public void PrintTrackDetails()
        {
            Console.WriteLine($"\n[Song] ID: {id} | Judul: {title} | Play Count: {playCount}");
        }
    }
}