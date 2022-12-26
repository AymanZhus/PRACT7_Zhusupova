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
using System.Windows.Shapes;

namespace PractSix
{
    /// <summary>
    /// Логика взаимодействия для ExerciseFour.xaml
    /// </summary>
    public partial class ExerciseFour : Window
    {
        public ExerciseFour()
        {
            InitializeComponent();
        }
        private void TextBox(object sender, TextChangedEventArgs e)
        {
            if (Text1.Text == "" && Text2.Text == "")
            {
                CloseButton.IsEnabled = true;
            }
            else
            {
                CloseButton.IsEnabled = false;
            }
        }
    }
}
