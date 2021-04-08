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

namespace Overloading
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

        public int Average (int exam1, int exam2)
        {
            return (exam1 + exam2) / 2;
        }

        public int Average(int exam1, int exam2, int project)
        {
            return (exam1 + exam2 + project) / 3;
        }

        private void button_Calculate_Click(object sender, RoutedEventArgs e)
        {
            if (textBox_Project.Text=="")
            {
                MessageBox.Show("Average : "  +  Average(Convert.ToInt32(textBox_Exam1.Text), Convert.ToInt32(textBox_Exam2.Text)));
            }
            else
            {
                MessageBox.Show("Average : " + Average(Convert.ToInt32(textBox_Exam1.Text), Convert.ToInt32(textBox_Exam2.Text), Convert.ToInt32(textBox_Project.Text)));
            }
        }
    }
}
