using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
  public class Quadratic
  {
        public int coef1;
        public int coef2;
        public int coef3;
        double discr;

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

        public void SetDiscr()
        {
            discr = coef2 ^ 2 - 4 * coef1 * coef3;
        }
        public double Discriminant(int a, int b, int c)
        {
            SetCoef1(a);
            SetCoef2(b);
            SetCoef3(c);
            SetDiscr();
            return discr;
        }
        public double Solution1(int a, int b, int c)
        {
            double d = Math.Sqrt(Discriminant(a, b, c));
            double x1 = (-b + d) / 2 * a;
            return x1;
        }
        public double Solution2(int a, int b, int c)
        {
            double d = Math.Sqrt(Discriminant(a, b, c));
            double x2 = (-b - d) / 2 * a;
            return x2;
        }
        public override string ToString()
        {
            return $"{coef1}*x^2 + {coef2}*x + {coef3} = 0";
        }
        public string DiscToString()
        {
            return $"D = {coef2}^2 - 4*{coef1}*{coef3}";
        }
  }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAct_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(txtbCoef1.Text);
            int b = int.Parse(txtbCoef2.Text);
            int c = int.Parse(txtbCoef3.Text);
            Quadratic quadratic = new Quadratic { coef1 = a, coef2 = b, coef3 = c };
            
            lblEq.Content = quadratic.ToString();
            lblDiscr.Content = quadratic.DiscToString();

            try
            {
                double x1 = quadratic.Solution1(a, b, c);
                double x2 = quadratic.Solution2(a, b, c);
                if (x1 == x2)
                {
                    txtbAnswer.Text = $"Уравнение имеет один корень x = {x1}";
                }
                txtbAnswer.Text = $"x1 = {x1};      x2 = {x2}";
            }
            catch (DivideByZeroException)
            {
                txtbAnswer.Text = "Коэффицент 1 не может быть равен 0";
            }
            catch (FormatException)
            {
                txtbAnswer.Text = "Некорректный ввод";
            }
            catch (ArithmeticException)
            {
                txtbAnswer.Text = "Уравнение не имеет корней";
            }
        }
    }
}
