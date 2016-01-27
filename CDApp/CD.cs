using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDApp
{
    class CD 
    {
        public string Name { get; set; }
        
        public string Artist { get; set; }
        private List<CarolusRex> carolusRex;
        public CD()
        {
            carolusRex = new List<CarolusRex>();
        }

       
        public void AddSong(CarolusRex carolusrex)
        {
            carolusRex.Add(carolusrex);
        }
        public void PrintCd()
        {
            Console.WriteLine("CD data:\n- name: {0}\n- artist: {1} \n- songs:", Name, Artist);
            foreach(CarolusRex album in carolusRex)
            {
                Console.Write("  \n-{0} -{1}", album.Song, album.Length);
            }
        }
    }
}
