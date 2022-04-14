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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            string s1 = n1.Text;
            string s2 = n2.Text;
            string s3=n3.Text;
            int s4=Convert.ToInt32(n4.Text);
            string s5=n5.Text;

            h1.Text = s1.ToString();
            h2.Text = s2.ToString();
            h3.Text = s3.ToString();
            h4.Text = s4.ToString();    
            h5.Text = s5.ToString();
        }
    }
}
