using System.Windows;

namespace WpfSampleApplication
{
    /// <summary>
    /// Interaction logic for DataBinding.xaml
    /// </summary>
    public partial class DataBinding : Window
    {
        public DataBinding()
        {
            InitializeComponent();

            Person person = new();

            DataContext = person;
        }
    }
    class Person
    {
        public string Name { get; set; } = "No Name";
    }
}
