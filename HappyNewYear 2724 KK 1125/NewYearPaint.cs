using System.Drawing;

public class NewYearPaint
{
    Graphics graphics;

    List<IPaint> Ris = new List<IPaint>();

    public NewYearPaint(Graphics graphics)
    {
        this.graphics = graphics;
    }
    public void Create()
    {
        foreach (IPaint p in Ris)
        {
            p.Paint(graphics);
        }
    }
    
    public void AddPaintObject(IPaint p)
    { 
        Ris.Add(p);
    }
}