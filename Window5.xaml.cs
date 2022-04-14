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
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            string s1 = n1.Text;
            string s2= n2.Text; 
            int bs=Convert.ToInt32(n3.Text);

            float hra = bs * 0.15f;
            float da = bs * 0.1f;
            float ts = hra + da + bs;

            h1.Text = hra.ToString();
            h2.Text=da.ToString();
            h3.Text=ts.ToString();  

        }
    }
}
