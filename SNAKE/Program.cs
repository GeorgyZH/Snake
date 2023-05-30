using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SNAKE
{
    class Program
    {

       

        static void Main(string[] args)
        {
            
            //задает размер консоли и не дает возможность прокрутки ее
            Console.SetWindowSize(100,26);

            Console.SetBufferSize(100, 26);


            Walls walls = new Walls(100,26,'+');
            walls.walldrow();
           
           point p = new point(10,4,'*');

            //сама змейка
            snake sn = new snake(p,3,Direction.Right);
            sn.Drow();


            CreateFood create  = new CreateFood(25,80,'*');

            point food = create.PointFood();
            food.DrowSym();
            statistics st = new statistics();
            st.lenght(sn.lenght());
            while (true)
            {
                if (walls.isHit(sn)|| sn.isHitTail())
                {
                    break;
                }
                if (sn.eat(food))
                {
                    food = create.PointFood();
                    st.lenght(sn.lenght());


                    sn.Drow();
                }
                else  sn.Move();
                food.DrowSym();

                Thread.Sleep(100);



                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    sn.go(key.Key);

                }
               

            }
            Console.Clear();
            Console.SetCursorPosition(40,13);
            Console.Write("Game over!");
            Console.SetCursorPosition(40, 14);
            Console.Write("Snake lenght: "+sn.lenght());
            Console.ReadKey();






        }
    }

  
}
