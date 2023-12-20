using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

public class ChrismasTree : IPaint
{
    public void Paint(Graphics graphics)
    {
            Brush brush = new SolidBrush(Color.LightGreen);
            Brush brush1 = new SolidBrush(Color.DarkOliveGreen);
        graphics.FillPolygon(brush, new Point[] // нижняя часть ёлки
        {
                new Point(600,300), // правая часть
                new Point(400,300), // левая часть ёлки
                new Point(500,150), //верхушка ёлки
        });
        graphics.FillPolygon(brush, new Point[] // верхняя часть ёлки
        {
                new Point(625,200),
                new Point(375,200),
                new Point(500,50),
        });
        graphics.FillPolygon(brush1, new Point[] //Левая нога
        {
                new Point(425,300),
                new Point(300,450),
                new Point(525,300),
        });
        graphics.FillPolygon(brush1, new Point[] //Правая нога
        {
                new Point(575,300),
                new Point(675,450),
                new Point(475,300),
        });
    }
}
