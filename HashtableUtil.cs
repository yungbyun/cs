using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class HashtableUtil //hutil
{
    public void ToHashtable(MonthCalendar mc, TextBox tb, Hashtable ht)
    {
        CalendarUtil cal = new CalendarUtil();
        string Key = cal.GetDate(mc);
        ht[Key] = tb.Text;
    }
}