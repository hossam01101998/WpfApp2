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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CreateControls();
        }

        void CreateControls()
        {
            Label voornaamLabel = new Label()
            {
                Content = "Geef je voornaam:",
                Margin = new Thickness(5)
            };
            Grid2.Children.Add(voornaamLabel);

            Label achternaamLabel = new Label()
            {
                Content = "Geef je achternaam:",
                Margin = new Thickness(5)
            };
            Grid.SetRow(achternaamLabel, 1);
            Grid2.Children.Add(achternaamLabel);

            Label boodschapLabel = new Label()
            {
                Content = "Boodschap:",
                Margin = new Thickness(5)
            };
            Grid.SetRow(boodschapLabel, 2);
            Grid2.Children.Add(boodschapLabel);

            TextBox voornaamTB = new TextBox();
            voornaamTB.Margin = new Thickness(5);
            Grid.SetColumn(voornaamTB, 1);
            Grid2.Children.Add(voornaamTB);

            TextBox achternaamTB = new TextBox();
            achternaamTB.Margin = new Thickness(5);
            Grid.SetColumn(achternaamTB, 1);
            Grid.SetRow(achternaamTB, 1);
            Grid2.Children.Add(achternaamTB);

            TextBox boodschapTB = new TextBox();
            boodschapTB.Margin = new Thickness(5);
            Grid.SetColumn(boodschapTB, 1);
            Grid.SetRow(boodschapTB, 2);
            Grid2.Children.Add(boodschapTB);

            Button submitButton = new Button();
            submitButton.Content = "Verzenden";
            submitButton.Margin = new Thickness(5);
            Grid.SetRow(submitButton, 3);
            Grid2.Children.Add(submitButton);

            Button clearButton = new Button();
            clearButton.Content = "Leegmaken";
            clearButton.Margin = new Thickness(5);
            clearButton.FontSize = 15;
            clearButton.FontWeight = FontWeights.Bold;
            Grid.SetRow(clearButton, 3);
            Grid.SetColumn(clearButton, 1);
            Grid2.Children.Add(clearButton);

            LinearGradientBrush lgb = new LinearGradientBrush();
            lgb.StartPoint = new Point(0, 0.5);
            lgb.EndPoint = new Point(1, 0.5);
            lgb.GradientStops.Add(new GradientStop(Colors.Green, 0.1));
            lgb.GradientStops.Add(new GradientStop(Colors.White, 0.9));
            clearButton.Background = lgb;

        }
    }
}