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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            SelectionTextBox.Text = "";
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

            ComputerDataGridView_CellClick(sender, e as DataGridViewCellEventArgs);

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        private void ComputerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var manufacturer = ComputerDataGridView.SelectedRows[0].Cells[2].Value;
            var model = ComputerDataGridView.SelectedRows[0].Cells[3].Value;
            var cost = ComputerDataGridView.SelectedRows[0].Cells[1].Value;
            SelectionTextBox.Text = $@"{manufacturer} {model} Priced at: ${cost}";
        }

        private void SelectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
