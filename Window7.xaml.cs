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
    /// Interaction logic for Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        public Window7()
        {
            InitializeComponent();
        }


        private void b2_Click_1(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(n1.Text);
            string r=null;
            for (int i = 0; i <= 10; i++)
            {
                int result = num * i;
                if (r == null)
                {
                    r = num + " *" + i + "=" + result+"\n";
                }
                else
                {
                    r += num + " *" + i + "=" + result+"\n";
                }

            }

            h1.Text = r.ToString()+"\n";
        }
    }
}
