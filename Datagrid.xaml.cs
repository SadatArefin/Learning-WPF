using System.Windows;
using System.Windows.Data;

namespace WpfSampleApplication
{
    /// <summary>
    /// Interaction logic for Datagrid.xaml
    /// </summary>
    public partial class Datagrid : Window
    {
        public Datagrid()
        {
            InitializeComponent();
        }
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Uri Email { get; set; }
        public bool IsMember { get; set; }
        public OrderStatus Status { get; set; }
    }

    public enum OrderStatus { None, New, Processing, Shipped, Received };

    //Converts the mailto uri to a string with just the customer alias
    public class EmailConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null)
            {
                string email = value.ToString();
                int index = email.IndexOf("@");
                string alias = email.Substring(7, index - 7);
                return alias;
            }
            else
            {
                string email = "";
                return email;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Uri email = new((string)value);
            return email;
        }
    }
}
