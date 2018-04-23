using System;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Data;
using System.Globalization;
using WpfApplication26;

namespace SLShowDetailButton {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            grid1.ItemsSource = new DataSource().Categories;
        }
    }

    public class MyConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            // Obtaining the value to be converted 
            string categoryValue = (string)value;

            // Specifying values for which to show expand buttons
            string[] categories = new string[] { "First", "Third" };
            if (categories.Contains(categoryValue))
                return true;

            // Disable expand button if the value isn't in the list
            return false;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            return null;
        }
    }
}
