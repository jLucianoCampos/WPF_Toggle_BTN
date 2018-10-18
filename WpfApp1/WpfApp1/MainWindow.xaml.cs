
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Configuration;
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


            Properties.Settings.Default.Upgrade();


            if (Properties.Settings.Default.Privacy)
            {
                btnPrivacy.Toggled = true;
            }
            else
            {
                btnPrivacy.Toggled = false;
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key.Equals(Key.F2))
                {
                    btnPrivacy.Toggled = !btnPrivacy.Toggled;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
