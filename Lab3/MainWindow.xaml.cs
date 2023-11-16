using Lab3;
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

namespace BirdsApp
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Bird> Birds { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Birds = new ObservableCollection<Bird>();
            BirdsListBox.ItemsSource = Birds;
        }

        private void GenerateTests_Click(object sender, RoutedEventArgs e)
        {
            Birds.Clear();

            double totalStorkFoodRequirement = 0.0;
            double totalCrowFoodRequirement = 0.0;

            if (double.TryParse(StorkWingSpanInput.Text, out double baseStorkWingSpan) &&
                double.TryParse(CrowHeightInput.Text, out double baseCrowHeight) &&
                int.TryParse(NumberOfTestsInput.Text, out int numberOfTests))
            {
                for (int i = 0; i < numberOfTests; i++)
                {
                    double storkWingSpan = baseStorkWingSpan + (i * 0.1); // Припустимо, що кожен наступний лелека має на 0.1 більше розмаху крил
                    double crowHeight = baseCrowHeight + (i * 0.05); // І кожна наступна ворона на 0.05 вища

                    Stork newStork = new Stork($"Stork {i + 1}", storkWingSpan);
                    Crow newCrow = new Crow($"Crow {i + 1}", crowHeight);

                    Birds.Add(newStork);
                    Birds.Add(newCrow);

                    totalStorkFoodRequirement += newStork.CalculateFoodRequirement();
                    totalCrowFoodRequirement += newCrow.CalculateFoodRequirement();
                }
                totalStorkFoodRequirementLabel.Content = $"Total Stork Food: {totalStorkFoodRequirement}";
                totalCrowFoodRequirementLabel.Content = $"Total Crow Food: {totalCrowFoodRequirement}";
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for WingSpan, Height, and Number of Tests.");
            }
        }
    }
}
