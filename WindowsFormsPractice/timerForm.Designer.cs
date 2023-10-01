namespace WindowsFormsPractice
{
    partial class timerForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(timerForm));
            txtBoxUp = new System.Windows.Forms.TextBox();
            txtBoxDown = new System.Windows.Forms.TextBox();
            label1 = new Label();
            nudTime = new NumericUpDown();
            btnStart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lblTimer = new Label();
            btnStop = new Button();
            btnRestart = new Button();
            ((System.ComponentModel.ISupportInitialize)nudTime).BeginInit();
            SuspendLayout();
            // 
            // txtBoxUp
            // 
            txtBoxUp.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxUp.Location = new Point(174, 147);
            txtBoxUp.Name = "txtBoxUp";
            txtBoxUp.Size = new Size(441, 35);
            txtBoxUp.TabIndex = 0;
            txtBoxUp.TextAlign = HorizontalAlignment.Center;
            txtBoxUp.TextChanged += txtBoxUp_TextChanged;
            // 
            // txtBoxDown
            // 
            txtBoxDown.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxDown.Location = new Point(174, 202);
            txtBoxDown.Name = "txtBoxDown";
            txtBoxDown.ReadOnly = true;
            txtBoxDown.Size = new Size(441, 35);
            txtBoxDown.TabIndex = 1;
            txtBoxDown.TextAlign = HorizontalAlignment.Center;
            txtBoxDown.TextChanged += txtBoxDown_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(136, 72);
            label1.Name = "label1";
            label1.Size = new Size(515, 25);
            label1.TabIndex = 2;
            label1.Text = "Put the interval to change the text from up box to down box";
            label1.Click += label1_Click;
            // 
            // nudTime
            // 
            nudTime.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            nudTime.Location = new Point(333, 266);
            nudTime.Name = "nudTime";
            nudTime.Size = new Size(120, 33);
            nudTime.TabIndex = 4;
            nudTime.ValueChanged += nudTime_ValueChanged;
            // 
            // btnStart
            // 
            btnStart.BackgroundImage = (Image)resources.GetObject("btnStart.BackgroundImage");
            btnStart.BackgroundImageLayout = ImageLayout.Stretch;
            btnStart.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.Location = new Point(174, 266);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(89, 90);
            btnStart.TabIndex = 5;
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTimer.Location = new Point(355, 326);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(67, 30);
            lblTimer.TabIndex = 6;
            lblTimer.Text = "00:00";
            lblTimer.Click += lblTimer_Click;
            // 
            // btnStop
            // 
            btnStop.BackgroundImage = (Image)resources.GetObject("btnStop.BackgroundImage");
            btnStop.BackgroundImageLayout = ImageLayout.Stretch;
            btnStop.Location = new Point(515, 266);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(100, 90);
            btnStop.TabIndex = 7;
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(333, 388);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(120, 23);
            btnRestart.TabIndex = 8;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // timerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRestart);
            Controls.Add(btnStop);
            Controls.Add(lblTimer);
            Controls.Add(btnStart);
            Controls.Add(nudTime);
            Controls.Add(label1);
            Controls.Add(txtBoxDown);
            Controls.Add(txtBoxUp);
            FormBorderStyle = FormBorderStyle.None;
            Name = "timerForm";
            Text = "timerForm";
            ((System.ComponentModel.ISupportInitialize)nudTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxUp;
        private System.Windows.Forms.TextBox txtBoxDown;
        private Label label1;
        private NumericUpDown nudTime;
        private Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private Label lblTimer;
        private Button btnStop;
        private Button btnRestart;
    }
}