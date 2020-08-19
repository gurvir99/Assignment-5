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
            SetInfo();
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

        public void SetInfo()
        {

            var manufacturer = ComputerDataGridView.SelectedRows[0].Cells[2].Value;
            var id = ComputerDataGridView.SelectedRows[0].Cells[0].Value;
            var model = ComputerDataGridView.SelectedRows[0].Cells[3].Value;
            var cost = ComputerDataGridView.SelectedRows[0].Cells[1].Value;
            var cpuBrand = ComputerDataGridView.SelectedRows[0].Cells[10].Value;
            var cpuType = ComputerDataGridView.SelectedRows[0].Cells[11].Value;
            var cpuSpeed = ComputerDataGridView.SelectedRows[0].Cells[12].Value;
            var cpuNumber = ComputerDataGridView.SelectedRows[0].Cells[13].Value;
            var condition = ComputerDataGridView.SelectedRows[0].Cells[14].Value;
            var os = ComputerDataGridView.SelectedRows[0].Cells[15].Value;
            var platform = ComputerDataGridView.SelectedRows[0].Cells[16].Value;
            var hdd = ComputerDataGridView.SelectedRows[0].Cells[17].Value;
            var gpuType = ComputerDataGridView.SelectedRows[0].Cells[19].Value;
            var webcam = ComputerDataGridView.SelectedRows[0].Cells[30].Value;
            var lcd = ComputerDataGridView.SelectedRows[0].Cells[7].Value;
            var memory = ComputerDataGridView.SelectedRows[0].Cells[4].Value;

            Program.infoClass.productID = id.ToString();
            Program.infoClass.condition = condition.ToString();
            Program.infoClass.platform = platform.ToString();
            Program.infoClass.os = os.ToString();
            Program.infoClass.webcam= webcam.ToString();
            Program.infoClass.cpuBrand = cpuBrand.ToString();
            Program.infoClass.cpuType = cpuType.ToString();
            Program.infoClass.cpuNumber = cpuNumber.ToString();
            Program.infoClass.cpuSpeed = cpuSpeed.ToString();
            Program.infoClass.cost = cost.ToString();
            Program.infoClass.lcdSize = lcd.ToString();
            Program.infoClass.hdd = hdd.ToString();
            Program.infoClass.gpuType= gpuType.ToString();
            Program.infoClass.manufacturer = manufacturer.ToString();
            Program.infoClass.model = model.ToString();
            Program.infoClass.memory = memory.ToString();
        }
    }
}
