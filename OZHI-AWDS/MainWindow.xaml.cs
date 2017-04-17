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
        TextBlock txtBlock6 = new TextBlock();  // 
        TextBlock txtBlock7 = new TextBlock();
        TextBlock txtBlock8 = new TextBlock();

        int height;

        bool clientClicked = false;
        bool workDescriptionClicked = false;
        bool reportsClicked = false;
        bool toolsClicked = false;

        public MainWindow()
        {
            InitializeComponent();

            Main_Window.Loaded += Main_Window_Loaded;

        }

        private void Main_Window_Loaded(object sender, RoutedEventArgs e)
        {
            height = (int) ClientRow.ActualHeight / 2;
            Console.WriteLine(height);

            Initialize_Tabs();
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

            Main_Grid.Children.Add(txtBlock1);
            Main_Grid.Children.Add(txtBlock2);
            Main_Grid.Children.Add(txtBlock3);
            Main_Grid.Children.Add(txtBlock4);
            Main_Grid.Children.Add(txtBlock5);
        }

        private void TxtBlock5_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            

            FrameHolder.Navigate(new System.Uri("Pages/WorkDescription.xaml", UriKind.RelativeOrAbsolute));
        }

        private void TxtBlock4_MouseLeave(object sender, MouseEventArgs e)
        {
            txtBlock4.FontWeight = FontWeights.Normal;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void TxtBlock4_MouseEnter(object sender, MouseEventArgs e)
        {
            txtBlock4.FontWeight = FontWeights.Bold;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void TxtBlock3_MouseLeave(object sender, MouseEventArgs e)
        {
            txtBlock3.FontWeight = FontWeights.Normal;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void TxtBlock3_MouseEnter(object sender, MouseEventArgs e)
        {
            txtBlock3.FontWeight = FontWeights.Bold;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void TxtBlock2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Add_Client_Tabs();

            //FrameHolder.Navigate(new System.Uri("Client.xaml", UriKind.RelativeOrAbsolute));
        }

        private void TxtBlock5_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = null;
            tBlock.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void TxtBlock5_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = (Brush)bc.ConvertFrom("#8BC63E");
            tBlock.Foreground = Brushes.White;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void TxtBlock2_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBlock tBlock = (TextBlock)sender;
            BrushConverter bc = new BrushConverter();
            tBlock.Background = null;
            tBlock.Foreground = Brushes.Black;
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

        private void Add_Client_Tabs()
        {
            double height = ClientRow.ActualHeight;

            if (!clientClicked)
            {
                Main_Grid.RowDefinitions.Remove(RemoveRow);

                double actualHeight = height / 2;

                ClientSub1Row.Height = new GridLength(actualHeight);
                ClientSub2Row.Height = new GridLength(actualHeight);

                clientClicked = true;
            }
        }

        private void Remove_Client_Tabs()
        {

        }

        private void TxtBlock4_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FrameHolder.Navigate(new System.Uri("Pages/Client.xaml", UriKind.RelativeOrAbsolute));
        }

        private void TxtBlock3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FrameHolder.Navigate(new System.Uri("Pages/BrowseClients.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Main_Client_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            Add_Client_Tabs();
        }

        private void FrameHolder_ContentRendered(object sender, EventArgs e)
        {
            FrameHolder.NavigationUIVisibility = NavigationUIVisibility.Hidden;
        }
    }
}
