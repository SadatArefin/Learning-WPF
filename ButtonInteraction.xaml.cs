using System.Windows;
using System.Windows.Media;

namespace WpfSampleApplication
{
    /// <summary>
    /// Interaction logic for ButtonInteraction.xaml
    /// </summary>
    public partial class ButtonInteraction : Window
    {
        public ButtonInteraction()
        {
            InitializeComponent();
        }

        void OnClick1(object sender, RoutedEventArgs e)
        {
            btn1.Background = Brushes.LightBlue;
        }

        void OnClick2(object sender, RoutedEventArgs e)
        {
            btn2.Background = Brushes.Pink;
        }

        void OnClick3(object sender, RoutedEventArgs e)
        {
            btn1.Background = Brushes.Pink;
            btn2.Background = Brushes.LightBlue;
        }
    }
}
