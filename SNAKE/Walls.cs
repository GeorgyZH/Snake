using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    class Walls
    {
        List<Figura> walllist;

        public Walls(int width,int height,char sym)
        {
            walllist = new List<Figura>();

            Horizontal hline = new Horizontal(1, width-20, 1, sym);

            Horizontal hline2 = new Horizontal(1, width - 20, height-1, sym);


            Vertical vline = new Vertical(1, height - 1, 1, sym);

            Vertical vline2 = new Vertical(1, height - 1, width - 20, sym);

            walllist.Add(hline);
            walllist.Add(hline2);
            walllist.Add(vline);
            walllist.Add(vline2);

        }
        public bool isHit(Figura figura)
        {
            foreach (var wal in walllist)
            {
                if (wal.isHit(figura)) return true;
                
            }
            return false;

        }
        public void walldrow()
        {
            foreach( var p in walllist)
            {
                p.Drow() ;
            }
        }

    }
}
