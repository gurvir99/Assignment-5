using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void ProductInfoGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            this.Hide();
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            IdTextBox.Text = Program.infoClass.productID;
            CostTextBox.Text = Program.infoClass.cost;
            ConditionTextBox.Text = Program.infoClass.condition;
            PlatformTextBox.Text = Program.infoClass.platform;
            ModelTextBox.Text = Program.infoClass.model;
            OSTextBox.Text = Program.infoClass.os;
            ManufacturerTextBox.Text = Program.infoClass.manufacturer;
            MemoryTextBox.Text = Program.infoClass.memory;
            BrandTextBox.Text = Program.infoClass.cpuBrand;
            CPUTypeTextBox.Text = Program.infoClass.cpuType;
            LCDTextBox.Text = Program.infoClass.lcdSize;
            SpeedTextBox.Text = Program.infoClass.cpuSpeed;
            NumberTextBox.Text = Program.infoClass.cpuNumber;
            HDDTextBox.Text = Program.infoClass.hdd;
            GPUTextBox.Text = Program.infoClass.gpuType;
            WebcamTextBox.Text = Program.infoClass.webcam;

            if (IdTextBox.Text == "")
            {
                NextButton.Enabled = false;
            }
            else
            {
                NextButton.Enabled = true;
            }
        }

        private void AnotherButton_Click(object sender, EventArgs e)
        {
           IdTextBox.Clear();
            CostTextBox.Clear();
           ConditionTextBox.Clear();
            PlatformTextBox.Clear();
            ModelTextBox.Clear();
            OSTextBox.Clear();
            ManufacturerTextBox.Clear();
            MemoryTextBox.Clear();
            BrandTextBox.Clear();
            CPUTypeTextBox.Clear();
            LCDTextBox.Clear();
           SpeedTextBox.Clear();
           NumberTextBox.Clear();
            HDDTextBox.Clear();
            GPUTextBox.Clear();
            WebcamTextBox.Clear();

            Program.selectForm.Show();
            this.Hide();
            //Program.infoClass.productID = "";
            //Program.infoClass.cost = "";
            // Program.infoClass.condition = "";
            //Program.infoClass.platform = "";
            //Program.infoClass.model = "";
            //Program.infoClass.os = "";
            //Program.infoClass.manufacturer = "";
            //Program.infoClass.memory = "";
            //Program.infoClass.cpuBrand = "";
            //Program.infoClass.cpuType = "";
            //Program.infoClass.lcdSize = "";
            //Program.infoClass.cpuSpeed = "";
            //Program.infoClass.cpuNumber = "";
            //Program.infoClass.hdd = "";
            //Program.infoClass.gpuType = "";
            //Program.infoClass.webcam = "";

            //IdTextBox.Clear();
            //CostTextBox.Clear();
            //ConditionTextBox.Clear();
            //PlatformTextBox.Clear();
            //ModelTextBox.Clear();
            //OSTextBox.Clear();
            //ManufacturerTextBox.Clear();
            //MemoryTextBox.Clear();
            //BrandTextBox.Clear();
            //CPUTypeTextBox.Clear();
            //LCDTextBox.Clear();
            //SpeedTextBox.Clear();
            //NumberTextBox.Clear();
            //HDDTextBox.Clear();
            //GPUTextBox.Clear();
            //WebcamTextBox.Clear();
        }

        private void ProductInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            IdTextBox.Text = Program.infoClass.productID;
            CostTextBox.Text = Program.infoClass.cost;
            ConditionTextBox.Text = Program.infoClass.condition;
            PlatformTextBox.Text = Program.infoClass.platform;
            ModelTextBox.Text = Program.infoClass.model;
            OSTextBox.Text = Program.infoClass.os;
            ManufacturerTextBox.Text = Program.infoClass.manufacturer;
            MemoryTextBox.Text = Program.infoClass.memory;
            BrandTextBox.Text = Program.infoClass.cpuBrand;
            CPUTypeTextBox.Text = Program.infoClass.cpuType;
            LCDTextBox.Text = Program.infoClass.lcdSize;
            SpeedTextBox.Text = Program.infoClass.cpuSpeed;
            NumberTextBox.Text = Program.infoClass.cpuNumber;
            HDDTextBox.Text = Program.infoClass.hdd;
            GPUTextBox.Text = Program.infoClass.gpuType;
            WebcamTextBox.Text = Program.infoClass.webcam;

            if (IdTextBox.Text == "")
            {
                NextButton.Enabled = false;
            }
            else
            {
                NextButton.Enabled = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //configure the saveFileDialog
            InfoSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            //display saveFileDialog and save the results in the saveFileDialog object
            var saveFileDialogResult = InfoSaveFileDialog.ShowDialog();

            if(saveFileDialogResult != DialogResult.Cancel)
            {
                //create new streamWriter
                StreamWriter streamWriter = new StreamWriter(InfoSaveFileDialog.FileName);

                //write to file
                streamWriter.WriteLine(IdTextBox.Text);
                streamWriter.WriteLine(CostTextBox.Text);
                streamWriter.WriteLine(ConditionTextBox.Text);
                streamWriter.WriteLine(PlatformTextBox.Text);
                streamWriter.WriteLine(ModelTextBox.Text);
                streamWriter.WriteLine(OSTextBox.Text);
                streamWriter.WriteLine(ManufacturerTextBox.Text);
                streamWriter.WriteLine(MemoryTextBox.Text);
                streamWriter.WriteLine(BrandTextBox.Text);
                streamWriter.WriteLine(CPUTypeTextBox.Text);
                streamWriter.WriteLine(LCDTextBox.Text);
                streamWriter.WriteLine(SpeedTextBox.Text);
                streamWriter.WriteLine(NumberTextBox.Text);
                streamWriter.WriteLine(HDDTextBox.Text);
                streamWriter.WriteLine(GPUTextBox.Text);
                streamWriter.WriteLine(WebcamTextBox.Text); 

                //clean up
                streamWriter.Flush();
                streamWriter.Close();
            }
        }

        private void selectAnotherProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnotherButton_Click(sender, e as EventArgs);
        }

        private void SetInfo(StreamReader streamReader)
        {
            Program.infoClass.productID = streamReader.ReadLine();
            Program.infoClass.cost = streamReader.ReadLine();
            Program.infoClass.condition = streamReader.ReadLine();
            Program.infoClass.platform = streamReader.ReadLine();
            Program.infoClass.model = streamReader.ReadLine();
            Program.infoClass.os = streamReader.ReadLine();
            Program.infoClass.manufacturer = streamReader.ReadLine();
            Program.infoClass.memory = streamReader.ReadLine();
            Program.infoClass.cpuBrand = streamReader.ReadLine();
            Program.infoClass.cpuType = streamReader.ReadLine();
            Program.infoClass.lcdSize = streamReader.ReadLine();
            Program.infoClass.cpuSpeed = streamReader.ReadLine();
            Program.infoClass.cpuNumber = streamReader.ReadLine();
            Program.infoClass.hdd = streamReader.ReadLine();
            Program.infoClass.gpuType = streamReader.ReadLine();
            Program.infoClass.webcam = streamReader.ReadLine();


        }

        private void ShowInfo()
        {
            IdTextBox.Text = Program.infoClass.productID;
            CostTextBox.Text = Program.infoClass.cost;
            ConditionTextBox.Text = Program.infoClass.condition;
            PlatformTextBox.Text = Program.infoClass.platform;
            ModelTextBox.Text = Program.infoClass.model;
            OSTextBox.Text = Program.infoClass.os;
            ManufacturerTextBox.Text = Program.infoClass.manufacturer;
            MemoryTextBox.Text = Program.infoClass.memory;
            BrandTextBox.Text = Program.infoClass.cpuBrand;
            CPUTypeTextBox.Text = Program.infoClass.cpuType;
            LCDTextBox.Text = Program.infoClass.lcdSize;
            SpeedTextBox.Text = Program.infoClass.cpuSpeed;
            NumberTextBox.Text = Program.infoClass.cpuNumber;
            HDDTextBox.Text = Program.infoClass.hdd;
            GPUTextBox.Text = Program.infoClass.gpuType;
            WebcamTextBox.Text = Program.infoClass.webcam;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //configure the openFileDialog
            InfoOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            InfoOpenFileDialog.FileName = "OrderInfo";
            InfoOpenFileDialog.Title = "Open Info";

            //open the dialog
            DialogResult openFileDialogResult = InfoOpenFileDialog.ShowDialog();
            if(openFileDialogResult != DialogResult.Cancel)
            {
                //create streamReader
                StreamReader streamReader = new StreamReader(InfoOpenFileDialog.FileName);

                //read
                SetInfo(streamReader);

                ShowInfo();
                NextButton.Enabled = true;

                //clean
                streamReader.Close();
            }
            
        }
    }
}
