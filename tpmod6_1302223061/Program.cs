using tpmod6_1302223061.SayaTubeVideo;

namespace Program;
class Progam
{

    public static void Main(String[] Args)
    {
        SayaTubeVideo video = new SayaTubeVideo("paguyuban oy oy", 0);
        for (int i = 0; i < 220; i++)
        {
            video.incrementPlayCount(10000000);
            video.printVideoDetails();
        }
        Console.WriteLine("max play count :" + int.MaxValue);

    }
}