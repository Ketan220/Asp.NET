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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string u = t1.Text;
            string p=t2.Text;
            MessageBox.Show("Username is" + u);
            MessageBox.Show("Password is" + p);

            if(u=="admin" && p=="admin")
            {
                l1.Content = "login succefully";

            }
            else
            {
                l1.Content = "Invalid credintial";
            }
        }
    }
}
