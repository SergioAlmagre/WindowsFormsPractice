namespace WindowsFormsPractice
{
    partial class colorRangeForm
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
            lblRed = new Label();
            lblGreen = new Label();
            lblBlue = new Label();
            trbRed = new TrackBar();
            trbGreen = new TrackBar();
            trbBlue = new TrackBar();
            dudRed = new DomainUpDown();
            dudGreen = new DomainUpDown();
            dudBlue = new DomainUpDown();
            panelColor = new Panel();
            ((System.ComponentModel.ISupportInitialize)trbRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbBlue).BeginInit();
            SuspendLayout();
            // 
            // lblRed
            // 
            lblRed.AutoSize = true;
            lblRed.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblRed.Location = new Point(68, 63);
            lblRed.Name = "lblRed";
            lblRed.Size = new Size(77, 29);
            lblRed.TabIndex = 0;
            lblRed.Text = "Red: ";
            // 
            // lblGreen
            // 
            lblGreen.AutoSize = true;
            lblGreen.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblGreen.Location = new Point(41, 114);
            lblGreen.Name = "lblGreen";
            lblGreen.Size = new Size(104, 29);
            lblGreen.TabIndex = 1;
            lblGreen.Text = "Green: ";
            // 
            // lblBlue
            // 
            lblBlue.AutoSize = true;
            lblBlue.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblBlue.Location = new Point(60, 165);
            lblBlue.Name = "lblBlue";
            lblBlue.Size = new Size(85, 29);
            lblBlue.TabIndex = 2;
            lblBlue.Text = "Blue: ";
            // 
            // trbRed
            // 
            trbRed.Location = new Point(242, 63);
            trbRed.Maximum = 255;
            trbRed.Minimum = 1;
            trbRed.Name = "trbRed";
            trbRed.Size = new Size(685, 45);
            trbRed.TabIndex = 3;
            trbRed.Value = 1;
            trbRed.Scroll += trbRed_Scroll;
            // 
            // trbGreen
            // 
            trbGreen.Location = new Point(242, 114);
            trbGreen.Maximum = 255;
            trbGreen.Minimum = 1;
            trbGreen.Name = "trbGreen";
            trbGreen.Size = new Size(685, 45);
            trbGreen.TabIndex = 4;
            trbGreen.Value = 1;
            trbGreen.Scroll += trbGreen_Scroll;
            // 
            // trbBlue
            // 
            trbBlue.Location = new Point(242, 165);
            trbBlue.Maximum = 255;
            trbBlue.Minimum = 1;
            trbBlue.Name = "trbBlue";
            trbBlue.Size = new Size(685, 45);
            trbBlue.TabIndex = 5;
            trbBlue.Value = 1;
            trbBlue.Scroll += trbBlue_Scroll;
            // 
            // dudRed
            // 
            dudRed.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dudRed.Location = new Point(151, 63);
            dudRed.Name = "dudRed";
            dudRed.Size = new Size(70, 27);
            dudRed.TabIndex = 6;
            dudRed.Text = "1";
            dudRed.TextAlign = HorizontalAlignment.Center;
            dudRed.SelectedItemChanged += dudRed_SelectedItemChanged;
            // 
            // dudGreen
            // 
            dudGreen.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dudGreen.Location = new Point(151, 114);
            dudGreen.Name = "dudGreen";
            dudGreen.Size = new Size(70, 27);
            dudGreen.TabIndex = 7;
            dudGreen.Text = "1";
            dudGreen.TextAlign = HorizontalAlignment.Center;
            dudGreen.SelectedItemChanged += dudGreen_SelectedItemChanged;
            // 
            // dudBlue
            // 
            dudBlue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dudBlue.Location = new Point(151, 167);
            dudBlue.Name = "dudBlue";
            dudBlue.Size = new Size(70, 27);
            dudBlue.TabIndex = 8;
            dudBlue.Text = "1";
            dudBlue.TextAlign = HorizontalAlignment.Center;
            dudBlue.SelectedItemChanged += dudBlue_SelectedItemChanged;
            // 
            // panelColor
            // 
            panelColor.Location = new Point(41, 216);
            panelColor.Name = "panelColor";
            panelColor.Size = new Size(886, 191);
            panelColor.TabIndex = 9;
            panelColor.Paint += panelColor_Paint;
            // 
            // colorRangeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(984, 450);
            Controls.Add(panelColor);
            Controls.Add(dudBlue);
            Controls.Add(dudGreen);
            Controls.Add(dudRed);
            Controls.Add(trbBlue);
            Controls.Add(trbGreen);
            Controls.Add(trbRed);
            Controls.Add(lblBlue);
            Controls.Add(lblGreen);
            Controls.Add(lblRed);
            FormBorderStyle = FormBorderStyle.None;
            Name = "colorRangeForm";
            Text = "colorRangeForm";
            ((System.ComponentModel.ISupportInitialize)trbRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbBlue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRed;
        private Label lblGreen;
        private Label lblBlue;
        private TrackBar trbRed;
        private TrackBar trbGreen;
        private TrackBar trbBlue;
        private DomainUpDown dudRed;
        private DomainUpDown dudGreen;
        private DomainUpDown dudBlue;
        private Panel panelColor;
    }
}