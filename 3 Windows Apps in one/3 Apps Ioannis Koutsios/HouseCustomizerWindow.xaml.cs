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

namespace Final_Practices___Ioannis_Koutsios
{
    /// <summary>
    /// Interaction logic for HouseCustomizerWindow.xaml
    /// </summary>
    public partial class HouseCustomizerWindow : Window
    {
        public HouseCustomizerWindow()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            string message = "Please confirm you are looking for a house with ";

            // Add color
            if (RedRadioButton.IsChecked == true)
                message += "Red walls ";
            else if (BlueRadioButton.IsChecked == true)
                message += "Blue walls ";
            else if (GreenRadioButton.IsChecked == true)
                message += "Green walls ";

            // Add number of bedrooms
            message += $"and {NumberOfBedroomsTextBox.Text} bedrooms ";

            // Options
            message += "with following options:";

            if (SwimmingPoolCheckBox.IsChecked == true)
                message += " Swimming Pool";

            if (SolarRoofCheckBox.IsChecked == true)
                message += " Solar Roof";

            if (GardenCheckBox.IsChecked == true)
                message += " Garden";

            var userChoice = MessageBox.Show(message, "Description", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (userChoice == MessageBoxResult.Yes)
                MessageBox.Show("Thank you");
        }
    }
}
