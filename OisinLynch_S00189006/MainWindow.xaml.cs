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

namespace OisinLynch_S00189006
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PhoneData db = new PhoneData();

        List<Phone> phones = new List<Phone>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from p in db.Phones
                        select p.Name;

            var phones = query.ToList();

            lbxPhones.ItemsSource = query.ToList();

            //DataTemplate

            Phone p1 = new Phone("Samsung S20", 500, "Android", "/images/android.png", "/images/s20.jpg");
            Phone p2 = new Phone("iPhone 11", 600, "IOS", "/images/apple.png", "/images/iphone11.png");

            db.Phones.Add(p1);
            db.Phones.Add(p2);

            lbxPhones.ItemsSource = phones;

        }

        private void LbxPhones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var query = from p in db.Phones
                        orderby p.Price
                        select p.Price;

            string selected = lbxPhones.SelectedItem as string;

            tblkPrice.Text = selected;

            var query2 = from p in db.Phones
                          orderby p.Phone_Image
                          select p.Phone_Image;

            Image selectedImage = lbxPhones.SelectedItem as Image;

            imgPhone = selectedImage;
        }
    }
}
