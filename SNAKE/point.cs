using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    class point
    {
        public int x;
        public int y;
        public char sym;

        public point(int _x,int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;

        }

        public void Move(int i,Direction direction)
        {
            if (direction== Direction.Right)
            {
                x = x + i;

            }
            else if (direction==Direction.Left)
            {
                x = x - i;

            }
            else if (direction==Direction.Up)
            {
                y -= i;

            }
            else if (direction==Direction.Down)
            {
                y += i;

            }
        }

        public bool IsHit(point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        public point(point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void DrowSym()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);

        }
        public override string ToString()
        {
            return x + "," + y + "," + sym;
        }

        public void clear()
        {
            sym = ' ';
            DrowSym();
        }


    }
}
