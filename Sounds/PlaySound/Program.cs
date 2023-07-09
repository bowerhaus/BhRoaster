using System.Media;

class PlaySound
{    static void Main(string[] args)
    {
        {
            new SoundPlayer(args[0]).PlaySync();  
        }
    }
}



