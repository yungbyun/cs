using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

class MyUtil
{ //babo
    public void DrawString(Form f, String msg, int x, int y)
    {
        Graphics gildong = f.CreateGraphics();
        gildong.DrawString(msg, f.Font, new SolidBrush(Color.Red), x, y);
    }
}