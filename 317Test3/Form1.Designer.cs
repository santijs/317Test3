
namespace _317Test3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblConversion1Value = new System.Windows.Forms.Label();
            this.lblConversion2Value = new System.Windows.Forms.Label();
            this.numberboxTempValue = new System.Windows.Forms.NumericUpDown();
            this.comboUnits = new System.Windows.Forms.ComboBox();
            this.labelStartTemp = new System.Windows.Forms.Label();
            this.imageTempGuage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numberboxTempValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTempGuage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConversion1Value
            // 
            this.lblConversion1Value.BackColor = System.Drawing.SystemColors.Window;
            this.lblConversion1Value.Location = new System.Drawing.Point(280, 87);
            this.lblConversion1Value.Name = "lblConversion1Value";
            this.lblConversion1Value.Size = new System.Drawing.Size(323, 34);
            this.lblConversion1Value.TabIndex = 0;
            this.lblConversion1Value.Text = "value1";
            this.lblConversion1Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblConversion1Value.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblConversion2Value
            // 
            this.lblConversion2Value.BackColor = System.Drawing.SystemColors.Window;
            this.lblConversion2Value.Location = new System.Drawing.Point(280, 143);
            this.lblConversion2Value.Name = "lblConversion2Value";
            this.lblConversion2Value.Size = new System.Drawing.Size(323, 29);
            this.lblConversion2Value.TabIndex = 1;
            this.lblConversion2Value.Text = "value2";
            this.lblConversion2Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numberboxTempValue
            // 
            this.numberboxTempValue.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.numberboxTempValue.Location = new System.Drawing.Point(296, 6);
            this.numberboxTempValue.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numberboxTempValue.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numberboxTempValue.Name = "numberboxTempValue";
            this.numberboxTempValue.Size = new System.Drawing.Size(150, 30);
            this.numberboxTempValue.TabIndex = 2;
            this.numberboxTempValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numberboxTempValue.ValueChanged += new System.EventHandler(this.numberboxTempValue_ValueChanged);
            // 
            // comboUnits
            // 
            this.comboUnits.FormattingEnabled = true;
            this.comboUnits.Items.AddRange(new object[] {
            "Fahrenheit",
            "Celsius",
            "Kelvin"});
            this.comboUnits.Location = new System.Drawing.Point(452, 6);
            this.comboUnits.Name = "comboUnits";
            this.comboUnits.Size = new System.Drawing.Size(151, 30);
            this.comboUnits.TabIndex = 3;
            this.comboUnits.SelectedIndexChanged += new System.EventHandler(this.comboUnits_SelectedIndexChanged);
            // 
            // labelStartTemp
            // 
            this.labelStartTemp.AutoSize = true;
            this.labelStartTemp.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStartTemp.Location = new System.Drawing.Point(12, 9);
            this.labelStartTemp.Name = "labelStartTemp";
            this.labelStartTemp.Size = new System.Drawing.Size(262, 22);
            this.labelStartTemp.TabIndex = 4;
            this.labelStartTemp.Text = "Starting Temperature:";
            this.labelStartTemp.Click += new System.EventHandler(this.labelStartTemp_Click);
            // 
            // imageTempGuage
            // 
            this.imageTempGuage.Image = global::_317Test3.Properties.Resources.temperaturegauge_none;
            this.imageTempGuage.Location = new System.Drawing.Point(12, 87);
            this.imageTempGuage.Name = "imageTempGuage";
            this.imageTempGuage.Size = new System.Drawing.Size(244, 99);
            this.imageTempGuage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageTempGuage.TabIndex = 5;
            this.imageTempGuage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 193);
            this.Controls.Add(this.imageTempGuage);
            this.Controls.Add(this.labelStartTemp);
            this.Controls.Add(this.comboUnits);
            this.Controls.Add(this.numberboxTempValue);
            this.Controls.Add(this.lblConversion2Value);
            this.Controls.Add(this.lblConversion1Value);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numberboxTempValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTempGuage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConversion1Value;
        private System.Windows.Forms.Label lblConversion2Value;
        private System.Windows.Forms.NumericUpDown numberboxTempValue;
        private System.Windows.Forms.ComboBox comboUnits;
        private System.Windows.Forms.Label labelStartTemp;
        private System.Windows.Forms.PictureBox imageTempGuage;
    }
}

