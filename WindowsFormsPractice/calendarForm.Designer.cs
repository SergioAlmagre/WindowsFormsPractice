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
            SuspendLayout();
            // 
            // mcal
            // 
            mcal.Location = new Point(108, 168);
            mcal.Name = "mcal";
            mcal.TabIndex = 0;
            // 
            // dtp
            // 
            dtp.Location = new Point(388, 141);
            dtp.Name = "dtp";
            dtp.Size = new Size(200, 23);
            dtp.TabIndex = 1;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(328, 65);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(320, 23);
            txtDate.TabIndex = 2;
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
            // calendarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDateChoosed);
            Controls.Add(txtDate);
            Controls.Add(dtp);
            Controls.Add(mcal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "calendarForm";
            Text = "calendarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar mcal;
        private DateTimePicker dtp;
        private System.Windows.Forms.TextBox txtDate;
        private Label lblDateChoosed;
    }
}