namespace Графический_редактор
{
    partial class Colors
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
            this.hScrollBarRed = new System.Windows.Forms.HScrollBar();
            this.numericUpDownRed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGreen = new System.Windows.Forms.NumericUpDown();
            this.hScrollBarGreen = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownBlue = new System.Windows.Forms.NumericUpDown();
            this.hScrollBarBlue = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxColor = new System.Windows.Forms.PictureBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonColors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Красный";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hScrollBarRed
            // 
            this.hScrollBarRed.LargeChange = 1;
            this.hScrollBarRed.Location = new System.Drawing.Point(89, 19);
            this.hScrollBarRed.Maximum = 255;
            this.hScrollBarRed.Name = "hScrollBarRed";
            this.hScrollBarRed.Size = new System.Drawing.Size(178, 20);
            this.hScrollBarRed.TabIndex = 1;
            this.hScrollBarRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBarRed_Scroll);
            // 
            // numericUpDownRed
            // 
            this.numericUpDownRed.Location = new System.Drawing.Point(270, 19);
            this.numericUpDownRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRed.Name = "numericUpDownRed";
            this.numericUpDownRed.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownRed.TabIndex = 2;
            this.numericUpDownRed.ValueChanged += new System.EventHandler(this.NumericUpDownRed_ValueChanged);
            // 
            // numericUpDownGreen
            // 
            this.numericUpDownGreen.Location = new System.Drawing.Point(270, 59);
            this.numericUpDownGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownGreen.Name = "numericUpDownGreen";
            this.numericUpDownGreen.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownGreen.TabIndex = 5;
            this.numericUpDownGreen.ValueChanged += new System.EventHandler(this.NumericUpDownGreen_ValueChanged);
            // 
            // hScrollBarGreen
            // 
            this.hScrollBarGreen.LargeChange = 1;
            this.hScrollBarGreen.Location = new System.Drawing.Point(89, 59);
            this.hScrollBarGreen.Maximum = 255;
            this.hScrollBarGreen.Name = "hScrollBarGreen";
            this.hScrollBarGreen.Size = new System.Drawing.Size(178, 20);
            this.hScrollBarGreen.TabIndex = 4;
            this.hScrollBarGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBarGreen_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Зеленый";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownBlue
            // 
            this.numericUpDownBlue.Location = new System.Drawing.Point(270, 97);
            this.numericUpDownBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBlue.Name = "numericUpDownBlue";
            this.numericUpDownBlue.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownBlue.TabIndex = 8;
            this.numericUpDownBlue.ValueChanged += new System.EventHandler(this.NumericUpDownBlue_ValueChanged);
            // 
            // hScrollBarBlue
            // 
            this.hScrollBarBlue.LargeChange = 1;
            this.hScrollBarBlue.Location = new System.Drawing.Point(89, 97);
            this.hScrollBarBlue.Maximum = 255;
            this.hScrollBarBlue.Name = "hScrollBarBlue";
            this.hScrollBarBlue.Size = new System.Drawing.Size(178, 20);
            this.hScrollBarBlue.TabIndex = 7;
            this.hScrollBarBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBarBlue_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Синий";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxColor
            // 
            this.pictureBoxColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxColor.Location = new System.Drawing.Point(317, 19);
            this.pictureBoxColor.Name = "pictureBoxColor";
            this.pictureBoxColor.Size = new System.Drawing.Size(135, 98);
            this.pictureBoxColor.TabIndex = 9;
            this.pictureBoxColor.TabStop = false;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(16, 135);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(82, 26);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(104, 135);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(82, 26);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonColors
            // 
            this.buttonColors.Location = new System.Drawing.Point(317, 135);
            this.buttonColors.Name = "buttonColors";
            this.buttonColors.Size = new System.Drawing.Size(135, 26);
            this.buttonColors.TabIndex = 12;
            this.buttonColors.Text = "Другие цвета";
            this.buttonColors.UseVisualStyleBackColor = true;
            this.buttonColors.Click += new System.EventHandler(this.ButtonColors_Click);
            // 
            // Colors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 171);
            this.Controls.Add(this.buttonColors);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.pictureBoxColor);
            this.Controls.Add(this.numericUpDownBlue);
            this.Controls.Add(this.hScrollBarBlue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownGreen);
            this.Controls.Add(this.hScrollBarGreen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownRed);
            this.Controls.Add(this.hScrollBarRed);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Colors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Палитра";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar hScrollBarRed;
        private System.Windows.Forms.NumericUpDown numericUpDownRed;
        private System.Windows.Forms.NumericUpDown numericUpDownGreen;
        private System.Windows.Forms.HScrollBar hScrollBarGreen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownBlue;
        private System.Windows.Forms.HScrollBar hScrollBarBlue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxColor;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonColors;
    }
}