namespace BasicCalculator
{
    partial class FrmBasicCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbInput1 = new System.Windows.Forms.TextBox();
            this.tbInput2 = new System.Windows.Forms.TextBox();
            this.cbOperation = new System.Windows.Forms.ComboBox();
            this.btn_Compute = new System.Windows.Forms.Button();
            this.rtbTotal = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 30F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(124, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic Calculator";
            // 
            // tbInput1
            // 
            this.tbInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput1.Location = new System.Drawing.Point(22, 98);
            this.tbInput1.Name = "tbInput1";
            this.tbInput1.Size = new System.Drawing.Size(430, 44);
            this.tbInput1.TabIndex = 1;
            this.tbInput1.Text = "0";
            // 
            // tbInput2
            // 
            this.tbInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput2.Location = new System.Drawing.Point(12, 290);
            this.tbInput2.Name = "tbInput2";
            this.tbInput2.Size = new System.Drawing.Size(430, 44);
            this.tbInput2.TabIndex = 2;
            this.tbInput2.Text = "0";
            // 
            // cbOperation
            // 
            this.cbOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperation.FormattingEnabled = true;
            this.cbOperation.Location = new System.Drawing.Point(22, 190);
            this.cbOperation.Name = "cbOperation";
            this.cbOperation.Size = new System.Drawing.Size(99, 45);
            this.cbOperation.TabIndex = 3;
            // 
            // btn_Compute
            // 
            this.btn_Compute.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Compute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Compute.Font = new System.Drawing.Font("Impact", 15F);
            this.btn_Compute.ForeColor = System.Drawing.Color.White;
            this.btn_Compute.Location = new System.Drawing.Point(344, 425);
            this.btn_Compute.Name = "btn_Compute";
            this.btn_Compute.Size = new System.Drawing.Size(222, 46);
            this.btn_Compute.TabIndex = 4;
            this.btn_Compute.Text = "Compute";
            this.btn_Compute.UseVisualStyleBackColor = false;
            this.btn_Compute.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbTotal
            // 
            this.rtbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTotal.Location = new System.Drawing.Point(579, 170);
            this.rtbTotal.Name = "rtbTotal";
            this.rtbTotal.Size = new System.Drawing.Size(430, 96);
            this.rtbTotal.TabIndex = 5;
            this.rtbTotal.Text = "";
            // 
            // FrmBasicCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1201, 505);
            this.Controls.Add(this.rtbTotal);
            this.Controls.Add(this.btn_Compute);
            this.Controls.Add(this.cbOperation);
            this.Controls.Add(this.tbInput2);
            this.Controls.Add(this.tbInput1);
            this.Controls.Add(this.label1);
            this.Name = "FrmBasicCalculator";
            this.Text = "FrmBasicCalculator";
            this.Load += new System.EventHandler(this.FrmBasicCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInput1;
        private System.Windows.Forms.TextBox tbInput2;
        private System.Windows.Forms.ComboBox cbOperation;
        private System.Windows.Forms.Button btn_Compute;
        private System.Windows.Forms.RichTextBox rtbTotal;
    }
}

