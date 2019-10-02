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

namespace Radio_Button
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
            this.Close();
        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if ((bool)addition.IsChecked)
                    Addition();
                else
                    if ((bool)subtraction.IsChecked)
                        Subtraction();
                    else
                        if ((bool)multiplication.IsChecked)
                            Multiplication();
                        else
                            if ((bool)division.IsChecked)
                                Division();
                            else
                                if ((bool)remainder.IsChecked)
                                    Remainder();
            }

            catch (Exception caught)
            {

                expression.Text = "";

                result.Text = caught.Message;

            }
        }

        private void Addition()
        {
            double lhs = Double.Parse(lhsOperand.Text);
            double rhs = Double.Parse(rhsOperand.Text);
            double outcome = 0;
            // TODO: cộng lhs và rhs, lưu trong outcome
            outcome = lhs + rhs;
            expression.Text = lhsOperand.Text + " + " + rhsOperand.Text;
            result.Text = outcome.ToString();
        }

        private void Subtraction()
        {
            double lhs = Double.Parse(lhsOperand.Text);
            double rhs = Double.Parse(rhsOperand.Text);
            double outcome = 0;
            // TODO: tru lhs và rhs, lưu trong outcome
            outcome = lhs - rhs;
            expression.Text = lhsOperand.Text + " - " + rhsOperand.Text;
            result.Text = outcome.ToString();
        }

        private void Multiplication()
        {
            double lhs = Double.Parse(lhsOperand.Text);
            double rhs = Double.Parse(rhsOperand.Text);
            double outcome = 0;
            // TODO: nhan lhs và rhs, lưu trong outcome
            outcome = lhs * rhs;
            expression.Text = lhsOperand.Text + " * " + rhsOperand.Text;
            result.Text = outcome.ToString();
        }

        private void Division()
        {
            double lhs = Double.Parse(lhsOperand.Text);
            double rhs = Double.Parse(rhsOperand.Text);
            double outcome = 0;

            if (rhs == 0)
                MessageBox.Show("error");
            else
            {
                // TODO: chia lhs và rhs, lưu trong outcome
                outcome = lhs / rhs;
                expression.Text = lhsOperand.Text + " / " + rhsOperand.Text;
                result.Text = outcome.ToString();
            }
        }

        private void Remainder()
        {
            double lhs = Double.Parse(lhsOperand.Text);
            double rhs = Double.Parse(rhsOperand.Text);
            double outcome = 0;

            if (rhs == 0)
                MessageBox.Show("error");
            else
            {
                // TODO: chia lay du lhs và rhs, lưu trong outcome
                outcome = lhs % rhs;
                expression.Text = lhsOperand.Text + " % " + rhsOperand.Text;
                result.Text = outcome.ToString();
            }
        }
    }
}
