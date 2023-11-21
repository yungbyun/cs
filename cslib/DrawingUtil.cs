using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class DrawingUtil //du
{
    public void DrawRectangle(Form f, int x, int y)
    {
        Graphics cheolsu = f.CreateGraphics();
        cheolsu.DrawRectangle(new Pen(Color.Red), x, y, 50, 50);
    }

    public void DrawString(Form f, String s, int x, int y)
    {
        Graphics cheolsu = f.CreateGraphics(); //화가
        cheolsu.DrawString(s, f.Font, new SolidBrush(Color.Blue), 10, 10);
    }
} 