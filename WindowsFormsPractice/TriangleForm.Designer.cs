namespace WindowsFormsPractice
{
    partial class TriangleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriangleForm));
            lblSideA = new Label();
            lblSideB = new Label();
            lblSideC = new Label();
            txtSideA = new System.Windows.Forms.TextBox();
            txtSideB = new System.Windows.Forms.TextBox();
            txtSideC = new System.Windows.Forms.TextBox();
            btnCheck = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblSideA
            // 
            lblSideA.AutoSize = true;
            lblSideA.Font = new Font("MV Boli", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSideA.Location = new Point(76, 79);
            lblSideA.Name = "lblSideA";
            lblSideA.Size = new Size(106, 39);
            lblSideA.TabIndex = 0;
            lblSideA.Text = "Side A";
            // 
            // lblSideB
            // 
            lblSideB.AutoSize = true;
            lblSideB.Font = new Font("MV Boli", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSideB.Location = new Point(75, 195);
            lblSideB.Name = "lblSideB";
            lblSideB.Size = new Size(104, 39);
            lblSideB.TabIndex = 1;
            lblSideB.Text = "Side B";
            // 
            // lblSideC
            // 
            lblSideC.AutoSize = true;
            lblSideC.Font = new Font("MV Boli", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSideC.Location = new Point(76, 312);
            lblSideC.Name = "lblSideC";
            lblSideC.Size = new Size(103, 39);
            lblSideC.TabIndex = 2;
            lblSideC.Text = "Side C";
            // 
            // txtSideA
            // 
            txtSideA.Location = new Point(218, 79);
            txtSideA.Multiline = true;
            txtSideA.Name = "txtSideA";
            txtSideA.Size = new Size(112, 39);
            txtSideA.TabIndex = 3;
            // 
            // txtSideB
            // 
            txtSideB.Location = new Point(217, 195);
            txtSideB.Multiline = true;
            txtSideB.Name = "txtSideB";
            txtSideB.Size = new Size(112, 39);
            txtSideB.TabIndex = 4;
            // 
            // txtSideC
            // 
            txtSideC.Location = new Point(218, 312);
            txtSideC.Multiline = true;
            txtSideC.Name = "txtSideC";
            txtSideC.Size = new Size(112, 39);
            txtSideC.TabIndex = 5;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(456, 312);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(262, 39);
            btnCheck.TabIndex = 6;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(456, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 229);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // TriangleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnCheck);
            Controls.Add(txtSideC);
            Controls.Add(txtSideB);
            Controls.Add(txtSideA);
            Controls.Add(lblSideC);
            Controls.Add(lblSideB);
            Controls.Add(lblSideA);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TriangleForm";
            Text = "TriangleForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSideA;
        private Label lblSideB;
        private Label lblSideC;
        private System.Windows.Forms.TextBox txtSideA;
        private System.Windows.Forms.TextBox txtSideB;
        private System.Windows.Forms.TextBox txtSideC;
        private Button btnCheck;
        private PictureBox pictureBox1;
    }
}