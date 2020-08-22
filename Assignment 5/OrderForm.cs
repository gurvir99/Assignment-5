using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Back_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
            PriceTextBox.Clear();
            ConditionTextBox.Clear();
            PlatformTextBox.Clear();
            ModelTextBox.Clear();
            ManufacturerTextBox.Clear();
            TaxTextBox.Clear();
            TotalTextBox.Clear();
            ComponentsTextBox.Clear();
           
        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            double Price = Convert.ToDouble(Program.infoClass.cost.ToString());
            double tax = (Price * 13) / 100;
            double total = Price + tax;
            ConditionTextBox.Text = Program.infoClass.condition;
            PlatformTextBox.Text = Program.infoClass.platform;
            ModelTextBox.Text = Program.infoClass.model;
            PriceTextBox.Text = "$"+Program.infoClass.cost;
            TaxTextBox.Text = "$" + tax;
            ManufacturerTextBox.Text = Program.infoClass.manufacturer;
            TotalTextBox.Text = "$" + total;
            ComponentsTextBox.Text = Program.infoClass.lcdSize + "\r\n\r\n" +
                                      Program.infoClass.memory + "\r\n\r\n" +
                                      Program.infoClass.cpuBrand + "\r\n\r\n" +
                                      Program.infoClass.cpuType + "\r\n\r\n" +
                                      Program.infoClass.cpuNumber + "\r\n\r\n" +
                                      Program.infoClass.cpuSpeed + "\r\n\r\n" +
                                      Program.infoClass.hdd + "\r\n\r\n" +
                                      Program.infoClass.gpuType + "\r\n\r\n" +
                                      Program.infoClass.webcam + "\r\n\r\n" +
                                      Program.infoClass.os + "\r\n\r\n";
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            double Price = Convert.ToDouble(Program.infoClass.cost.ToString());
            double tax = (Price * 13) / 100;
            double total = Price + tax;
            ConditionTextBox.Text = Program.infoClass.condition;
            PlatformTextBox.Text = Program.infoClass.platform;
            ModelTextBox.Text = Program.infoClass.model;
            PriceTextBox.Text = "$" + Program.infoClass.cost;
            TaxTextBox.Text = "$" + tax;
            ManufacturerTextBox.Text = Program.infoClass.manufacturer;
            TotalTextBox.Text = "$" + total;
            ComponentsTextBox.Text = Program.infoClass.lcdSize + "\r\n\r\n" +
                                      Program.infoClass.memory + "\r\n\r\n" +
                                      Program.infoClass.cpuBrand + "\r\n\r\n" +
                                      Program.infoClass.cpuType + "\r\n\r\n" +
                                      Program.infoClass.cpuNumber + "\r\n\r\n" +
                                      Program.infoClass.cpuSpeed + "\r\n\r\n" +
                                      Program.infoClass.hdd + "\r\n\r\n" +
                                      Program.infoClass.gpuType + "\r\n\r\n" +
                                      Program.infoClass.webcam + "\r\n\r\n" +
                                      Program.infoClass.os + "\r\n\r\n";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Back_Click(sender, e as EventArgs);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutBoxForm.ShowDialog();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            Program.confirmBox.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.printBox.ShowDialog();
        }
    }
}
