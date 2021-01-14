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
            Point p1 = new Point(3,6, '*');
            p1.Draw();

            Point p2 = new Point(6,8,'#');
            p2.Draw();

            HorizontalLine line = new HorizontalLine(5,10,10,'$');
            line.Draw();

            verticalLine vLine = new verticalLine(6, 9, 16, '@');
            vLine.Draw();

            Console.ReadLine();
            
        }

     
    }
}
