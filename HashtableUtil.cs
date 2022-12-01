using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class HashtableUtil
{
    public void Store2Hashtable(TextBox tb, Hashtable ht, MonthCalendar cal)
    {
        String imsi = cal.SelectionStart.ToString();
        imsi = imsi.Remove(10, imsi.Length - 10);

        //tbMemo.Text에 저장되어 있는 것을 해쉬테이블에 저장하자.
        //
        ht[imsi] = tb.Text;
    }

    public void ShowToTextBox(Hashtable ht, TextBox tb, MonthCalendar cal)
    {
        //monthCalendar에게 선택된 날짜를 물어보고 그날짜를 tbMemo.Text에 저장
        String imsi = cal.SelectionStart.ToString();
        imsi = imsi.Remove(10, imsi.Length - 10);

        tb.Text = (String)ht[imsi];
    }

}