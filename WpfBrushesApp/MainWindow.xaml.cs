using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfBrushesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btn.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
            
            var grBrash = new LinearGradientBrush();
            grBrash.GradientStops.Add(new GradientStop(Colors.Green, 0));
            grBrash.GradientStops.Add(new GradientStop(Colors.Blue, 1));
            grBrash.StartPoint = new Point(0, 1);
            grBrash.EndPoint = new Point(0, 0);
            btn2.Foreground = grBrash;

        }
    }
}