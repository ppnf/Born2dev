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

namespace HW_ep60
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

        private void Btn_enter_Click(object sender, RoutedEventArgs e)
        {
            int income = int.Parse(txt_income.Text);
            int pay = int.Parse(txt_pay.Text);
            int need = int.Parse(txt_need.Text);
            int day = need / (income - pay);
            txt_day.Text = "" + day;
        }
    }
}
