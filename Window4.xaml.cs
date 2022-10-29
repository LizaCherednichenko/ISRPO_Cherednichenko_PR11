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

namespace ISRPO_Cherednichenko_PR11
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainCanvas.Children.Clear();

            int N = 10;
            try
            {
                N = Convert.ToInt32(FigureCount.Text);
            }
            catch (Exception ee)
            {
                this.Title = "Только целое число!";
            }
            GenerteShapes(N);
        }

        private void GenerteShapes(int N)
        {
            Random rndButton = new Random(DateTime.Now.Millisecond);
            Random rndStyle = new Random(DateTime.Now.Millisecond);
            Random rndPosition = new Random(DateTime.Now.Millisecond);
            Random rndSize = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < N; i++)
            {
                Button currentShape;
                int shapeType = rndButton.Next(0, 2);
                currentShape = new Button();
                

                int shareStyle = rndStyle.Next(0, 4) + 1;
                String styleName = "style" + shareStyle.ToString();
                Style currentStyle = (Style)this.FindResource(styleName);
                currentShape.Style = currentStyle;

                currentShape.Width = rndSize.Next(15, 250);
                currentShape.Height = rndSize.Next(20, 200);

                MainCanvas.Children.Add(currentShape);
                Canvas.SetLeft(currentShape, rndPosition.Next(15, 700));
                Canvas.SetTop(currentShape, rndPosition.Next(15, 300));
            }
        }

    }
}
