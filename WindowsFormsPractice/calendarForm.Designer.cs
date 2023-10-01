namespace WindowsFormsPractice
{
    partial class calendarForm
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
            mcal = new MonthCalendar();
            dtp = new DateTimePicker();
            txtDate = new System.Windows.Forms.TextBox();
            lblDateChoosed = new Label();
            grpBox = new GroupBox();
            rboLong = new RadioButton();
            rboShort = new RadioButton();
            grpBox.SuspendLayout();
            SuspendLayout();
            // 
            // mcal
            // 
            mcal.Location = new Point(125, 109);
            mcal.Name = "mcal";
            mcal.TabIndex = 0;
            mcal.DateChanged += mcal_DateChanged;
            // 
            // dtp
            // 
            dtp.Location = new Point(448, 109);
            dtp.Name = "dtp";
            dtp.Size = new Size(200, 23);
            dtp.TabIndex = 1;
            dtp.ValueChanged += dtp_ValueChanged;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(359, 65);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(289, 23);
            txtDate.TabIndex = 2;
            txtDate.TextChanged += txtDate_TextChanged;
            // 
            // lblDateChoosed
            // 
            lblDateChoosed.AutoSize = true;
            lblDateChoosed.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateChoosed.Location = new Point(160, 60);
            lblDateChoosed.Name = "lblDateChoosed";
            lblDateChoosed.Size = new Size(131, 25);
            lblDateChoosed.TabIndex = 3;
            lblDateChoosed.Text = "Date choosed:";
            // 
            // grpBox
            // 
            grpBox.Controls.Add(rboLong);
            grpBox.Controls.Add(rboShort);
            grpBox.Location = new Point(125, 305);
            grpBox.Name = "grpBox";
            grpBox.Size = new Size(192, 100);
            grpBox.TabIndex = 4;
            grpBox.TabStop = false;
            grpBox.Text = "Format";
            // 
            // rboLong
            // 
            rboLong.AutoSize = true;
            rboLong.Location = new Point(35, 62);
            rboLong.Name = "rboLong";
            rboLong.Size = new Size(52, 19);
            rboLong.TabIndex = 1;
            rboLong.TabStop = true;
            rboLong.Text = "Long";
            rboLong.UseVisualStyleBackColor = true;
            rboLong.CheckedChanged += rboLong_CheckedChanged;
            // 
            // rboShort
            // 
            rboShort.AutoSize = true;
            rboShort.Location = new Point(35, 22);
            rboShort.Name = "rboShort";
            rboShort.Size = new Size(53, 19);
            rboShort.TabIndex = 0;
            rboShort.TabStop = true;
            rboShort.Text = "Short";
            rboShort.UseVisualStyleBackColor = true;
            rboShort.CheckedChanged += rboShort_CheckedChanged;
            // 
            // calendarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(grpBox);
            Controls.Add(lblDateChoosed);
            Controls.Add(txtDate);
            Controls.Add(dtp);
            Controls.Add(mcal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "calendarForm";
            Text = "calendarForm";
            grpBox.ResumeLayout(false);
            grpBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar mcal;
        private DateTimePicker dtp;
        private System.Windows.Forms.TextBox txtDate;
        private Label lblDateChoosed;
        private GroupBox grpBox;
        private RadioButton rboShort;
        private RadioButton rboLong;
    }
}