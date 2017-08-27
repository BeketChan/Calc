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
    static public double tablo = 0;
    static public int razradDrob = 0;
    static public int numQty = 0;
    static bool decPoint = false;
    static List<string> list = new List<string>();

    /// <summary>
    /// Действия по нажатию кнопок
    /// </summary>
    /// <param name="action">Кнопка</param>
    static public void ChangeTablo(Key action)
    {
      int key = (int)action;

      // очищаем
      if (key == 32)
      {
        tablo = 0;
        razradDrob = 0;
        numQty = 0;
      }

      // удаляем последнюю цифру
      if (key == 2)
      {
        if (!decPoint) tablo = Math.Truncate(tablo / 10);
        else
        {
          var num = Math.Truncate(tablo);
          var drb = tablo - num;

          if (drb == 0)
          {
            decPoint = false;
            tablo = (int)(tablo / 10);
          }
          else
          {
            //MessageBox.Show(key.ToString());
            razradDrob--;
            var temp = Math.Truncate(drb * Math.Pow(10, razradDrob));
            tablo = num + temp / Math.Pow(10, razradDrob);
          }
        }
        numQty--;
      }

      if (numQty < 0) numQty = 0;
      if (numQty >= 15) return;
      //MessageBox.Show(tablo.ToString() );

      // добавляем разделитель дробной части
      if (key == 88)
      {
        decPoint = true;
        if (tablo == 0) numQty++;
      }
      
      // добавляем цыфры в зависимости от наличия разделителя
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
        numQty++;
      }
      
    }
  }
}
