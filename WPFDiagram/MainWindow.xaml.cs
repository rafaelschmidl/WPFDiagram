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

namespace WPFDiagram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            BarA.MaxHeight = BarA.Height;
            BarB.MaxHeight = BarB.Height;
            BarC.MaxHeight = BarC.Height;
            BarD.MaxHeight = BarD.Height;

            BarA.Height = 0;
            BarB.Height = 0;
            BarC.Height = 0;
            BarD.Height = 0;
        }

        private void UpdateBar(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider slider;

            try
            {
                slider = (Slider)sender;

            }
            catch (Exception exception)
            {

                throw exception;
            }
  
            switch (slider.Name)
            {               
                case "SliderA":
                    SliderValueA.Content = slider.Value;
                    BarA.Height = BarA.MaxHeight / 100 * slider.Value;
                    break;
                case "SliderB":
                    SliderValueB.Content = slider.Value;
                    BarB.Height = BarB.MaxHeight / 100 * slider.Value;
                    break;
                case "SliderC":
                    SliderValueC.Content = slider.Value;
                    BarC.Height = BarC.MaxHeight / 100 * slider.Value;
                    break;
                case "SliderD":
                    SliderValueD.Content = slider.Value;
                    BarD.Height = BarD.MaxHeight / 100 * slider.Value;
                    break;
            }
        }
    }
}
