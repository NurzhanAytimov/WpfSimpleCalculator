using System;
using System.Collections.Generic;
using System.Data;
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

namespace WPFSimpleCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //получение дочерних элементов
            foreach (UIElement element in Childrengrid.Children)
            {           //перебираем кнопки
                if (element is Button)
                {
                    ((Button)element).Click += Button_Click;
                };
            }
        }
            private void Button_Click(object sender, RoutedEventArgs e)
            {                          //получение значении из кнопки
                string result = (string)((Button)e.OriginalSource).Content;

                if (result == "AC")
                {
                    textresult.Text = "";
                }
                else if (result == "=")
                {
                    string value = new DataTable().Compute(textresult.Text, null).ToString();
                    textresult.Text = value;
                }
                else
                {
                    textresult.Text += result;
                }
            }

        }
    }
    

