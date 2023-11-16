using System;
using System.Windows.Forms;

public class CalendarUtil
{
        public String GetDate(MonthCalendar cal)
        {
            string Tmp = cal.SelectionStart.ToString();
            Tmp = Tmp.Remove(10, Tmp.Length - 10);

            return Tmp;
        }
    }