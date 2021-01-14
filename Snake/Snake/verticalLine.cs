﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class verticalLine
    {
        List<Point> pList; //данные

        public verticalLine(int x, int yUp, int yDown,  char sym) //конструктор
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Draw() //метод
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
