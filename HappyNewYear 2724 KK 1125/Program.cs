using System.Diagnostics;
using System.Drawing;

Graphics graphics = Graphics.FromHwnd(Process.GetCurrentProcess().MainWindowHandle);

NewYearPaint facade = new NewYearPaint(graphics);

ChrismasTree chrismas = new ChrismasTree();
Decorations decorations = new Decorations();

facade.AddPaintObject(chrismas);
facade.AddPaintObject(decorations);
facade.Create();
Console.ReadLine();