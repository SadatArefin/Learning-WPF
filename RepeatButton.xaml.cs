using System.Windows;

namespace WpfSampleApplication
{
    /// <summary>
    /// Interaction logic for RepeatButton.xaml
    /// </summary>
    public partial class RepeatButton : Window
    {
        public RepeatButton()
        {
            InitializeComponent();
        }

        void Increase(object sender, RoutedEventArgs e)
        {
            Int32 Num = Convert.ToInt32(valueText.Text);

            valueText.Text = ((Num + 1).ToString());
        }

        void Decrease(object sender, RoutedEventArgs e)
        {
            Int32 Num = Convert.ToInt32(valueText.Text);

            valueText.Text = ((Num - 1).ToString());
        }
    }
}
