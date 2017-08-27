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
  }
}
