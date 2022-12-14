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

namespace DemoControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static bool toogleBirdPicture = false;

        public MainWindow()
        {
            InitializeComponent();

            //Modify properties from CodeBehind
            //myTextBlock.Background = Brushes.Purple;
            //BuildANewTextBlock();       //Overwrites existing one
            //GetSelectedDate();
        }

        //private void GetSelectedDate() 
        //{
        //    myTextBlock.Text= myCalendar.SelectedDate.ToString();
        //}

        private void BuildANewTextBlock()
        {
            TextBlock myTb = new TextBlock();
            myTb.Text = "A dynamic TextBlock generated in CodeBehind";
            myTb.Inlines.Add(" this is added using Inlines!");

            myTb.Inlines.Add(new Run(" Run the text later") 
            {
                Foreground = Brushes.Red,
                TextDecorations = TextDecorations.Underline
            });

            this.Content = myTb;
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            //Uses the default browser
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }

		private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
		{

			if ((sender as DatePicker).SelectedDate != null) 
			{
				string userSelectedDate = (sender as DatePicker).SelectedDate.ToString();
				MessageBox.Show($"Date has been changed to {userSelectedDate}");

			}

		}

		//private void myCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
		//{
		//    if (myTextBlock != null)
		//    {
		//        GetSelectedDate();
		//    }

		//}

		//private void imgBird_MouseUp(object sender, MouseButtonEventArgs e)
		//{
		//    toogleBirdPicture = !toogleBirdPicture;

		//    string fileName = toogleBirdPicture ? "ostrich.jpg" : "kivi.jpg";

		//    //string fileName = "ostrich.jpg";

		//    imgBird.Source = new BitmapImage(
		//        new Uri(@"/DemoControls;component/Images/" + fileName, UriKind.Relative));
		//}

		//private void mySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		//{
		//    if (myTextBlock != null)
		//    {
		//        int sliderValue = (int)mySlider.Value;
		//        double fontSize = (int)myTextBlock.FontSize;
		//        if (sliderValue < 10)
		//            fontSize = 10;
		//        else if (sliderValue < 20)
		//            fontSize = 14;
		//        else if (sliderValue < 30)
		//            fontSize = 18;
		//        else if (sliderValue < 40)
		//            fontSize = 22;
		//        else if (sliderValue < 50)
		//            fontSize = 26;
		//        else if (sliderValue < 60)
		//            fontSize = 30;
		//        else if (sliderValue < 70)
		//            fontSize = 34;
		//        else if (sliderValue < 80)
		//            fontSize = 38;
		//        else
		//            fontSize= 42;

		//        myTextBlock.FontSize = fontSize;
		//        myTextBlock.Text = "Slider value is " + mySlider.Value.ToString();
		//    }
		//}

		//private void cbExtraCheese_Checked(object sender, RoutedEventArgs e)
		//{
		//    //lbExtraCheese.FontSize += 2;
		//    lbExtraCheese.FontWeight = FontWeights.Bold;
		//    lbExtraCheese.Background = Brushes.LightGreen;
		//}

		//private void cbExtraCheese_Unchecked(object sender, RoutedEventArgs e)
		//{
		//    //lbExtraCheese.FontSize -= 2;
		//    lbExtraCheese.FontWeight = FontWeights.Normal;
		//    lbExtraCheese.Background = Brushes.BlanchedAlmond;
		//}

		//private void president_selected(object sender, RoutedEventArgs e)
		//{
		//    RadioButton selectedRadioButton = (RadioButton)sender;

		//    selectedRadioButton.FontSize += 2;
		//}

		//private void president_unselected(object sender, RoutedEventArgs e)
		//{
		//    RadioButton selectedRadioButton = (RadioButton)sender;

		//    selectedRadioButton.FontSize -= 2;

		//}

		//Button and events

		//private void Button_Change_Color_Label(object sender, RoutedEventArgs e)
		//{
		//    if (myLabel.Foreground != Brushes.YellowGreen)
		//        myLabel.Foreground = Brushes.YellowGreen;
		//    else
		//        myLabel.Foreground = Brushes.DarkBlue;
		//}

		//private void Button_Increase_Font_Size_For_Label(object sender, RoutedEventArgs e)
		//{
		//    myLabel.FontSize++;
		//}

		//private void Button_Decrease_Font_Size_For_Label(object sender, RoutedEventArgs e)
		//{
		//    if (! (myLabel.FontSize == 1))
		//        myLabel.FontSize--;
		//}

		//private void Button_Increase_Font_Size_ByTen_For_Label(object sender, MouseButtonEventArgs e)
		//{
		//    myLabel.FontSize += 10;
		//}

		//private void Button_Enter_Change_Background_Label(object sender, MouseEventArgs e)
		//{
		//    myLabel.Background = Brushes.DarkKhaki;
		//}

		//private void Button_Leave_Change_Background_Label(object sender, MouseEventArgs e)
		//{
		//    myLabel.Background = Brushes.Coral;
		//}


	}
}
