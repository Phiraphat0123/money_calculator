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

namespace CalculateMoney
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

            if (txtReceive.Text == "" || txtPayment.Text == "" || txtGoal.Text == "")
            {
                txtResult.Text = "You need to input data first.";
            }
            else
            {
            
                int receive=txtReceive.Text==""?0:int.Parse(txtReceive.Text);
                int payment = txtPayment.Text==""?0:int.Parse(txtPayment.Text);
                int goal = txtGoal.Text==""?0:int.Parse(txtGoal.Text);
            

                int remainADay = receive - payment;
                double days=0;
                if (remainADay > 0) {
                    days = goal / remainADay;
                }
            
                if (days > 0)
                {
                    txtResult.Text = $"You have to save money for {Math.Ceiling(days)} days.";
                }
                else
                {
                
                    txtResult.Text = "You need to spend less money.";
                }

            }
        }
    }
}
