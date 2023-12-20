using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Decorations : IPaint
{

    public void Paint(Graphics graphics)
    {
        Pen RedGirland = new Pen(Color.Red, 4); // Для красной гирлянды
        Pen BlueGirland = new Pen(Color.Blue, 4); // Для синей, ну или голубой гирлянды
        Pen WhiteGirland = new Pen(Color.White, 4); // Для белой гирлянды
        Brush BlueBall = new SolidBrush(Color.Blue); // Для синих шариков на ёлку (хаха, слово Ball также может переводится как яйца)
        Brush RedBall = new SolidBrush(Color.DarkRed); // Для красных шариков на ёлку
        Brush YellowBall = new SolidBrush(Color.Yellow); // Для жёлтых шариков на ёлку
        Brush WhiteBall = new SolidBrush(Color.White); // Для белых шариков на ёлку

        graphics.DrawCurve(RedGirland, new Point[]
        {
            new Point(560,120),
                new Point(408,160),
                new Point(600,170),
        });
        graphics.FillEllipse
    }
}
    