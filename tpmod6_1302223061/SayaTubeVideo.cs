using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod6_1302223061.SayaTubeVideo
{
    internal class SayaTubeVideo
    {
        private int id;
        private String title;
        private int PlayCount;

        public SayaTubeVideo(String title, int PlayCount)
        {
            if (title == null || title == "")
            {
                throw new ArgumentException("title tidak boleh bernilai 0 atau kosong");
            }
            Random r = new Random();
            this.id = r.Next(10000, 99999);
            this.title = title;
            this.PlayCount = PlayCount;
        }

        public void incrementPlayCount(int x)
        {
            try
            {
                checked
                {
                    if (x > 10000000)
                    {
                        PlayCount += 10000000;
                    }
                    else
                    {
                        PlayCount += x;
                    }

                }
            }
            catch (OverflowException e)
            {
                this.PlayCount = int.MaxValue;
                Console.WriteLine("Jumlah pemutaran terlalu tinggi untuk ditingkatkan \n");
            }
        }

        public void printVideoDetails()
        {
            Console.WriteLine("Id video: " + id);
            Console.WriteLine("Judul: " + title);
            Console.WriteLine("Jumlah pemutaran: " + PlayCount);
        }
    }
}