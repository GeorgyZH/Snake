using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    class snake : Figura
    {
        public Direction direction;

        public snake(point tail,int lenght,Direction _direction)
        {
            direction = _direction;
            plist = new List<point>();
            for (int i = 0; i<lenght ;i++)
            {
                point p = new point(tail);
                p.Move(i,direction);
                plist.Add(p);
            }
        }

        internal void Move()
        {
            point tail = plist.First();
            plist.Remove(tail);
            point head = GetNewPoint();
            plist.Add(head);

            tail.clear();
            head.DrowSym();
        }

        public point GetNewPoint()
        {
            point head = plist.Last();
            point nextpoint = new point(head);
            nextpoint.Move(1,direction);
            return nextpoint;
        }
        public bool isHitTail()
        {
            var head = plist.Last();
            for (int i= 0; i < plist.Count-2 ; i++)
            {
                if (head.IsHit(plist[i])) return true;
            }
            return false;
        }

        internal bool eat(point p)
        {
            point head = GetNewPoint();
            if (head.IsHit(p))
            {
                p.sym = head.sym;
                plist.Add(p);
                return true;
            }
            else return false;
        }
        public int lenght()
        {
            return plist.Count; 
        }

      
        public void go(ConsoleKey key)
        {
            {
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        if (direction != Direction.Right)
                            direction = Direction.Left;
                        break;
                    case ConsoleKey.RightArrow:
                        if (direction != Direction.Left)
                            direction = Direction.Right;
                        break;
                    case ConsoleKey.UpArrow:
                        if (direction != Direction.Down)
                            direction = Direction.Up;
                        break;
                    case ConsoleKey.DownArrow:
                        if (direction != Direction.Up)
                            direction = Direction.Down;
                        break;
                    default: break;
                }
            }


            

        }
    }
}
