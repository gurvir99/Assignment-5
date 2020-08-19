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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

      

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
