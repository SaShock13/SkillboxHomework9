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

namespace SkillboxHomework9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        void Split()
        {
            string[] splited = this.tbSplit.Text.Split(' ');
            this.splitResult.Items.Clear();
            foreach (var item in splited)
            {
                this.splitResult.Items.Add(item);
            }
        }

        void Reverse()
        {
            string[] splited = this.tbReverse.Text.Split(' ').Reverse().ToArray();
            this.reverseResult.Text=string.Empty;
            foreach (var item in splited)
            {
                this.reverseResult.Text += $"{item} ";
            }
        }

        private void SplitBtnClick(object sender, RoutedEventArgs e)
        {
            Split();
        }

        private void ReverseBtnClick(object sender, RoutedEventArgs e)
        {
            Reverse();
        }

        private void tb_GotFocus(object sender, RoutedEventArgs e)
        {
            if ((sender as TextBox).Text == "Введите предложение")
            {

                (sender as TextBox).Text = string.Empty;

                (sender as TextBox).Foreground = Brushes.Black; 
            }
        }

        private void tb_LostFocus(object sender, RoutedEventArgs e)
        {
            if ((sender as TextBox).Text== "")
            {

                (sender as TextBox).Text = "Введите предложение";

                (sender as TextBox).Foreground = Brushes.LightSlateGray; 
            }
        }
    }
}
