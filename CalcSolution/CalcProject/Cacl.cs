using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace CalcProject
{
  static class Calc
  {
    static public double tablo = 0, razradDrob = 0;
    static bool decPoint = false;
    static List<string> list = new List<string>();

    static public void ChangeTablo(Key action)
    {
      int key = (int)action;
      //MessageBox.Show( key.ToString() );

      if (key == 88) decPoint = true;
      
      if (key >= 34 && key <= 44)
      {
        if (!decPoint)
        {
          tablo = tablo * 10 + key - 34;
        }
        else
        {
          razradDrob++;
          tablo = tablo + (key - 34) / Math.Pow(10, razradDrob);
        }
      }

    }
  }
}
