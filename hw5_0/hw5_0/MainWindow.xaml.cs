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

namespace hw5_0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    /*
Описать класс, представляющий квадратное уравнение вида ax^2+bx+c=0.
Описать метод, вычисляющий решение этого уравнения и выбрасывающий
исключение в случае отсутствия корней. Описать свойства для
получения состояния объекта. 
Написать программу, демонстрирующую все разработанные элементы класса.
    */
    class Quadratic
    {
        int coef1;
        int coef2;
        int coef3;
        double var;

        public Quadratic(int a, int b, int c, double x)
        {
            coef1 = a;
            coef2 = b;
            coef3 = c;
            var = x;
        }

        public void SetCoef1(int a)
        {
            coef1 = a;
        }

        public void SetCoef2(int b)
        {
            coef2 = b;
        }

        public void SetCoef3(int c)
        {
            coef3 = c;
        }

        public void SetVar(double x)
        {
            var = x;
        }

        public int GetCoef1()
        {
            return coef1;
        }

        public int GetCoef2()
        {
            return coef2;
        }

        public int GetCoef3()
        {
            return coef3;
        }

        public double GetVar()
        {
            return var;
        }

        public double solution(int a, int b, int c, double x)
        {
            double d = 0;
            d = b ^ 2 - 4 * a * c;
            return x;
        }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
