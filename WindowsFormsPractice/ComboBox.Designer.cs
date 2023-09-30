namespace WindowsFormsPractice
{
    partial class comboBoxForm
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
            lblDropDownStyle = new Label();
            lblDropDownList = new Label();
            lblSimpleStyle = new Label();
            lblShowLastChoosed = new Label();
            txtLastChoosed = new System.Windows.Forms.TextBox();
            txtAddColor = new System.Windows.Forms.TextBox();
            btnAddColor = new Button();
            cboDropDownStyle = new ComboBox();
            cboSimple = new ComboBox();
            cboList = new ComboBox();
            SuspendLayout();
            // 
            // lblDropDownStyle
            // 
            lblDropDownStyle.AutoSize = true;
            lblDropDownStyle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDropDownStyle.Location = new Point(97, 80);
            lblDropDownStyle.Name = "lblDropDownStyle";
            lblDropDownStyle.Size = new Size(123, 20);
            lblDropDownStyle.TabIndex = 0;
            lblDropDownStyle.Text = "DropDown Style";
            // 
            // lblDropDownList
            // 
            lblDropDownList.AutoSize = true;
            lblDropDownList.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDropDownList.Location = new Point(321, 80);
            lblDropDownList.Name = "lblDropDownList";
            lblDropDownList.Size = new Size(114, 20);
            lblDropDownList.TabIndex = 1;
            lblDropDownList.Text = "DropDown List";
            // 
            // lblSimpleStyle
            // 
            lblSimpleStyle.AutoSize = true;
            lblSimpleStyle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSimpleStyle.Location = new Point(580, 80);
            lblSimpleStyle.Name = "lblSimpleStyle";
            lblSimpleStyle.Size = new Size(94, 20);
            lblSimpleStyle.TabIndex = 2;
            lblSimpleStyle.Text = "Simple Style";
            // 
            // lblShowLastChoosed
            // 
            lblShowLastChoosed.AutoSize = true;
            lblShowLastChoosed.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblShowLastChoosed.Location = new Point(78, 292);
            lblShowLastChoosed.Name = "lblShowLastChoosed";
            lblShowLastChoosed.Size = new Size(169, 20);
            lblShowLastChoosed.TabIndex = 3;
            lblShowLastChoosed.Text = "Show the last choosed:";
            // 
            // txtLastChoosed
            // 
            txtLastChoosed.Location = new Point(78, 315);
            txtLastChoosed.Name = "txtLastChoosed";
            txtLastChoosed.Size = new Size(166, 23);
            txtLastChoosed.TabIndex = 4;
            txtLastChoosed.TextChanged += txtLastChoosed_TextChanged;
            // 
            // txtAddColor
            // 
            txtAddColor.Location = new Point(546, 289);
            txtAddColor.Name = "txtAddColor";
            txtAddColor.Size = new Size(166, 23);
            txtAddColor.TabIndex = 5;
            txtAddColor.TextChanged += txtAddColor_TextChanged;
            // 
            // btnAddColor
            // 
            btnAddColor.Location = new Point(546, 318);
            btnAddColor.Name = "btnAddColor";
            btnAddColor.Size = new Size(161, 32);
            btnAddColor.TabIndex = 6;
            btnAddColor.Text = "Add color to dropDownList";
            btnAddColor.UseVisualStyleBackColor = true;
            btnAddColor.Click += btnAddColor_Click;
            // 
            // cboDropDownStyle
            // 
            cboDropDownStyle.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboDropDownStyle.FormattingEnabled = true;
            cboDropDownStyle.Location = new Point(78, 113);
            cboDropDownStyle.Name = "cboDropDownStyle";
            cboDropDownStyle.Size = new Size(166, 23);
            cboDropDownStyle.TabIndex = 7;
            cboDropDownStyle.SelectedIndexChanged += cboDropDownStyle_SelectedIndexChanged;
            // 
            // cboSimple
            // 
            cboSimple.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboSimple.DropDownStyle = ComboBoxStyle.Simple;
            cboSimple.FormattingEnabled = true;
            cboSimple.Location = new Point(546, 113);
            cboSimple.Name = "cboSimple";
            cboSimple.Size = new Size(166, 23);
            cboSimple.TabIndex = 8;
            cboSimple.SelectedIndexChanged += cboSimple_SelectedIndexChanged;
            // 
            // cboList
            // 
            cboList.DropDownStyle = ComboBoxStyle.DropDownList;
            cboList.FormattingEnabled = true;
            cboList.Location = new Point(302, 113);
            cboList.Name = "cboList";
            cboList.Size = new Size(166, 23);
            cboList.TabIndex = 9;
            cboList.SelectedIndexChanged += cboList_SelectedIndexChanged;
            // 
            // comboBoxForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(cboList);
            Controls.Add(cboSimple);
            Controls.Add(cboDropDownStyle);
            Controls.Add(btnAddColor);
            Controls.Add(txtAddColor);
            Controls.Add(txtLastChoosed);
            Controls.Add(lblShowLastChoosed);
            Controls.Add(lblSimpleStyle);
            Controls.Add(lblDropDownList);
            Controls.Add(lblDropDownStyle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "comboBoxForm";
            Text = "ComboBox";
            Load += comboBoxForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDropDownStyle;
        private Label lblDropDownList;
        private Label lblSimpleStyle;
        private Label lblShowLastChoosed;
        private System.Windows.Forms.TextBox txtLastChoosed;
        private System.Windows.Forms.TextBox txtAddColor;
        private Button btnAddColor;
        private ComboBox cboDropDownStyle;
        private ComboBox cboSimple;
        private ComboBox cboList;
    }
}