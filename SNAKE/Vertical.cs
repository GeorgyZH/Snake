using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    class Vertical : Figura
    {
        

        public Vertical(int yUP,int yDown,int x,char sym)
        {
            plist = new List<point>();
            for (int i = yUP; i<=yDown;i++)
            {
                point p = new point(x,i,sym);
                plist.Add(p);
            }
            
        }

    }
}
