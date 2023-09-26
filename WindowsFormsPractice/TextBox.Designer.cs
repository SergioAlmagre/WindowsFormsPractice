namespace WindowsFormsPractice
{
    partial class TextBox
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
            lblMusic = new Label();
            lblName = new Label();
            lblSecondName = new Label();
            lblPassword = new Label();
            txtMusic = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            txtSecondName = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            btnNextFocus = new Button();
            btnWriter = new Button();
            btnActivate = new Button();
            btnMakeVisible = new Button();
            SuspendLayout();
            // 
            // lblMusic
            // 
            lblMusic.AutoSize = true;
            lblMusic.Location = new Point(74, 70);
            lblMusic.Name = "lblMusic";
            lblMusic.Size = new Size(50, 20);
            lblMusic.TabIndex = 0;
            lblMusic.Text = "Music:";
            lblMusic.Click += label1_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(74, 192);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            lblName.Click += label1_Click_1;
            // 
            // lblSecondName
            // 
            lblSecondName.AutoSize = true;
            lblSecondName.Location = new Point(74, 283);
            lblSecondName.Name = "lblSecondName";
            lblSecondName.Size = new Size(105, 20);
            lblSecondName.TabIndex = 2;
            lblSecondName.Text = "Second Name:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(74, 358);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // txtMusic
            // 
            txtMusic.Location = new Point(208, 70);
            txtMusic.Multiline = true;
            txtMusic.Name = "txtMusic";
            txtMusic.Size = new Size(342, 72);
            txtMusic.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(211, 192);
            txtName.Name = "txtName";
            txtName.Size = new Size(339, 27);
            txtName.TabIndex = 5;
            // 
            // txtSecondName
            // 
            txtSecondName.Location = new Point(211, 276);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(339, 27);
            txtSecondName.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(211, 351);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(339, 27);
            txtPassword.TabIndex = 7;
            // 
            // btnNextFocus
            // 
            btnNextFocus.Location = new Point(568, 70);
            btnNextFocus.Name = "btnNextFocus";
            btnNextFocus.Size = new Size(133, 72);
            btnNextFocus.TabIndex = 8;
            btnNextFocus.Text = "Next focus";
            btnNextFocus.UseVisualStyleBackColor = true;
            // 
            // btnWriter
            // 
            btnWriter.Location = new Point(568, 188);
            btnWriter.Name = "btnWriter";
            btnWriter.Size = new Size(133, 29);
            btnWriter.TabIndex = 9;
            btnWriter.Text = "Writer";
            btnWriter.UseVisualStyleBackColor = true;
            // 
            // btnActivate
            // 
            btnActivate.Location = new Point(568, 274);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new Size(133, 29);
            btnActivate.TabIndex = 10;
            btnActivate.Text = "Activate";
            btnActivate.UseVisualStyleBackColor = true;
            // 
            // btnMakeVisible
            // 
            btnMakeVisible.Location = new Point(568, 349);
            btnMakeVisible.Name = "btnMakeVisible";
            btnMakeVisible.Size = new Size(133, 29);
            btnMakeVisible.TabIndex = 11;
            btnMakeVisible.Text = "Make visible";
            btnMakeVisible.UseVisualStyleBackColor = true;
            // 
            // TextBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMakeVisible);
            Controls.Add(btnActivate);
            Controls.Add(btnWriter);
            Controls.Add(btnNextFocus);
            Controls.Add(txtPassword);
            Controls.Add(txtSecondName);
            Controls.Add(txtName);
            Controls.Add(txtMusic);
            Controls.Add(lblPassword);
            Controls.Add(lblSecondName);
            Controls.Add(lblName);
            Controls.Add(lblMusic);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TextBox";
            Text = "TextBox";
            Load += TextBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMusic;
        private Label lblName;
        private Label lblSecondName;
        private Label lblPassword;
        private System.Windows.Forms.TextBox txtMusic;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.TextBox txtPassword;
        private Button btnNextFocus;
        private Button btnWriter;
        private Button btnActivate;
        private Button btnMakeVisible;
    }
}