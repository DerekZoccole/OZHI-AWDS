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
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            InitializeTextBlocks();

            SelectTextBlock1.MouseEnter += SelectTextBlock1_MouseEnter;
            SelectTextBlock1.MouseLeave += SelectTextBlock1_MouseLeave;
            SelectTextBlock1.MouseUp += SelectTextBlock1_MouseUp;

            AlbertaTextBlock.MouseEnter += AlbertaTextBlock_MouseEnter;
            AlbertaTextBlock.MouseLeave += AlbertaTextBlock_MouseLeave;
            AlbertaTextBlock.MouseUp += AlbertaTextBlock_MouseUp;

            BritishColumbiaTextBlock.MouseEnter += BritishColumbiaTextBlock_MouseEnter;
            BritishColumbiaTextBlock.MouseLeave += BritishColumbiaTextBlock_MouseLeave;

            ManitobaTextBlock.MouseEnter += ManitobaTextBlock_MouseEnter;
            ManitobaTextBlock.MouseLeave += ManitobaTextBlock_MouseLeave;

            NewBrunswickTextBlock.MouseEnter += NewBrunswickTextBlock_MouseEnter;
            NewBrunswickTextBlock.MouseLeave += NewBrunswickTextBlock_MouseLeave;

            NewfoundlandTextBlock.MouseEnter += NewfoundlandTextBlock_MouseEnter;
            NewfoundlandTextBlock.MouseLeave += NewfoundlandTextBlock_MouseLeave;

            NovaScotiaTextBlock.MouseEnter += NovaScotiaTextBlock_MouseEnter;
            NovaScotiaTextBlock.MouseLeave += NovaScotiaTextBlock_MouseLeave;

            OntarioTextBlock.MouseEnter += OntarioTextBlock_MouseEnter;
            OntarioTextBlock.MouseLeave += OntarioTextBlock_MouseLeave;

            PrinceEdwardIslandTextBlock.MouseEnter += PrinceEdwardIslandTextBlock_MouseEnter;
            PrinceEdwardIslandTextBlock.MouseLeave += PrinceEdwardIslandTextBlock_MouseLeave;

            QuebecTextBlock.MouseEnter += QuebecTextBlock_MouseEnter;
            QuebecTextBlock.MouseLeave += QuebecTextBlock_MouseLeave;

            SaskatchewanTextBlock.MouseEnter += SaskatchewanTextBlock_MouseEnter;
            SaskatchewanTextBlock.MouseLeave += SaskatchewanTextBlock_MouseLeave;

            YukonTextBlock.MouseEnter += YukonTextBlock_MouseEnter;
            YukonTextBlock.MouseLeave += YukonTextBlock_MouseLeave;
        }

        private void AlbertaTextBlock_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ProvinceTextBlock.Text = "Alberta";
            ProvinceTextBlock.Foreground = Brushes.Black;
            ProvincePopup.IsOpen = false;
        }

        private void SelectTextBlock1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ProvinceTextBlock.Text = "Select a Province";
            ProvincePopup.IsOpen = false;
        }

        private void QuebecTextBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = null;
            tBlock.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void QuebecTextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = (Brush)bc.ConvertFrom("#8BC63E");
            tBlock.Foreground = Brushes.White;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void YukonTextBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = null;
            tBlock.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void YukonTextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = (Brush)bc.ConvertFrom("#8BC63E");
            tBlock.Foreground = Brushes.White;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void SaskatchewanTextBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = null;
            tBlock.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void SaskatchewanTextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = (Brush)bc.ConvertFrom("#8BC63E");
            tBlock.Foreground = Brushes.White;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void PrinceEdwardIslandTextBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = null;
            tBlock.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void PrinceEdwardIslandTextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = (Brush)bc.ConvertFrom("#8BC63E");
            tBlock.Foreground = Brushes.White;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void OntarioTextBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = null;
            tBlock.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void OntarioTextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = (Brush)bc.ConvertFrom("#8BC63E");
            tBlock.Foreground = Brushes.White;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void NovaScotiaTextBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = null;
            tBlock.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void NovaScotiaTextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = (Brush)bc.ConvertFrom("#8BC63E");
            tBlock.Foreground = Brushes.White;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void NewfoundlandTextBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = null;
            tBlock.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void NewfoundlandTextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = (Brush)bc.ConvertFrom("#8BC63E");
            tBlock.Foreground = Brushes.White;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void NewBrunswickTextBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = null;
            tBlock.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void NewBrunswickTextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = (Brush)bc.ConvertFrom("#8BC63E");
            tBlock.Foreground = Brushes.White;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void ManitobaTextBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = null;
            tBlock.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void ManitobaTextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = (Brush)bc.ConvertFrom("#8BC63E");
            tBlock.Foreground = Brushes.White;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void BritishColumbiaTextBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = null;
            tBlock.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void BritishColumbiaTextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = (Brush)bc.ConvertFrom("#8BC63E");
            tBlock.Foreground = Brushes.White;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void AlbertaTextBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = null;
            tBlock.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void AlbertaTextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = (Brush)bc.ConvertFrom("#8BC63E");
            tBlock.Foreground = Brushes.White;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void SelectTextBlock1_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = null;
            tBlock.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void SelectTextBlock1_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = (Brush)bc.ConvertFrom("#8BC63E");
            tBlock.Foreground = Brushes.White;
            Mouse.OverrideCursor = Cursors.Hand;
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
            //ProvinceTextBlock.Foreground = Brushes.Black;
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
