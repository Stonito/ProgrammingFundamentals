using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;

            long picturesTaken = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long filterPercent = long.Parse(Console.ReadLine());
            long uploadingTimeFOrFilteredPicture = int.Parse(Console.ReadLine());

            long secondsForFiltering = picturesTaken * filterTime;
            long filteredPictures = (long)Math.Ceiling(picturesTaken * filterPercent / 100.0);
            long timeForUploading = filteredPictures * uploadingTimeFOrFilteredPicture;

            long totalSeconds = secondsForFiltering + timeForUploading;

            TimeSpan time = TimeSpan.FromSeconds(totalSeconds);
            Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}", time.Days, time.Hours, time.Minutes, time.Seconds);

        }
    }
}
