using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace HW
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product>products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                Name = "Утюг",
                Price = 3500,
                Category = Categorys.Бытовая_техника,
                Image = "Data/Утюг.jpg"
            });           
            products.Add(new Product()
            {
                Name = "Робот пылесос",
                Price = 35000,
                Category = Categorys.Бытовая_техника,
                Image = "Data/Пылесос.png"
            });            
            products.Add(new Product()
            {
                Name = "Груша",
                Price = 50,
                Category = Categorys.Еда,
                Image = "Data/Груша.jpeg"
            });
            listBox.ItemsSource = products;
        }
    }
}
