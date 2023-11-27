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

namespace Змейка
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private Ellipse CteateE1(Point point, Brush brush)
        {
            Ellipse e1 = new Ellipse();
            e1.Width = 16;
            e1.Height = 16;
            e1.Fill = brush;
            Canvas.SetLeft(e1, point.X);
            Canvas.SetTop(e1, point.Y);
            return e1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random y = new Random();
            Random x = new Random();
            Random br = new Random();
            Color randomColor = GenerateRandomColor();
            SolidColorBrush brush = new SolidColorBrush(randomColor);
            Ellipse e1 = CteateE1(new Point(x.Next(0,794), y.Next(0,421)), brush);
            Map.Children.Insert(0, e1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Random y = new Random();
            Random x = new Random();
            Random br = new Random();
            Color randomColor = GenerateRandomColor();
            SolidColorBrush brush = new SolidColorBrush(randomColor);
            Rectangle r1 = CreateR1(new Point(x.Next(0, 794), y.Next(0, 421)), brush);
            Map.Children.Insert(0, r1);
        }

        private Rectangle CreateR1(Point point, Brush brush)
        {
            Rectangle r1 = new Rectangle();
            r1.Width = 30;
            r1.Height = 30;
            r1.Fill = brush;
            Canvas.SetLeft(r1, point.X);
            Canvas.SetTop(r1, point.Y);
            return r1;
        }

        private Color GenerateRandomColor()
        {
            byte[] colorBytes = new byte[3];
            random.NextBytes(colorBytes);
            return Color.FromRgb(colorBytes[0], colorBytes[1], colorBytes[2]);
        }
    }
}
