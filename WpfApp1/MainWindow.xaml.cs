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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Problem> problems;
        public MainWindow()
        {
            InitializeComponent();
            problems = new ObservableCollection<Problem>();
            problems.Add(new Problem()
            {
                ProblemName = "Задача 1",
                Description="Выполнить домашнее задание",
                Priority = 2,
                ProblemType=ProblemTypes.Work
            });           
            problems.Add(new Problem()
            {
                ProblemName = "Задача 2",
                Description="Полить цветы",
                Priority = 1,
                ProblemType=ProblemTypes.Home
            });           
            problems.Add(new Problem()
            {
                ProblemName = "Задача 3",
                Description="Приготовить ужин",
                Priority = 1,
                ProblemType=ProblemTypes.Home
            });
            listBox.ItemsSource = problems;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            problems.Add(new Problem()
            {
                ProblemName = "Задача 4",
                Description = "Покормить кота",
                Priority = 1,
                ProblemType = ProblemTypes.Home
            });
            listBox.ItemsSource = problems;
        }
    }
}
