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

namespace OZHI_AWDS
{
    /// <summary>
    /// Interaction logic for BrowseClients.xaml
    /// </summary>
    public partial class BrowseClients : Page
    {
        public BrowseClients()
        {
            InitializeComponent();

            InitializeTextBlocks();
        }

        private void InitializeTextBlocks()
        {
            FirstNationTextBlock.FontSize = 13.3333;
            FirstNationTextBlock.Padding = new Thickness(0, 10, 10, 10);
            FirstNationTextBlock.Margin = new Thickness(0, 0, 15, 0);

            FirstNationContactNameTextBlock.FontSize = 13.3333;
            FirstNationContactNameTextBlock.Padding = new Thickness(0, 10, 10, 10);
            FirstNationContactNameTextBlock.Margin = new Thickness(0, 0, 15, 0);

            FirstNationContactPhoneTextBlock.FontSize = 13.3333;
            FirstNationContactPhoneTextBlock.Padding = new Thickness(0, 10, 10, 10);
            FirstNationContactPhoneTextBlock.Margin = new Thickness(0, 0, 15, 0);

            FirstNationContactEmailTextBlock.FontSize = 13.3333;
            FirstNationContactEmailTextBlock.Padding = new Thickness(0, 10, 10, 10);
            FirstNationContactEmailTextBlock.Margin = new Thickness(0, 0, 15, 0);

            ApplicantNameTextBlock.FontSize = 13.3333;
            ApplicantNameTextBlock.Padding = new Thickness(0, 10, 10, 10);
            ApplicantNameTextBlock.Margin = new Thickness(0, 0, 15, 0);

            AlternateNameTextBlock.FontSize = 13.3333;
            AlternateNameTextBlock.Padding = new Thickness(0, 10, 10, 10);
            AlternateNameTextBlock.Margin = new Thickness(0, 0, 15, 0);

            ApplicantTelephoneTextBlock.FontSize = 13.3333;
            ApplicantTelephoneTextBlock.Padding = new Thickness(0, 10, 10, 10);
            ApplicantTelephoneTextBlock.Margin = new Thickness(0, 0, 15, 0);

            AddressTextBlock.FontSize = 13.3333;
            AddressTextBlock.Padding = new Thickness(0, 10, 10, 10);
            AddressTextBlock.Margin = new Thickness(0, 0, 15, 0);

            CityTextBlock.FontSize = 13.3333;
            CityTextBlock.Padding = new Thickness(0, 10, 10, 10);
            CityTextBlock.Margin = new Thickness(0, 0, 15, 0);

            ProvinceTextBlock.FontSize = 13.3333;
            ProvinceTextBlock.Padding = new Thickness(0, 10, 10, 10);
            ProvinceTextBlock.Margin = new Thickness(0, 0, 15, 0);

            PostalCodeTextBlock.FontSize = 13.3333;
            PostalCodeTextBlock.Padding = new Thickness(0, 10, 10, 10);
            PostalCodeTextBlock.Margin = new Thickness(0, 0, 15, 0);

            ServiceComboBox.FontSize = 13.3333;
            ServiceComboBox.Padding = new Thickness(0, 10, 10, 10);
            ServiceComboBox.Margin = new Thickness(0, 0, 15, 0);

            CMHCAccountNumberTextBlock.FontSize = 13.3333;
            CMHCAccountNumberTextBlock.Padding = new Thickness(0, 10, 10, 10);
            CMHCAccountNumberTextBlock.Margin = new Thickness(0, 0, 15, 0);

            CMHCContactNameTextBlock.FontSize = 13.3333;
            CMHCContactNameTextBlock.Padding = new Thickness(0, 10, 10, 10);
            CMHCContactNameTextBlock.Margin = new Thickness(0, 0, 15, 0);

            CMHCContactPhoneTextBlock.FontSize = 13.3333;
            CMHCContactPhoneTextBlock.Padding = new Thickness(0, 10, 10, 10);
            CMHCContactPhoneTextBlock.Margin = new Thickness(0, 0, 15, 0);

            CMHCContactEmailTextBlock.FontSize = 13.3333;
            CMHCContactEmailTextBlock.Padding = new Thickness(0, 10, 10, 10);
            CMHCContactEmailTextBlock.Margin = new Thickness(0, 0, 15, 0);

            CMHCDateRequiredTextBlock.FontSize = 13.3333;
            CMHCDateRequiredTextBlock.Padding = new Thickness(0, 10, 10, 10);
            CMHCDateRequiredTextBlock.Margin = new Thickness(0, 0, 15, 0);

            ClientIDTextBlock.FontSize = 13.3333;
            ClientIDTextBlock.Padding = new Thickness(0, 10, 10, 10);
            ClientIDTextBlock.Margin = new Thickness(0, 0, 15, 0);

            InspectionDateTextBlock.FontSize = 13.3333;
            InspectionDateTextBlock.Padding = new Thickness(0, 10, 10, 10);
            InspectionDateTextBlock.Margin = new Thickness(0, 0, 15, 0);

            InspectorTextBlock.FontSize = 13.3333;
            InspectorTextBlock.Padding = new Thickness(0, 10, 10, 10);
            InspectorTextBlock.Margin = new Thickness(0, 0, 15, 0);

            AgentReferenceNumberTextBlock.FontSize = 13.3333;
            AgentReferenceNumberTextBlock.Padding = new Thickness(0, 10, 10, 10);
            AgentReferenceNumberTextBlock.Margin = new Thickness(0, 0, 15, 0);

            LegalDescriptionTextBlock.FontSize = 13.3333;
            LegalDescriptionTextBlock.Padding = new Thickness(0, 10, 10, 10);
            LegalDescriptionTextBlock.Margin = new Thickness(0, 0, 15, 0);

            LoanTypeTextBlock.FontSize = 13.3333;
            LoanTypeTextBlock.Padding = new Thickness(0, 10, 10, 10);
            LoanTypeTextBlock.Margin = new Thickness(0, 0, 15, 0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Hand;
            Button b = (Button)sender;
            BrushConverter bc = new BrushConverter();
            b.Background = (Brush)bc.ConvertFrom("#8BC63E");
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void NewClientCancelButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Hand;
            Button b = (Button)sender;
            BrushConverter bc = new BrushConverter();
            b.Background = (Brush)bc.ConvertFrom("#777777");
        }

        private void NewClientCancelButton_MouseLeave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void ProvinceComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ProvinceTextBlock.Foreground = Brushes.Black;
        }

        private void ServiceComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void PostalCodeTextBox_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Works");
        }

        private void ProvinceTextBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            ProvincePopup.IsOpen = true;
        }
    }
}
