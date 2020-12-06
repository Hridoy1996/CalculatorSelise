using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorSelise
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }


        private void digitClick(object sender, EventArgs e)
        {
            if (monitor.Text == "0" || isOperationPerformed)
                monitor.Clear();
            Button digit = (Button)sender;
            isOperationPerformed = false;
            if ( digit.Text == ".")
            {
                if(!monitor.Text.Contains("."))
                    monitor.Text = monitor.Text + digit.Text;

            }
            else
            {
                monitor.Text = monitor.Text + digit.Text;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void operatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            isOperationPerformed = true;

            if (result != 0)
                equalButton.PerformClick();
            else
                result = Double.Parse(monitor.Text);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            monitor.Text = "0";
            result = 0;
        }

        private void AC(object sender, EventArgs e)
        {
            monitor.Text = "0";
            result = 0;
        }

        private void equalClick(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    monitor.Text = (result + Double.Parse(monitor.Text)).ToString();
                    break;
                case "/":
                    monitor.Text = (result / Double.Parse(monitor.Text)).ToString();
                    break;
                case "*":
                    monitor.Text = (result * Double.Parse(monitor.Text)).ToString();
                    break;
                case "-":
                    monitor.Text = (result - Double.Parse(monitor.Text)).ToString();
                    break;
               
            }
            result = Double.Parse(monitor.Text);
        }
    }
}
