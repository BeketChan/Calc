using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalcProject
{
  /// <summary>
  /// Логика взаимодействия для MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Обновляем табло в зависимости от нажатой кнопки
    /// </summary>
    /// <param name="key">Кнопка</param>
    void RefreshTablo(Key key)
    {
      Calc.ChangeTablo(key);
      lblTablo.Content = Calc.tablo.ToString();
    }

    #region Нажатие кнопок с клавиатуры
    private void Window_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.Key == Key.D0 || e.Key == Key.NumPad0) RefreshTablo(Key.D0);
      if (e.Key == Key.D1 || e.Key == Key.NumPad1) RefreshTablo(Key.D1);
      if (e.Key == Key.D2 || e.Key == Key.NumPad2) RefreshTablo(Key.D2);
      if (e.Key == Key.D3 || e.Key == Key.NumPad3) RefreshTablo(Key.D3);
      if (e.Key == Key.D4 || e.Key == Key.NumPad4) RefreshTablo(Key.D4);
      if (e.Key == Key.D5 || e.Key == Key.NumPad5) RefreshTablo(Key.D5);
      if (e.Key == Key.D6 || e.Key == Key.NumPad6) RefreshTablo(Key.D6);
      if (e.Key == Key.D7 || e.Key == Key.NumPad7) RefreshTablo(Key.D7);
      if (e.Key == Key.D8 || e.Key == Key.NumPad8) RefreshTablo(Key.D8);
      if (e.Key == Key.D9 || e.Key == Key.NumPad9) RefreshTablo(Key.D9);
      if (e.Key == Key.Decimal) RefreshTablo(Key.Decimal);

      if (e.Key == Key.Delete) RefreshTablo(Key.Delete);
    } 
    #endregion

    #region Нажатие цифровых кнопок мышкой
    private void btn1_Click(object sender, RoutedEventArgs e)
    {
      RefreshTablo(Key.D1);
    }

    private void btn2_Click(object sender, RoutedEventArgs e)
    {
      RefreshTablo(Key.D2);
    }

    private void btn3_Click(object sender, RoutedEventArgs e)
    {
      RefreshTablo(Key.D3);
    }

    private void btn4_Click(object sender, RoutedEventArgs e)
    {
      RefreshTablo(Key.D4);
    }

    private void btn5_Click(object sender, RoutedEventArgs e)
    {
      RefreshTablo(Key.D5);
    }

    private void btn6_Click(object sender, RoutedEventArgs e)
    {
      RefreshTablo(Key.D6);
    }

    private void btn7_Click(object sender, RoutedEventArgs e)
    {
      RefreshTablo(Key.D7);
    }

    private void btn8_Click(object sender, RoutedEventArgs e)
    {
      RefreshTablo(Key.D8);
    }

    private void btn9_Click(object sender, RoutedEventArgs e)
    {
      RefreshTablo(Key.D9);
    }

    private void btn0_Click(object sender, RoutedEventArgs e)
    {
      RefreshTablo(Key.D0);
    }

    private void btnPoint_Click(object sender, RoutedEventArgs e)
    {
      RefreshTablo(Key.Decimal);
    }

    #endregion
    

    private void btnClear_Click(object sender, RoutedEventArgs e)
    {
      RefreshTablo(Key.Delete);
    }

    private void btnBackspace_Click(object sender, RoutedEventArgs e)
    {
      RefreshTablo(Key.Back);
    }
  }
}
