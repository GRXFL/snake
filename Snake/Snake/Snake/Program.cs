using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);


            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            HorizontalLine upline = new HorizontalLine(0, 78, 0, '+');
            VerticalLines leftline = new VerticalLines(0, 24, 0, '+');
            VerticalLines rightline = new VerticalLines(0, 24, 78, '+');

            upline.Drow();
            downline.Drow();
            leftline.Drow();
            rightline.Drow();

            Point p = new Point(4, 5, '#');
            p.Draw();

            Console.ReadLine();
        }
    }
}
