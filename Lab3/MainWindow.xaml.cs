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

namespace Lab3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(sparrowLTextBox.Text, out double sparrowL) && double.TryParse(crowLTextBox.Text, out double crowL))
            {
                Sparrow sparrow = new Sparrow { L = sparrowL };
                Crow crow = new Crow { L = crowL };

                sparrowResultLabel.Text = $"Кількість іжі, необхідної лелекам: {sparrow.FoodRequired}";
                crowResultLabel.Text = $"Кількість іжі, необхідної воронам: {crow.Height}";
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректні значення для L.");
            }
        }

    }
}
