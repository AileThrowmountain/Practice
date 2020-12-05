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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMessage_Click(object sender, RoutedEventArgs e)
        {
            btnmsg.ShowMessage();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string name = textBoxName.Text;
            nmsg.ReturnNameMessage(name);

        }
    }
}
