namespace WindowsFormsPractice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnImagesList = new Button();
            btnColorRange = new Button();
            btnTimer = new Button();
            btnCalendars = new Button();
            btnComboBox = new Button();
            btnBoxes = new Button();
            btnList = new Button();
            btnColors = new Button();
            btnTtriangle = new Button();
            btnTextBox = new Button();
            lblWelcome = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnImagesList);
            panel1.Controls.Add(btnColorRange);
            panel1.Controls.Add(btnTimer);
            panel1.Controls.Add(btnCalendars);
            panel1.Controls.Add(btnComboBox);
            panel1.Controls.Add(btnBoxes);
            panel1.Controls.Add(btnList);
            panel1.Controls.Add(btnColors);
            panel1.Controls.Add(btnTtriangle);
            panel1.Controls.Add(btnTextBox);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(188, 559);
            panel1.TabIndex = 0;
            // 
            // btnImagesList
            // 
            btnImagesList.Location = new Point(27, 484);
            btnImagesList.Name = "btnImagesList";
            btnImagesList.Size = new Size(129, 29);
            btnImagesList.TabIndex = 9;
            btnImagesList.Text = "Images list";
            btnImagesList.UseVisualStyleBackColor = true;
            btnImagesList.Click += btnImagesList_Click;
            // 
            // btnColorRange
            // 
            btnColorRange.Location = new Point(27, 430);
            btnColorRange.Name = "btnColorRange";
            btnColorRange.Size = new Size(129, 29);
            btnColorRange.TabIndex = 8;
            btnColorRange.Text = "Color range";
            btnColorRange.UseVisualStyleBackColor = true;
            btnColorRange.Click += btnColorRange_Click;
            // 
            // btnTimer
            // 
            btnTimer.Location = new Point(27, 384);
            btnTimer.Name = "btnTimer";
            btnTimer.Size = new Size(129, 29);
            btnTimer.TabIndex = 7;
            btnTimer.Text = "Timer";
            btnTimer.UseVisualStyleBackColor = true;
            btnTimer.Click += btnTimer_Click;
            // 
            // btnCalendars
            // 
            btnCalendars.Location = new Point(27, 334);
            btnCalendars.Name = "btnCalendars";
            btnCalendars.Size = new Size(129, 29);
            btnCalendars.TabIndex = 6;
            btnCalendars.Text = "Calendars";
            btnCalendars.UseVisualStyleBackColor = true;
            btnCalendars.Click += btnCalendars_Click;
            // 
            // btnComboBox
            // 
            btnComboBox.Location = new Point(27, 285);
            btnComboBox.Name = "btnComboBox";
            btnComboBox.Size = new Size(129, 29);
            btnComboBox.TabIndex = 5;
            btnComboBox.Text = "ComboBox";
            btnComboBox.UseVisualStyleBackColor = true;
            btnComboBox.Click += btnComboBox_Click;
            // 
            // btnBoxes
            // 
            btnBoxes.Location = new Point(27, 234);
            btnBoxes.Name = "btnBoxes";
            btnBoxes.Size = new Size(129, 29);
            btnBoxes.TabIndex = 4;
            btnBoxes.Text = "Boxes";
            btnBoxes.UseVisualStyleBackColor = true;
            btnBoxes.Click += btnBoxes_Click;
            // 
            // btnList
            // 
            btnList.Location = new Point(27, 183);
            btnList.Name = "btnList";
            btnList.Size = new Size(129, 29);
            btnList.TabIndex = 3;
            btnList.Text = "List";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnColors
            // 
            btnColors.Location = new Point(27, 132);
            btnColors.Name = "btnColors";
            btnColors.Size = new Size(129, 29);
            btnColors.TabIndex = 2;
            btnColors.Text = "Colors";
            btnColors.UseVisualStyleBackColor = true;
            btnColors.Click += btnColors_Click;
            // 
            // btnTtriangle
            // 
            btnTtriangle.Location = new Point(27, 84);
            btnTtriangle.Name = "btnTtriangle";
            btnTtriangle.Size = new Size(129, 29);
            btnTtriangle.TabIndex = 1;
            btnTtriangle.Text = "Triangle";
            btnTtriangle.UseVisualStyleBackColor = true;
            btnTtriangle.Click += btnTtriangle_Click;
            // 
            // btnTextBox
            // 
            btnTextBox.Location = new Point(27, 33);
            btnTextBox.Name = "btnTextBox";
            btnTextBox.Size = new Size(129, 29);
            btnTextBox.TabIndex = 0;
            btnTextBox.Text = "TextBox";
            btnTextBox.UseVisualStyleBackColor = true;
            btnTextBox.Click += btnTextBox_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Bookman Old Style", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.Location = new Point(473, 224);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(383, 90);
            lblWelcome.TabIndex = 3;
            lblWelcome.Text = "Welcome";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 559);
            Controls.Add(lblWelcome);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnTextBox;
        private Button btnComboBox;
        private Button btnBoxes;
        private Button btnList;
        private Button btnColors;
        private Button btnTtriangle;
        private Button btnImagesList;
        private Button btnColorRange;
        private Button btnTimer;
        private Button btnCalendars;
        private Label lblWelcome;
    }
}