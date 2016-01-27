using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CD levy = new CD();
            levy.Name = "Carolus Rex";
            levy.Artist = "Sabaton";

            CarolusRex song1 = new CarolusRex { Song = "Dominium Maris Baltici ", Length= "0:29" };
            CarolusRex song2 = new CarolusRex { Song = "Lejonet från Norden ", Length = "4:42" };
            CarolusRex song3 = new CarolusRex { Song = "Gott Mit Uns ", Length = "3:15" };
            CarolusRex song4 = new CarolusRex { Song = "En Livstid i Krig ", Length = "5:45" };
            CarolusRex song5 = new CarolusRex { Song = "1 6 4 8 ", Length = "3:54" };
            CarolusRex song6 = new CarolusRex { Song = "Karolinens bön ", Length = "6:14" };
            CarolusRex song7 = new CarolusRex { Song = "Carolus Rex ", Length = "4:53" };
            CarolusRex song8 = new CarolusRex { Song = "Ett Slag Färgat Rött ", Length = "4:24" };
            CarolusRex song9 = new CarolusRex { Song = "Poltava ", Length = "4:03" };
            CarolusRex song11 = new CarolusRex { Song = "Konungens Likfärd ", Length = "4:09" };
            CarolusRex song12 = new CarolusRex { Song = "Ruina Imperii ", Length = "3:21" };

            levy.AddSong(song1);
            levy.AddSong(song2);
            levy.AddSong(song3);
            levy.AddSong(song4);
            levy.AddSong(song5);
            levy.AddSong(song6);
            levy.AddSong(song7);
            levy.AddSong(song8);
            levy.AddSong(song9);
            levy.AddSong(song11);
            levy.AddSong(song12);

            levy.PrintCd();



        }
    }
}
