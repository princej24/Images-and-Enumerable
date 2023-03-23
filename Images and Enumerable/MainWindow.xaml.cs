using Microsoft.Win32;
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

namespace Images_and_Enumerable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string filePath = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rbDark_Checked(object sender, RoutedEventArgs e)
        {
            BitmapImage image = new BitmapImage();
            Uri uri = new Uri(filePath);

            image.BeginInit();
            image.UriSource = uri;
            image.EndInit();

            //display
            imgDisplay.Source = image;
            
            FormatConvertedBitmap greyscale = new FormatConvertedBitmap();
            //Initilaizing
            greyscale.BeginInit();
            //source
            greyscale.Source = image;
            
            greyscale.DestinationFormat = PixelFormats.Gray32Float;

            //end 
            greyscale.EndInit();

            imgDisplay.Source = greyscale;
        }

        private void rbnormal_Checked(object sender, RoutedEventArgs e)
        {
            BitmapImage image = new BitmapImage();
            Uri uri = new Uri(filePath);

            image.BeginInit();
            image.UriSource = uri;
            image.EndInit();

            //display
            imgDisplay.Source = image;

            
            FormatConvertedBitmap greyscale = new FormatConvertedBitmap();
            //Initilaizing
            greyscale.BeginInit();
            //source
            greyscale.Source = image;
            
            greyscale.DestinationFormat = PixelFormats.Cmyk32;

             
            greyscale.EndInit();

            imgDisplay.Source = greyscale;
        }

        private void runDisplay_Click(object sender, RoutedEventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            runDisplay.Text = $" {txtName.Text} - {dateTime} \n {txtBody.Text}";

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            OpenFileDialog files = new OpenFileDialog();

            if (files.ShowDialog() == true)
            {
                filePath = files.FileName;
                
                lbfilePath.Content = filePath;
                
                BitmapImage image = new BitmapImage();
                Uri uri = new Uri(filePath);

                image.BeginInit();
                image.UriSource = uri;
                image.EndInit();

                //display
                imgDisplay.Source = image;

            }
        }
      
      
    }
}
