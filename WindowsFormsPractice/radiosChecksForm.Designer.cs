namespace WindowsFormsPractice
{
    partial class radiosChecksForm
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
            groupBoxColors = new GroupBox();
            rboGreen = new RadioButton();
            rboBlue = new RadioButton();
            rboRed = new RadioButton();
            groupBoxFormat = new GroupBox();
            chkCenter = new CheckBox();
            chkCapital = new CheckBox();
            txtChecking = new System.Windows.Forms.TextBox();
            groupBoxColors.SuspendLayout();
            groupBoxFormat.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxColors
            // 
            groupBoxColors.BackColor = SystemColors.ControlLight;
            groupBoxColors.Controls.Add(rboGreen);
            groupBoxColors.Controls.Add(rboBlue);
            groupBoxColors.Controls.Add(rboRed);
            groupBoxColors.Location = new Point(80, 117);
            groupBoxColors.Margin = new Padding(3, 2, 3, 2);
            groupBoxColors.Name = "groupBoxColors";
            groupBoxColors.Padding = new Padding(3, 2, 3, 2);
            groupBoxColors.Size = new Size(220, 184);
            groupBoxColors.TabIndex = 0;
            groupBoxColors.TabStop = false;
            groupBoxColors.Text = "Color";
            groupBoxColors.Enter += groupBoxColors_Enter;
            // 
            // rboGreen
            // 
            rboGreen.AutoSize = true;
            rboGreen.Location = new Point(25, 142);
            rboGreen.Margin = new Padding(3, 2, 3, 2);
            rboGreen.Name = "rboGreen";
            rboGreen.Size = new Size(56, 19);
            rboGreen.TabIndex = 2;
            rboGreen.TabStop = true;
            rboGreen.Text = "Green";
            rboGreen.UseVisualStyleBackColor = true;
            rboGreen.CheckedChanged += rboGreen_CheckedChanged;
            // 
            // rboBlue
            // 
            rboBlue.AutoSize = true;
            rboBlue.Location = new Point(25, 88);
            rboBlue.Margin = new Padding(3, 2, 3, 2);
            rboBlue.Name = "rboBlue";
            rboBlue.Size = new Size(48, 19);
            rboBlue.TabIndex = 1;
            rboBlue.TabStop = true;
            rboBlue.Text = "Blue";
            rboBlue.UseVisualStyleBackColor = true;
            rboBlue.CheckedChanged += rboBlue_CheckedChanged;
            // 
            // rboRed
            // 
            rboRed.AutoSize = true;
            rboRed.Location = new Point(25, 38);
            rboRed.Margin = new Padding(3, 2, 3, 2);
            rboRed.Name = "rboRed";
            rboRed.Size = new Size(45, 19);
            rboRed.TabIndex = 0;
            rboRed.TabStop = true;
            rboRed.Text = "Red";
            rboRed.UseVisualStyleBackColor = true;
            rboRed.CheckedChanged += rboRed_CheckedChanged;
            // 
            // groupBoxFormat
            // 
            groupBoxFormat.BackColor = SystemColors.ControlLight;
            groupBoxFormat.Controls.Add(chkCenter);
            groupBoxFormat.Controls.Add(chkCapital);
            groupBoxFormat.Location = new Point(376, 117);
            groupBoxFormat.Margin = new Padding(3, 2, 3, 2);
            groupBoxFormat.Name = "groupBoxFormat";
            groupBoxFormat.Padding = new Padding(3, 2, 3, 2);
            groupBoxFormat.Size = new Size(236, 184);
            groupBoxFormat.TabIndex = 1;
            groupBoxFormat.TabStop = false;
            groupBoxFormat.Text = "Formart";
            groupBoxFormat.Enter += groupBoxFormat_Enter;
            // 
            // chkCenter
            // 
            chkCenter.AutoSize = true;
            chkCenter.Location = new Point(39, 123);
            chkCenter.Margin = new Padding(3, 2, 3, 2);
            chkCenter.Name = "chkCenter";
            chkCenter.Size = new Size(61, 19);
            chkCenter.TabIndex = 1;
            chkCenter.Text = "Center";
            chkCenter.UseVisualStyleBackColor = true;
            chkCenter.CheckedChanged += chkCenter_CheckedChanged;
            // 
            // chkCapital
            // 
            chkCapital.AutoSize = true;
            chkCapital.Location = new Point(39, 56);
            chkCapital.Margin = new Padding(3, 2, 3, 2);
            chkCapital.Name = "chkCapital";
            chkCapital.Size = new Size(96, 19);
            chkCapital.TabIndex = 0;
            chkCapital.Text = "capital letters";
            chkCapital.UseVisualStyleBackColor = true;
            chkCapital.CheckedChanged += chkCapital_CheckedChanged;
            // 
            // txtChecking
            // 
            txtChecking.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtChecking.Location = new Point(80, 44);
            txtChecking.Margin = new Padding(3, 2, 3, 2);
            txtChecking.Name = "txtChecking";
            txtChecking.Size = new Size(533, 35);
            txtChecking.TabIndex = 2;
            txtChecking.Text = "Checking...";
            txtChecking.TextAlign = HorizontalAlignment.Center;
            txtChecking.TextChanged += txtChecking_TextChanged;
            // 
            // radiosChecksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(700, 338);
            Controls.Add(txtChecking);
            Controls.Add(groupBoxFormat);
            Controls.Add(groupBoxColors);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "radiosChecksForm";
            Text = "radiosChecksForm";
            groupBoxColors.ResumeLayout(false);
            groupBoxColors.PerformLayout();
            groupBoxFormat.ResumeLayout(false);
            groupBoxFormat.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxColors;
        private GroupBox groupBoxFormat;
        private RadioButton rboGreen;
        private RadioButton rboBlue;
        private CheckBox chkCenter;
        private CheckBox chkCapital;
        private System.Windows.Forms.TextBox txtChecking;
        private RadioButton rboRed;
    }
}