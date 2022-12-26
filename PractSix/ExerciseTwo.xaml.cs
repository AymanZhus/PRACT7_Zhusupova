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
    /// Логика взаимодействия для ExerciseTwo.xaml
    /// </summary>
    public partial class ExerciseTwo : Window
    {
        RadioButton btnPen = new RadioButton();
        RadioButton btnBrush = new RadioButton();
        public ExerciseTwo()
        {
            InitializeComponent();
        }
        private void ComboBox_Selected(object sender, RoutedEventArgs e)
        {

        }
        private void cmb_RED_SelectionChanged(object sender, RoutedEventArgs e)
        {
            Canvas.DefaultDrawingAttributes.Color = Colors.Red;
        }
        private void cmb_Black_SelectionChanged(object sender, RoutedEventArgs e)
        {
            Canvas.DefaultDrawingAttributes.Color = Colors.Black;
        }
        private void cmb_Gray_SelectionChanged(object sender, RoutedEventArgs e)
        {
            Canvas.DefaultDrawingAttributes.Color = Colors.Gray;
        }
        private void cmb_Pink_SelectionChanged(object sender, RoutedEventArgs e)
        {
            Canvas.DefaultDrawingAttributes.Color = Colors.Pink;
        }
        private void cmb_SeaGreen_SelectionChanged(object sender, RoutedEventArgs e)
        {
            Canvas.DefaultDrawingAttributes.Color = Colors.MediumSeaGreen;
        }
        private void cmb_Lavender_SelectionChanged(object sender, RoutedEventArgs e)
        {
            Canvas.DefaultDrawingAttributes.Color = Colors.Lavender;
        }
        private void SliderPen(object sender, RoutedEventArgs e)
        {
            if (Canvas == null)
            {
                return;
            }
            Canvas.DefaultDrawingAttributes.Width = WidthPen.Value;
            Canvas.DefaultDrawingAttributes.Height = WidthPen.Value;
        }
        private void RadioButton_Erase(object sender, RoutedEventArgs e)
        {
            Canvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }
        private void RadioButton_Pen(object sender, RoutedEventArgs e)
        {
            Canvas.EditingMode = InkCanvasEditingMode.Ink;

        }
        private void RadioButton_Highl(object sender, RoutedEventArgs e)
        {
            Canvas.EditingMode = InkCanvasEditingMode.Select;

        }
        private void RadioButton_Delet(object sender, RoutedEventArgs e)
        {
            Canvas.Strokes.Clear();
        }
    }
}
