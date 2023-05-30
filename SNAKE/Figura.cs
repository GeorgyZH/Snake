using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    class Figura
    {

       protected List<point> plist;

        public bool isHit(Figura figura)
        {
            foreach(var p in plist)
            {
                if (figura.isHit(p)) return true;
                      

            }
            return false;
        }

        private bool isHit(point point)
        {
            foreach( var p in plist)
            {
                if (p.IsHit(point))
                {
                    return true;
                }

            }
            return false;
        }

        public void Drow()
        {
            foreach (point p in plist)
            {
                p.DrowSym();
            }

        }

    }
}
