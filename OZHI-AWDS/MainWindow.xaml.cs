using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace OZHI_AWDS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        TextBlock txtBlock1 = new TextBlock();  // Title
        TextBlock txtBlock2 = new TextBlock();  // Client
        TextBlock txtBlock3 = new TextBlock();  // Client subtitle 1
        TextBlock txtBlock4 = new TextBlock();  // Client subtitle 2
        TextBlock txtBlock5 = new TextBlock();  // Work Description
        TextBlock txtBlock6 = new TextBlock();  // Reports
        TextBlock txtBlock7 = new TextBlock();  // Reports subtitle 1
        TextBlock txtBlock8 = new TextBlock();  // Reports subtitle 2
        TextBlock txtBlock9 = new TextBlock();  // Tools
        TextBlock txtBlock10 = new TextBlock();  // Tools subtitle 1
        TextBlock txtBlock11 = new TextBlock();  // Tools subtitle 2

        int height;

        bool clientClicked = false;
        bool reportsClicked = false;
        bool toolsClicked = false;

        public MainWindow()
        {
            InitializeComponent();

            Main_Window.Loaded += Main_Window_Loaded;
        }

        private void Main_Window_Loaded(object sender, RoutedEventArgs e)
        {
            height = (int) (ClientRow.ActualHeight / 2) - 7;

            Initialize_Tabs();

            Initialize_Data();
        }

        private void Initialize_Tabs()
        {
            BitmapImage bi = new BitmapImage(new Uri("pack://application:,,,/images/mouse.png"));
            Image image = new Image();
            image.Source = bi;
            image.Height = 14;
            image.Margin = new Thickness(0, 0, 15, 0);
            InlineUIContainer image1 = new InlineUIContainer(image);
            
            txtBlock1.TextWrapping = TextWrapping.Wrap;
            txtBlock1.VerticalAlignment = VerticalAlignment.Center;
            txtBlock1.HorizontalAlignment = HorizontalAlignment.Stretch;
            txtBlock1.FontFamily = new FontFamily("Fonts/OpenSans-Regular.ttf");
            txtBlock1.TextAlignment = TextAlignment.Left;
            txtBlock1.FontSize = 14;
            txtBlock1.Padding = new Thickness(10, 0, 0, 0);
            txtBlock1.Inlines.Add(image1);
            Run run1 = new Run();
            run1.Text = "Welcome to OZHI-AWDS";
            txtBlock1.Inlines.Add(run1);
            Grid.SetColumn(txtBlock1, 0);
            Grid.SetRow(txtBlock1, 0);
            
            txtBlock2.TextWrapping = TextWrapping.Wrap;
            txtBlock2.VerticalAlignment = VerticalAlignment.Stretch;
            txtBlock2.HorizontalAlignment = HorizontalAlignment.Stretch;
            txtBlock2.FontFamily = new FontFamily("Fonts/OpenSans-Regular.ttf");
            txtBlock2.TextAlignment = TextAlignment.Left;
            txtBlock2.FontSize = 14;
            txtBlock2.Padding = new Thickness(35 ,height ,0 ,0);
            Run run2 = new Run();
            run2.Text = "Client";
            txtBlock2.Inlines.Add(run2);
            Grid.SetColumn(txtBlock2, 0);
            Grid.SetRow(txtBlock2, 1);

            txtBlock3.TextWrapping = TextWrapping.Wrap;
            txtBlock3.VerticalAlignment = VerticalAlignment.Stretch;
            txtBlock3.HorizontalAlignment = HorizontalAlignment.Stretch;
            txtBlock3.FontFamily = new FontFamily("Fonts/OpenSans-Regular.ttf");
            txtBlock3.TextAlignment = TextAlignment.Left;
            txtBlock3.FontSize = 14;
            txtBlock3.Padding = new Thickness(35, 5, 0, 0);
            Run run3 = new Run();
            run3.Text = "Browse Clients";
            txtBlock3.Inlines.Add(run3);
            Grid.SetColumn(txtBlock3, 0);
            Grid.SetRow(txtBlock3, 2);

            txtBlock4.TextWrapping = TextWrapping.Wrap;
            txtBlock4.VerticalAlignment = VerticalAlignment.Stretch;
            txtBlock4.HorizontalAlignment = HorizontalAlignment.Stretch;
            txtBlock4.FontFamily = new FontFamily("Fonts/OpenSans-Regular.ttf");
            txtBlock4.TextAlignment = TextAlignment.Left;
            txtBlock4.FontSize = 14;
            txtBlock4.Padding = new Thickness(35, 5, 0, 0);
            Run run4 = new Run();
            run4.Text = "New Client";
            txtBlock4.Inlines.Add(run4);
            Grid.SetColumn(txtBlock4, 0);
            Grid.SetRow(txtBlock4, 3);

            txtBlock5.TextWrapping = TextWrapping.Wrap;
            txtBlock5.VerticalAlignment = VerticalAlignment.Stretch;
            txtBlock5.HorizontalAlignment = HorizontalAlignment.Stretch;
            txtBlock5.FontFamily = new FontFamily("Fonts/OpenSans-Regular.ttf");
            txtBlock5.TextAlignment = TextAlignment.Left;
            txtBlock5.FontSize = 14;
            txtBlock5.Padding = new Thickness(35, height, 0, 0);
            Run run5 = new Run();
            run5.Text = "Work Description";
            txtBlock5.Inlines.Add(run5);
            Grid.SetColumn(txtBlock5, 0);
            Grid.SetRow(txtBlock5, 4);

            txtBlock6.TextWrapping = TextWrapping.Wrap;
            txtBlock6.VerticalAlignment = VerticalAlignment.Stretch;
            txtBlock6.HorizontalAlignment = HorizontalAlignment.Stretch;
            txtBlock6.FontFamily = new FontFamily("Fonts/OpenSans-Regular.ttf");
            txtBlock6.TextAlignment = TextAlignment.Left;
            txtBlock6.FontSize = 14;
            txtBlock6.Padding = new Thickness(35, height, 0, 0);
            Run run6 = new Run();
            run6.Text = "Reports";
            txtBlock6.Inlines.Add(run6);
            Grid.SetColumn(txtBlock6, 0);
            Grid.SetRow(txtBlock6, 6);

            txtBlock7.TextWrapping = TextWrapping.Wrap;
            txtBlock7.VerticalAlignment = VerticalAlignment.Stretch;
            txtBlock7.HorizontalAlignment = HorizontalAlignment.Stretch;
            txtBlock7.FontFamily = new FontFamily("Fonts/OpenSans-Regular.ttf");
            txtBlock7.TextAlignment = TextAlignment.Left;
            txtBlock7.FontSize = 14;
            txtBlock7.Padding = new Thickness(35, 5, 0, 0);
            Run run7 = new Run();
            run7.Text = "Estimate";
            txtBlock7.Inlines.Add(run7);
            Grid.SetColumn(txtBlock7, 0);
            Grid.SetRow(txtBlock7, 7);

            txtBlock8.TextWrapping = TextWrapping.Wrap;
            txtBlock8.VerticalAlignment = VerticalAlignment.Stretch;
            txtBlock8.HorizontalAlignment = HorizontalAlignment.Stretch;
            txtBlock8.FontFamily = new FontFamily("Fonts/OpenSans-Regular.ttf");
            txtBlock8.TextAlignment = TextAlignment.Left;
            txtBlock8.FontSize = 14;
            txtBlock8.Padding = new Thickness(35, 5, 0, 0);
            Run run8 = new Run();
            run8.Text = "Invitation to Bid";
            txtBlock8.Inlines.Add(run8);
            Grid.SetColumn(txtBlock8, 0);
            Grid.SetRow(txtBlock8, 8);

            txtBlock9.TextWrapping = TextWrapping.Wrap;
            txtBlock9.VerticalAlignment = VerticalAlignment.Stretch;
            txtBlock9.HorizontalAlignment = HorizontalAlignment.Stretch;
            txtBlock9.FontFamily = new FontFamily("Fonts/OpenSans-Regular.ttf");
            txtBlock9.TextAlignment = TextAlignment.Left;
            txtBlock9.FontSize = 14;
            txtBlock9.Padding = new Thickness(35, height, 0, 0);
            Run run9 = new Run();
            run9.Text = "Tools";
            txtBlock9.Inlines.Add(run9);
            Grid.SetColumn(txtBlock9, 0);
            Grid.SetRow(txtBlock9, 9);

            txtBlock10.TextWrapping = TextWrapping.Wrap;
            txtBlock10.VerticalAlignment = VerticalAlignment.Stretch;
            txtBlock10.HorizontalAlignment = HorizontalAlignment.Stretch;
            txtBlock10.FontFamily = new FontFamily("Fonts/OpenSans-Regular.ttf");
            txtBlock10.TextAlignment = TextAlignment.Left;
            txtBlock10.FontSize = 14;
            txtBlock10.Padding = new Thickness(35, 5, 0, 0);
            Run run10 = new Run();
            run10.Text = "Business Day Calculator";
            txtBlock10.Inlines.Add(run10);
            Grid.SetColumn(txtBlock10, 0);
            Grid.SetRow(txtBlock10, 10);

            txtBlock11.TextWrapping = TextWrapping.Wrap;
            txtBlock11.VerticalAlignment = VerticalAlignment.Stretch;
            txtBlock11.HorizontalAlignment = HorizontalAlignment.Stretch;
            txtBlock11.FontFamily = new FontFamily("Fonts/OpenSans-Regular.ttf");
            txtBlock11.TextAlignment = TextAlignment.Left;
            txtBlock11.FontSize = 14;
            txtBlock11.Padding = new Thickness(35, 5, 0, 0);
            Run run11 = new Run();
            run11.Text = "Import CSV";
            txtBlock11.Inlines.Add(run11);
            Grid.SetColumn(txtBlock11, 0);
            Grid.SetRow(txtBlock11, 11);

            txtBlock2.MouseEnter += TxtBlock2_MouseEnter;
            txtBlock2.MouseLeave += TxtBlock2_MouseLeave;
            txtBlock2.MouseLeftButtonUp += TxtBlock2_MouseLeftButtonUp;

            txtBlock3.MouseEnter += TxtBlock3_MouseEnter;
            txtBlock3.MouseLeave += TxtBlock3_MouseLeave;
            txtBlock3.MouseLeftButtonUp += TxtBlock3_MouseLeftButtonUp;

            txtBlock4.MouseEnter += TxtBlock4_MouseEnter;
            txtBlock4.MouseLeave += TxtBlock4_MouseLeave;
            txtBlock4.MouseLeftButtonUp += TxtBlock4_MouseLeftButtonUp;

            txtBlock5.MouseEnter += TxtBlock5_MouseEnter;
            txtBlock5.MouseLeave += TxtBlock5_MouseLeave;
            txtBlock5.MouseLeftButtonUp += TxtBlock5_MouseLeftButtonUp;

            txtBlock6.MouseEnter += TxtBlock6_MouseEnter;
            txtBlock6.MouseLeave += TxtBlock6_MouseLeave;
            txtBlock6.MouseLeftButtonUp += TxtBlock6_MouseLeftButtonUp;

            txtBlock7.MouseEnter += TxtBlock7_MouseEnter;
            txtBlock7.MouseLeave += TxtBlock7_MouseLeave;
            txtBlock7.MouseLeftButtonUp += TxtBlock7_MouseLeftButtonUp;

            txtBlock8.MouseEnter += TxtBlock8_MouseEnter;
            txtBlock8.MouseLeave += TxtBlock8_MouseLeave;
            txtBlock8.MouseLeftButtonUp += TxtBlock8_MouseLeftButtonUp;

            txtBlock9.MouseEnter += TxtBlock9_MouseEnter;
            txtBlock9.MouseLeave += TxtBlock9_MouseLeave;
            txtBlock9.MouseLeftButtonUp += TxtBlock9_MouseLeftButtonUp;

            txtBlock10.MouseEnter += TxtBlock10_MouseEnter;
            txtBlock10.MouseLeave += TxtBlock10_MouseLeave;
            txtBlock10.MouseLeftButtonUp += TxtBlock10_MouseLeftButtonUp;

            txtBlock11.MouseEnter += TxtBlock11_MouseEnter;
            txtBlock11.MouseLeave += TxtBlock11_MouseLeave;
            txtBlock11.MouseLeftButtonUp += TxtBlock11_MouseLeftButtonUp;

            Main_Grid.Children.Add(txtBlock1);
            Main_Grid.Children.Add(txtBlock2);
            Main_Grid.Children.Add(txtBlock3);
            Main_Grid.Children.Add(txtBlock4);
            Main_Grid.Children.Add(txtBlock5);
            Main_Grid.Children.Add(txtBlock6);
            Main_Grid.Children.Add(txtBlock7);
            Main_Grid.Children.Add(txtBlock8);
            Main_Grid.Children.Add(txtBlock9);
            Main_Grid.Children.Add(txtBlock10);
            Main_Grid.Children.Add(txtBlock11);
        }

        private void Initialize_Data()
        {

        }

        private void TxtBlock2_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = null;
            tBlock.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }        
        private void TxtBlock3_MouseLeave(object sender, MouseEventArgs e)
        {
            txtBlock3.FontWeight = FontWeights.Normal;
            Mouse.OverrideCursor = Cursors.Arrow;
        }
        private void TxtBlock4_MouseLeave(object sender, MouseEventArgs e)
        {
            txtBlock4.FontWeight = FontWeights.Normal;
            Mouse.OverrideCursor = Cursors.Arrow;
        }
        private void TxtBlock5_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = null;
            tBlock.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }
        private void TxtBlock6_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = null;
            tBlock.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }
        private void TxtBlock7_MouseLeave(object sender, MouseEventArgs e)
        {
            txtBlock7.FontWeight = FontWeights.Normal;
            Mouse.OverrideCursor = Cursors.Arrow;
        }
        private void TxtBlock8_MouseLeave(object sender, MouseEventArgs e)
        {
            txtBlock8.FontWeight = FontWeights.Normal;
            Mouse.OverrideCursor = Cursors.Arrow;
        }
        private void TxtBlock9_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = null;
            tBlock.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }
        private void TxtBlock10_MouseLeave(object sender, MouseEventArgs e)
        {
            txtBlock10.FontWeight = FontWeights.Normal;
            Mouse.OverrideCursor = Cursors.Arrow;
        }
        private void TxtBlock11_MouseLeave(object sender, MouseEventArgs e)
        {
            txtBlock11.FontWeight = FontWeights.Normal;
            Mouse.OverrideCursor = Cursors.Arrow;
        }
        private void TxtBlock2_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = (Brush)bc.ConvertFrom("#8BC63E");
            tBlock.Foreground = Brushes.White;
            Mouse.OverrideCursor = Cursors.Hand;
        }
        private void TxtBlock3_MouseEnter(object sender, MouseEventArgs e)
        {
            txtBlock3.FontWeight = FontWeights.SemiBold;
            Mouse.OverrideCursor = Cursors.Hand;
        }
        private void TxtBlock4_MouseEnter(object sender, MouseEventArgs e)
        {
            txtBlock4.FontWeight = FontWeights.SemiBold;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void TxtBlock5_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = (Brush)bc.ConvertFrom("#8BC63E");
            tBlock.Foreground = Brushes.White;
            Mouse.OverrideCursor = Cursors.Hand;
        }
        private void TxtBlock6_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = (Brush)bc.ConvertFrom("#8BC63E");
            tBlock.Foreground = Brushes.White;
            Mouse.OverrideCursor = Cursors.Hand;
        }
        private void TxtBlock7_MouseEnter(object sender, MouseEventArgs e)
        {
            txtBlock7.FontWeight = FontWeights.SemiBold;
            Mouse.OverrideCursor = Cursors.Hand;
        }
        private void TxtBlock8_MouseEnter(object sender, MouseEventArgs e)
        {
            txtBlock8.FontWeight = FontWeights.SemiBold;
            Mouse.OverrideCursor = Cursors.Hand;
        }
        private void TxtBlock9_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = (Brush)bc.ConvertFrom("#8BC63E");
            tBlock.Foreground = Brushes.White;
            Mouse.OverrideCursor = Cursors.Hand;
        }
        private void TxtBlock10_MouseEnter(object sender, MouseEventArgs e)
        {
            txtBlock10.FontWeight = FontWeights.SemiBold;
            Mouse.OverrideCursor = Cursors.Hand;
        }
        private void TxtBlock11_MouseEnter(object sender, MouseEventArgs e)
        {
            txtBlock11.FontWeight = FontWeights.SemiBold;
            Mouse.OverrideCursor = Cursors.Hand;
        }
        private void TxtBlock2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Remove_Tabs();

            Add_Client_Tabs();
        }
        private void TxtBlock3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FrameHolder.Navigate(new System.Uri("Pages/BrowseClients.xaml", UriKind.RelativeOrAbsolute));
        }

        private void TxtBlock4_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FrameHolder.Navigate(new System.Uri("Pages/Client.xaml", UriKind.RelativeOrAbsolute));
        }
        private void TxtBlock5_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Remove_Tabs();

            FrameHolder.Navigate(new System.Uri("Pages/WorkDescription.xaml", UriKind.RelativeOrAbsolute));
        }
        private void TxtBlock6_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Remove_Tabs();

            Add_Report_Tabs();
        }
        private void TxtBlock7_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FrameHolder.Navigate(new System.Uri("Pages/ReportViewerEstimate.xaml", UriKind.RelativeOrAbsolute));
        }
        private void TxtBlock8_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FrameHolder.Navigate(new System.Uri("Pages/ReportViewerBid.xaml", UriKind.RelativeOrAbsolute));
        }
        private void TxtBlock9_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Remove_Tabs();

            Add_Tools_Tabs();
        }
        private void TxtBlock10_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // TODO Tools Business Day Calculator
        }
        private void TxtBlock11_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // TODO Tools Import CSV to Client List
        }

        private void FrameHolder_ContentRendered(object sender, EventArgs e)
        {
            FrameHolder.NavigationUIVisibility = NavigationUIVisibility.Hidden;
        }
        private void Add_Client_Tabs()
        {
            // TODO - add animations for smooth transitions.

            double height = ClientRow.ActualHeight;

            if (!clientClicked)
            {
                double actualHeight = height / 2;

                ClientSub1Row.Height = new GridLength(25);
                ClientSub2Row.Height = new GridLength(25);

                clientClicked = true;
            }
        }
        private void Add_Report_Tabs()
        {
            double height = ClientRow.ActualHeight;

            if (!reportsClicked)
            {
                double actualHeight = height / 2;

                ReportsSubRow1.Height = new GridLength(25);
                ReportsSubRow2.Height = new GridLength(25);

                reportsClicked = true;
            }
        }

        private void Add_Tools_Tabs()
        {
            double height = ClientRow.ActualHeight;

            if (!toolsClicked)
            {
                double actualHeight = height / 2;

                ToolsSubRow1.Height = new GridLength(25);
                ToolsSubRow2.Height = new GridLength(25);

                toolsClicked = true;
            }
        }

        private void Remove_Tabs()
        {
            if (clientClicked)
            {
                ClientSub1Row.Height = new GridLength(0);
                ClientSub2Row.Height = new GridLength(0);

                clientClicked = false;
            }

            if (reportsClicked)
            {
                ReportsSubRow1.Height = new GridLength(0);
                ReportsSubRow2.Height = new GridLength(0);

                reportsClicked = false;
            }
            if (toolsClicked)
            {
                ToolsSubRow1.Height = new GridLength(0);
                ToolsSubRow2.Height = new GridLength(0);

                toolsClicked = false;
            }
        }
    }
}
