using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
     class CreateFood
    {
        int MapHeight;
        int MapWidth;
        char sym;

        Random random = new Random();

        public CreateFood(int MapHeight,int MapWidth,char sym)
        {
            this.MapHeight = MapHeight;
            this.MapWidth = MapWidth;
            this.sym = sym;

        }

        public point PointFood()
        {
            int x = random.Next(2, MapWidth-2);
            int y = random.Next(2, MapHeight-2);
            return new point(x,y,sym);
        }
    }
}