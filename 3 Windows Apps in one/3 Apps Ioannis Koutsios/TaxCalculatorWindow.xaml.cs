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
    /// Interaction logic for TaxCalculatorWindow.xaml
    /// </summary>
    public partial class TaxCalculatorWindow : Window
    {
        private const double SocialInsurancePercentage = 4.56 / 100;
        private const double AnnualTaxPercentage = 10.0 / 100;
        private const double AnnualTaxThreshold = 25000;

        public TaxCalculatorWindow()
        {
            InitializeComponent();
        }

        private void SalaryAmounthTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateTaxBreakdown();
        }

        private void MonthlySalaryRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            UpdateTaxBreakdown();
        }

        private void AnnualSalaryRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            UpdateTaxBreakdown();
        }

        private void Has13thMonthSalaryCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            UpdateTaxBreakdown();
        }

        private void Has13thMonthSalaryCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            UpdateTaxBreakdown();
        }

        private void UpdateTaxBreakdown()
        {
            double annualSalary, annualSocialInsurance, annualTax, annualNetSalary;

            int monthsCount = 12;
            if (Has13thMonthSalaryCheckBox.IsChecked == true)
                monthsCount = 13;

            // If the input is not valid, no need to proceed further
            if (false == double.TryParse(SalaryAmountTextBox.Text, out double inputSalary))
            {
                MessageBox.Show("Please enter valid value for the salary.", "Invalid Salary", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else if (inputSalary <= 0)
            {
                MessageBox.Show("Please enter a positive value for the salary.", "Invalid Salary", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // If monthly is not selected, then it's annual
            if (MonthlySalaryRadioButton.IsChecked == true)
                annualSalary = inputSalary * monthsCount;
            else
                annualSalary = inputSalary;

            annualSocialInsurance = annualSalary * SocialInsurancePercentage;

            double salaryAfterDeductions = annualSalary - annualSocialInsurance;

            annualTax = GetAnnualTax(salaryAfterDeductions);

            annualNetSalary = salaryAfterDeductions - annualTax;

            // Update Annual Fields
            AnnualGrossValueLabel.Content = "€ " + annualSalary.ToString("N2");
            AnnualTaxValueLabel.Content = "€ " + annualTax.ToString("N2");
            AnnualSocialInsuranceValueLabel.Content = "€ " + annualSocialInsurance.ToString("N2");
            AnnualNetalueLabel.Content = "€ " + annualNetSalary.ToString("N2");

            // Update Monthly Fields
            MonthlyGrossValueLabel.Content = "€ " + (annualSalary / monthsCount).ToString("N2");
            MonthlyTaxValueLabel.Content = "€ " + (annualTax / monthsCount).ToString("N2");
            MonthlySocialInsuranceValueLabel.Content = "€ " + (annualSocialInsurance / monthsCount).ToString("N2");
            MonthlyNetalueLabel.Content = "€ " + (annualNetSalary / monthsCount).ToString("N2");
        }

        private static double GetAnnualTax(double salaryAfterDeductions)
        {
            // If it's below threshold, there is nothing to tax
            if (salaryAfterDeductions < AnnualTaxThreshold)
                return 0;
            else
                return (salaryAfterDeductions - AnnualTaxThreshold) * AnnualTaxPercentage;
        }

        private void SalaryAmountTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
