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

namespace LAB6s2
{
    //test commit
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        public void Clear_Click(object sender, RoutedEventArgs e)
        {
            A.Text = "";
            B.Text = "";
            Result.Content = "0";
        }
    }
}