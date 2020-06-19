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

namespace WPFMetanitTestSimple
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string text = textBox1.Text;
            //if (text != "")
            //{
            //    MessageBox.Show(text);
            //}
            textBox1.Text = textBox1.Text.ToUpper();
            textBox2.Text = "Add some static text";
        }

        private void button1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            textBox3.Text = "Double clic";
        }
    }
}
