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

namespace Practice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ButtonMessageClass btnmsg = new ButtonMessageClass();
        public NameMessageBoxClass nmsg = new NameMessageBoxClass();
        public ButtonClickedNotClickedClass btnclick = new ButtonClickedNotClickedClass();
        public CalculateClass calcvariabel = new CalculateClass();
        public MainWindow()
        {
            InitializeComponent();
        }

        bool topButtonClicked = false;
        bool bottomButtonClicked = false;
        private void btnMessage_Click(object sender, RoutedEventArgs e)
        {
            btnmsg.ShowMessage();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string name = textBoxName.Text;
            nmsg.ReturnNameMessage(name);

        }

        private void btnU3top_Click(object sender, RoutedEventArgs e)
        {
            bottomButtonClicked = false;
            topButtonClicked = true;
            btnU3top.Content = btnclick.ItIsClicked(topButtonClicked);
            btnU3bottom.Content = btnclick.ItIsNotClicked(bottomButtonClicked);

        }

        private void btnU3bottom_Click(object sender, RoutedEventArgs e)
        {
            topButtonClicked = false;
            bottomButtonClicked = true;
            btnU3bottom.Content = btnclick.ItIsClicked(bottomButtonClicked);
            btnU3top.Content = btnclick.ItIsNotClicked(topButtonClicked);

        }

        private void btnShowPassword_Click(object sender, RoutedEventArgs e)
        {
            labelPassword.Visibility = Visibility.Visible;
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            int numberOne;
            int numberTwo;
            if (int.TryParse(txtBxFirst.Text, out numberOne) && int.TryParse(txtBxSecond.Text, out numberTwo))
            {
                if (numberOne >= 0 && numberOne <= 9 || numberTwo >= 0 && numberTwo <= 9)
                {
                    calcvariabel.FirstNumber = int.Parse(txtBxFirst.Text);
                    calcvariabel.SecondNumber = int.Parse(txtBxSecond.Text);
                    labelResultShow.Content = calcvariabel.CalculateSum();
                }
                else
                {
                    MessageBox.Show("Skriv in heltal!");
                }
            }
            else
            {
                MessageBox.Show("Skriv in heltal!");
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearTextBoxes();
        }

        //metoder
        private void ClearTextBoxes()
        { 
            txtBxFirst.Clear();
            txtBxSecond.Clear();
            labelResultShow.Content = "";
        }

        

    }
}
