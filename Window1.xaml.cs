using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace OddEvenRows {

    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }
    }

    public class SimpleData {
        public string Column1 { get; set; }
        public int Column2 { get; set; }

        public SimpleData() { }

        public SimpleData(string str1, int int2) {
            Column1 = str1;
            Column2 = int2;
        }
    }
    public class Conv : IValueConverter {

        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            if (!(value is int)) return new SolidColorBrush(Colors.White);
            if ((int)value % 3 == 0) return new SolidColorBrush(Colors.Red);
            return new SolidColorBrush(Colors.White);
        }

        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            throw new System.NotImplementedException();
        }
    }
}
