using System;
using System.Collections;
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
namespace HW2
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
            string num_str = textbox_1.Text;
            int num_int;
            bool success = int.TryParse(num_str, out num_int);
            ArrayList list = new ArrayList();
            if (textbox_1.Text.Length == 0 || !success || num_int < 0)
            {
                MessageBox.Show("請重新輸入");
            }
            for (int i = 2; i <= num_int; i++)
            {
                bool flag = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    list.Add(i);
                }
            }
            int[] aa = (int[])list.ToArray(typeof(int));
            textbox_2.Text = "";
            textbox_2.Text += $"小於等於{num_int}的質數為";
            foreach (var item in aa)
            {
                textbox_2.Text += $"{item} ";
            }
            textbox_2.Text += $"\n";
            foreach (var i in aa)
            {
                textbox_2.Text += $"{i}的倍數：";
                for (int j = 2; j <= num_int; j++)
                {
                    if (j % i == 0)
                    {
                        textbox_2.Text += $"{j} ";
                    }
                }
                textbox_2.Text += $"\n";
            }
        }
    }
}