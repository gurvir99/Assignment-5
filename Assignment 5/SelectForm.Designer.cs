namespace Assignment_5
{
    partial class SelectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SelectionLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.SelectionTextBox = new System.Windows.Forms.TextBox();
            this.ComputerDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.White;
            this.TitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Black;
            this.TitleLabel.Location = new System.Drawing.Point(17, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(278, 27);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "DollarComputer Hardware List";
            // 
            // SelectionLabel
            // 
            this.SelectionLabel.BackColor = System.Drawing.SystemColors.Control;
            this.SelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionLabel.ForeColor = System.Drawing.Color.Black;
            this.SelectionLabel.Location = new System.Drawing.Point(12, 497);
            this.SelectionLabel.Name = "SelectionLabel";
            this.SelectionLabel.Size = new System.Drawing.Size(153, 27);
            this.SelectionLabel.TabIndex = 0;
            this.SelectionLabel.Text = "Your Selection";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(597, 542);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(116, 49);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(732, 542);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(116, 49);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // SelectionTextBox
            // 
            this.SelectionTextBox.BackColor = System.Drawing.Color.White;
            this.SelectionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionTextBox.Location = new System.Drawing.Point(171, 498);
            this.SelectionTextBox.Name = "SelectionTextBox";
            this.SelectionTextBox.ReadOnly = true;
            this.SelectionTextBox.Size = new System.Drawing.Size(677, 26);
            this.SelectionTextBox.TabIndex = 2;
            // 
            // ComputerDataGridView
            // 
            this.ComputerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComputerDataGridView.Location = new System.Drawing.Point(17, 62);
            this.ComputerDataGridView.Name = "ComputerDataGridView";
            this.ComputerDataGridView.RowHeadersWidth = 51;
            this.ComputerDataGridView.RowTemplate.Height = 24;
            this.ComputerDataGridView.Size = new System.Drawing.Size(831, 398);
            this.ComputerDataGridView.TabIndex = 3;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 603);
            this.Controls.Add(this.ComputerDataGridView);
            this.Controls.Add(this.SelectionTextBox);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SelectionLabel);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectForm";
            this.Text = "SelectForm";
            ((System.ComponentModel.ISupportInitialize)(this.ComputerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label SelectionLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TextBox SelectionTextBox;
        private System.Windows.Forms.DataGridView ComputerDataGridView;
    }
}