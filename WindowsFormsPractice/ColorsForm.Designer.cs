namespace WindowsFormsPractice
{
    partial class colorsForm
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
            btnColor = new Button();
            btnFont = new Button();
            txtBox = new System.Windows.Forms.TextBox();
            lblText = new Label();
            SuspendLayout();
            // 
            // btnColor
            // 
            btnColor.Location = new Point(140, 195);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(231, 43);
            btnColor.TabIndex = 0;
            btnColor.Text = "Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // btnFont
            // 
            btnFont.Location = new Point(423, 195);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(231, 43);
            btnFont.TabIndex = 1;
            btnFont.Text = "Font";
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += btnFont_Click;
            // 
            // txtBox
            // 
            txtBox.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox.Location = new Point(140, 275);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(514, 87);
            txtBox.TabIndex = 2;
            txtBox.Text = "Testing fonts....";
            txtBox.TextChanged += txtBox_TextChanged;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblText.Location = new Point(85, 100);
            lblText.Name = "lblText";
            lblText.Size = new Size(648, 23);
            lblText.TabIndex = 3;
            lblText.Text = "Choose the background color of this form and the font of the text inside the square";
            // 
            // colorsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblText);
            Controls.Add(txtBox);
            Controls.Add(btnFont);
            Controls.Add(btnColor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "colorsForm";
            Text = "Colors2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnColor;
        private Button btnFont;
        private System.Windows.Forms.TextBox txtBox;
        private Label lblText;
    }
}