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
    /// Interaction logic for ShoppingListWindow.xaml
    /// </summary>
    public partial class ShoppingListWindow : Window
    {
        public ShoppingListWindow()
        {
            InitializeComponent();
        }

        private void AddItemButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ItemNameTextBox.Text))
            {
                MessageBox.Show("Please enter the name", "Missing Name", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(ItemQuantityTextBox.Text))
            {
                MessageBox.Show("Please enter the quantity", "Missing Quantity", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (false == int.TryParse(ItemQuantityTextBox.Text, out int quantity))
            {
                MessageBox.Show("Please enter valid quantity", "Invalid Quantity", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            CheckBox checkBox = new CheckBox();
            checkBox.Content = $"{ItemQuantityTextBox.Text}x {ItemNameTextBox.Text}";

            ItemsStackPanel.Children.Add(checkBox);
        }

        private void RemoveSelectedItemsButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < ItemsStackPanel.Children.Count; i++)
            {
                CheckBox checkBox = ItemsStackPanel.Children[i] as CheckBox;
                if (checkBox.IsChecked == true)
                {
                    ItemsStackPanel.Children.RemoveAt(i);
                    --i;
                }
            }
        }
    }
}
