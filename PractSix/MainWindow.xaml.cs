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

namespace PractSix
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BLACK_Click(object sender, RoutedEventArgs e)
        {
            Window.Background = new SolidColorBrush(Colors.Black);
        }
        private void GREY_Click(object sender, RoutedEventArgs e)
        {
            Window.Background = new SolidColorBrush(Colors.Gray);
        }
        private void RED_Click(object sender, RoutedEventArgs e)
        {
            Window.Background = new SolidColorBrush(Colors.Red);
        }
        private void PINK_Click(object sender, RoutedEventArgs e)
        {
            Window.Background = new SolidColorBrush(Colors.Pink);
        }
        private void PERSON_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Жусупова Айман\nПР-31", "О разработчике", MessageBoxButton.OK, MessageBoxImage.Question);
        }
        private void Menu_MouseEnter(object sender, RoutedEventArgs e)
        {
            CursorPosition.Text = "Изменение окна...";
        }
        private void Close_MouseEnter(object sender, RoutedEventArgs e)
        {
            CursorPosition.Text = "Закрыть окно...";
        }
        private void YOU_MouseEnter(object sender, RoutedEventArgs e)
        {
            CursorPosition.Text = "Информация о разработчике...";
        }
        private void Color_MouseEnter(object sender, RoutedEventArgs e)
        {
            CursorPosition.Text = "Изменить цвет окна...";
        }
        private void ToolBarColor_MouseEnter(object sender, RoutedEventArgs e)
        {
            CursorPosition.Text = "Изменить цвет окна...";
        }
        private void ToolBarYOU_MouseEnter(object sender, RoutedEventArgs e)
        {
            CursorPosition.Text = "Информация о разработчике...";
        }
        private void ToolBarClose_MouseEnter(object sender, RoutedEventArgs e)
        {
            CursorPosition.Text = "Закрыть окно...";
        }
        private void Button_MouseLeave(object sender, RoutedEventArgs e)
        {
            CursorPosition.Text = "";
        }
    }
}
