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
    /// Interaction logic for ToggleButton.xaml
    /// </summary>
    public partial class ToggleButton : UserControl
    {

        Thickness leftSide = new Thickness(-355, 0, 0, 0);
        Thickness rightSide = new Thickness(0, 0, -355, 0);

        LinearGradientBrush off = new LinearGradientBrush();
        LinearGradientBrush on = new LinearGradientBrush();

        bool toggled = Properties.Settings.Default.Privacy;

        public ToggleButton()
        {

            InitializeComponent();

            off.StartPoint = new Point(0, 0);
            off.EndPoint = new Point(0, 1);

            off.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#7C0000"), 0.0));
            off.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#CC0000"), 1.0));

            on.StartPoint = new Point(0, 0);
            on.EndPoint = new Point(0, 1);

            on.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#91CF0F"), 0.0));
            on.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#537609"), 1.0));

            Back.Fill = off;
            toggled = false;
            Dot.Margin = leftSide;
        }


        public bool Toggled
        {
            get => toggled;
            set
            {
                toggled = value;
                Properties.Settings.Default.Privacy = toggled;
                SetToggled();
                Properties.Settings.Default.Save();

            }
        }

        private void Ellipse_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Toggled = !Toggled;
        }

        void SetToggled()
        {
            if (!Toggled)
            {
                Back.Fill = on;
                Dot.Margin = rightSide;
            }
            else
            {
                Back.Fill = off;
                Dot.Margin = leftSide;

            }

        }
    }
}
