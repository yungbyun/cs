using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class DrawingUtilForm : Form
{
    public void DrawRectangle(int x, int y)
    {
        Graphics cheolsu = CreateGraphics();
        cheolsu.DrawRectangle(new Pen(Color.Red), x, y, 50, 50);
    }

    public void DrawString(String s, int x, int y)
    {
        Graphics cheolsu = CreateGraphics(); //È­°¡
        cheolsu.DrawString(s, Font, new SolidBrush(Color.Blue), 10, 10);
    }

}