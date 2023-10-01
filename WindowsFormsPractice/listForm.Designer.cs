namespace WindowsFormsPractice
{
    partial class listForm
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
            lblItemSelected = new Label();
            lstItems = new ListBox();
            lstTransferedItems = new ListBox();
            lblItemList = new Label();
            lblTransferedList = new Label();
            grpRadios = new GroupBox();
            rboExtended = new RadioButton();
            rboMultiple = new RadioButton();
            rboSimple = new RadioButton();
            btnTransferLR = new Button();
            chkSort = new CheckBox();
            chkShowInColums = new CheckBox();
            btnAddItem = new Button();
            btnSearch = new Button();
            txtAddSearch = new System.Windows.Forms.TextBox();
            btnSelect = new Button();
            btnDeselect = new Button();
            btnClean = new Button();
            btnTransferRL = new Button();
            chklFruits = new CheckedListBox();
            lblFruits = new Label();
            btnAddFruit = new Button();
            chkCollectionEditor = new CheckBox();
            grpRadios.SuspendLayout();
            SuspendLayout();
            // 
            // lblItemSelected
            // 
            lblItemSelected.AutoSize = true;
            lblItemSelected.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblItemSelected.Location = new Point(364, 9);
            lblItemSelected.Name = "lblItemSelected";
            lblItemSelected.Size = new Size(258, 32);
            lblItemSelected.TabIndex = 0;
            lblItemSelected.Text = "ItemName is selected";
            lblItemSelected.Click += lblItemSelected_Click;
            // 
            // lstItems
            // 
            lstItems.FormattingEnabled = true;
            lstItems.ItemHeight = 15;
            lstItems.Location = new Point(37, 89);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(367, 199);
            lstItems.TabIndex = 1;
            lstItems.SelectedIndexChanged += lstItems_SelectedIndexChanged;
            // 
            // lstTransferedItems
            // 
            lstTransferedItems.FormattingEnabled = true;
            lstTransferedItems.ItemHeight = 15;
            lstTransferedItems.Location = new Point(565, 89);
            lstTransferedItems.Name = "lstTransferedItems";
            lstTransferedItems.Size = new Size(195, 199);
            lstTransferedItems.TabIndex = 2;
            lstTransferedItems.SelectedIndexChanged += lstTransferedItems_SelectedIndexChanged;
            // 
            // lblItemList
            // 
            lblItemList.AutoSize = true;
            lblItemList.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblItemList.Location = new Point(182, 69);
            lblItemList.Name = "lblItemList";
            lblItemList.Size = new Size(65, 17);
            lblItemList.TabIndex = 3;
            lblItemList.Text = "Items list";
            // 
            // lblTransferedList
            // 
            lblTransferedList.AutoSize = true;
            lblTransferedList.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTransferedList.Location = new Point(615, 69);
            lblTransferedList.Name = "lblTransferedList";
            lblTransferedList.Size = new Size(96, 17);
            lblTransferedList.TabIndex = 4;
            lblTransferedList.Text = "Transfered list";
            // 
            // grpRadios
            // 
            grpRadios.BackColor = Color.AliceBlue;
            grpRadios.Controls.Add(rboExtended);
            grpRadios.Controls.Add(rboMultiple);
            grpRadios.Controls.Add(rboSimple);
            grpRadios.Location = new Point(425, 89);
            grpRadios.Name = "grpRadios";
            grpRadios.Size = new Size(118, 142);
            grpRadios.TabIndex = 5;
            grpRadios.TabStop = false;
            grpRadios.Enter += grpRadios_Enter;
            // 
            // rboExtended
            // 
            rboExtended.AutoSize = true;
            rboExtended.Location = new Point(23, 102);
            rboExtended.Name = "rboExtended";
            rboExtended.Size = new Size(74, 19);
            rboExtended.TabIndex = 2;
            rboExtended.TabStop = true;
            rboExtended.Text = "Extended";
            rboExtended.UseVisualStyleBackColor = true;
            rboExtended.CheckedChanged += rboExtended_CheckedChanged;
            // 
            // rboMultiple
            // 
            rboMultiple.AutoSize = true;
            rboMultiple.Location = new Point(23, 61);
            rboMultiple.Name = "rboMultiple";
            rboMultiple.Size = new Size(69, 19);
            rboMultiple.TabIndex = 1;
            rboMultiple.TabStop = true;
            rboMultiple.Text = "Multiple";
            rboMultiple.UseVisualStyleBackColor = true;
            rboMultiple.CheckedChanged += rboMultiple_CheckedChanged;
            // 
            // rboSimple
            // 
            rboSimple.AutoSize = true;
            rboSimple.Location = new Point(23, 22);
            rboSimple.Name = "rboSimple";
            rboSimple.Size = new Size(61, 19);
            rboSimple.TabIndex = 0;
            rboSimple.TabStop = true;
            rboSimple.Text = "Simple";
            rboSimple.UseVisualStyleBackColor = true;
            rboSimple.CheckedChanged += rboSimple_CheckedChanged;
            // 
            // btnTransferLR
            // 
            btnTransferLR.BackColor = Color.MistyRose;
            btnTransferLR.Location = new Point(425, 324);
            btnTransferLR.Name = "btnTransferLR";
            btnTransferLR.Size = new Size(118, 42);
            btnTransferLR.TabIndex = 6;
            btnTransferLR.Text = "Transfer >>>";
            btnTransferLR.UseVisualStyleBackColor = false;
            btnTransferLR.Click += btnTransferLR_Click;
            // 
            // chkSort
            // 
            chkSort.AutoSize = true;
            chkSort.Location = new Point(37, 307);
            chkSort.Name = "chkSort";
            chkSort.Size = new Size(47, 19);
            chkSort.TabIndex = 7;
            chkSort.Text = "Sort";
            chkSort.UseVisualStyleBackColor = true;
            chkSort.CheckedChanged += chkSort_CheckedChanged;
            // 
            // chkShowInColums
            // 
            chkShowInColums.AutoSize = true;
            chkShowInColums.Location = new Point(37, 337);
            chkShowInColums.Name = "chkShowInColums";
            chkShowInColums.Size = new Size(110, 19);
            chkShowInColums.TabIndex = 8;
            chkShowInColums.Text = "Show in colums";
            chkShowInColums.UseVisualStyleBackColor = true;
            chkShowInColums.CheckedChanged += chkShowInColums_CheckedChanged;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(165, 334);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(117, 23);
            btnAddItem.TabIndex = 9;
            btnAddItem.Text = "Add item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(165, 363);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(239, 23);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtAddSearch
            // 
            txtAddSearch.Location = new Point(165, 305);
            txtAddSearch.Name = "txtAddSearch";
            txtAddSearch.Size = new Size(239, 23);
            txtAddSearch.TabIndex = 11;
            txtAddSearch.TextChanged += txtAddSearch_TextChanged;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(425, 237);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(118, 23);
            btnSelect.TabIndex = 12;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnDeselect
            // 
            btnDeselect.Location = new Point(425, 265);
            btnDeselect.Name = "btnDeselect";
            btnDeselect.Size = new Size(118, 23);
            btnDeselect.TabIndex = 13;
            btnDeselect.Text = "Deselect";
            btnDeselect.UseVisualStyleBackColor = true;
            btnDeselect.Click += btnDeselect_Click;
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.Snow;
            btnClean.Location = new Point(565, 324);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(195, 42);
            btnClean.TabIndex = 14;
            btnClean.Text = "Clean";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // btnTransferRL
            // 
            btnTransferRL.BackColor = Color.MistyRose;
            btnTransferRL.Location = new Point(786, 324);
            btnTransferRL.Name = "btnTransferRL";
            btnTransferRL.Size = new Size(118, 42);
            btnTransferRL.TabIndex = 15;
            btnTransferRL.Text = "<<< Transfer";
            btnTransferRL.UseVisualStyleBackColor = false;
            btnTransferRL.Click += btnTransferRL_Click;
            // 
            // chklFruits
            // 
            chklFruits.CheckOnClick = true;
            chklFruits.FormattingEnabled = true;
            chklFruits.Location = new Point(784, 89);
            chklFruits.Name = "chklFruits";
            chklFruits.Size = new Size(120, 202);
            chklFruits.TabIndex = 16;
            chklFruits.SelectedIndexChanged += chklFruits_SelectedIndexChanged;
            // 
            // lblFruits
            // 
            lblFruits.AutoSize = true;
            lblFruits.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFruits.Location = new Point(811, 69);
            lblFruits.Name = "lblFruits";
            lblFruits.Size = new Size(66, 17);
            lblFruits.TabIndex = 17;
            lblFruits.Text = "Fruits list";
            // 
            // btnAddFruit
            // 
            btnAddFruit.Location = new Point(297, 334);
            btnAddFruit.Name = "btnAddFruit";
            btnAddFruit.Size = new Size(107, 23);
            btnAddFruit.TabIndex = 18;
            btnAddFruit.Text = "Add fruit";
            btnAddFruit.UseVisualStyleBackColor = true;
            btnAddFruit.Click += btnAddFruit_Click;
            // 
            // chkCollectionEditor
            // 
            chkCollectionEditor.AutoSize = true;
            chkCollectionEditor.Location = new Point(37, 366);
            chkCollectionEditor.Name = "chkCollectionEditor";
            chkCollectionEditor.Size = new Size(114, 19);
            chkCollectionEditor.TabIndex = 19;
            chkCollectionEditor.Text = "Collection editor";
            chkCollectionEditor.UseVisualStyleBackColor = true;
            chkCollectionEditor.CheckedChanged += chkCollectionEditor_CheckedChanged;
            // 
            // listForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(953, 433);
            Controls.Add(chkCollectionEditor);
            Controls.Add(btnAddFruit);
            Controls.Add(lblFruits);
            Controls.Add(chklFruits);
            Controls.Add(btnTransferRL);
            Controls.Add(btnClean);
            Controls.Add(btnDeselect);
            Controls.Add(btnSelect);
            Controls.Add(txtAddSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnAddItem);
            Controls.Add(chkShowInColums);
            Controls.Add(chkSort);
            Controls.Add(btnTransferLR);
            Controls.Add(grpRadios);
            Controls.Add(lblTransferedList);
            Controls.Add(lblItemList);
            Controls.Add(lstTransferedItems);
            Controls.Add(lstItems);
            Controls.Add(lblItemSelected);
            FormBorderStyle = FormBorderStyle.None;
            Name = "listForm";
            Text = "listForm";
            grpRadios.ResumeLayout(false);
            grpRadios.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblItemSelected;
        private ListBox lstItems;
        private ListBox lstTransferedItems;
        private Label lblItemList;
        private Label lblTransferedList;
        private GroupBox grpRadios;
        private RadioButton rboExtended;
        private RadioButton rboMultiple;
        private RadioButton rboSimple;
        private Button btnTransferLR;
        private CheckBox chkSort;
        private CheckBox chkShowInColums;
        private Button btnAddItem;
        private Button btnSearch;
        private System.Windows.Forms.TextBox txtAddSearch;
        private Button btnSelect;
        private Button btnDeselect;
        private Button btnClean;
        private Button btnTransferRL;
        private CheckedListBox chklFruits;
        private Label lblFruits;
        private Button btnAddFruit;
        private CheckBox chkCollectionEditor;
    }
}