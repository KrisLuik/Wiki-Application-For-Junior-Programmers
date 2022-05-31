namespace Wiki_Application_For_Junior_Programmers
{
    partial class WikiApplication
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textboxName = new System.Windows.Forms.TextBox();
            this.textboxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.groupBoxRadioBtn = new System.Windows.Forms.GroupBox();
            this.radioBtnNonLinear = new System.Windows.Forms.RadioButton();
            this.radioBtnLinear = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxDefinition = new System.Windows.Forms.TextBox();
            this.listViewItems = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBoxRadioBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 11);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 24);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(136, 11);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(56, 24);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(77, 11);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 24);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(387, 15);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 24);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // textboxName
            // 
            this.textboxName.Location = new System.Drawing.Point(13, 41);
            this.textboxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(145, 20);
            this.textboxName.TabIndex = 4;
            // 
            // textboxSearch
            // 
            this.textboxSearch.Location = new System.Drawing.Point(225, 15);
            this.textboxSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxSearch.Name = "textboxSearch";
            this.textboxSearch.Size = new System.Drawing.Size(158, 20);
            this.textboxSearch.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Category";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(13, 65);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(145, 21);
            this.comboBoxCategory.Sorted = true;
            this.comboBoxCategory.TabIndex = 9;
            // 
            // groupBoxRadioBtn
            // 
            this.groupBoxRadioBtn.Controls.Add(this.radioBtnNonLinear);
            this.groupBoxRadioBtn.Controls.Add(this.radioBtnLinear);
            this.groupBoxRadioBtn.Location = new System.Drawing.Point(13, 89);
            this.groupBoxRadioBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxRadioBtn.Name = "groupBoxRadioBtn";
            this.groupBoxRadioBtn.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxRadioBtn.Size = new System.Drawing.Size(194, 56);
            this.groupBoxRadioBtn.TabIndex = 10;
            this.groupBoxRadioBtn.TabStop = false;
            this.groupBoxRadioBtn.Text = "Structure";
            // 
            // radioBtnNonLinear
            // 
            this.radioBtnNonLinear.AutoSize = true;
            this.radioBtnNonLinear.Location = new System.Drawing.Point(110, 25);
            this.radioBtnNonLinear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtnNonLinear.Name = "radioBtnNonLinear";
            this.radioBtnNonLinear.Size = new System.Drawing.Size(77, 17);
            this.radioBtnNonLinear.TabIndex = 1;
            this.radioBtnNonLinear.TabStop = true;
            this.radioBtnNonLinear.Text = "Non-Linear";
            this.radioBtnNonLinear.UseVisualStyleBackColor = true;
            // 
            // radioBtnLinear
            // 
            this.radioBtnLinear.AutoSize = true;
            this.radioBtnLinear.Location = new System.Drawing.Point(4, 25);
            this.radioBtnLinear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtnLinear.Name = "radioBtnLinear";
            this.radioBtnLinear.Size = new System.Drawing.Size(54, 17);
            this.radioBtnLinear.TabIndex = 0;
            this.radioBtnLinear.TabStop = true;
            this.radioBtnLinear.Text = "Linear";
            this.radioBtnLinear.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Definition";
            // 
            // textboxDefinition
            // 
            this.textboxDefinition.Location = new System.Drawing.Point(13, 163);
            this.textboxDefinition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxDefinition.Multiline = true;
            this.textboxDefinition.Name = "textboxDefinition";
            this.textboxDefinition.Size = new System.Drawing.Size(194, 131);
            this.textboxDefinition.TabIndex = 12;
            // 
            // listViewItems
            // 
            this.listViewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnCategory});
            this.listViewItems.FullRowSelect = true;
            this.listViewItems.GridLines = true;
            this.listViewItems.HideSelection = false;
            this.listViewItems.Location = new System.Drawing.Point(225, 45);
            this.listViewItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(285, 285);
            this.listViewItems.TabIndex = 13;
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            this.listViewItems.View = System.Windows.Forms.View.Details;
            this.listViewItems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewBox_MouseClick);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 137;
            // 
            // columnCategory
            // 
            this.columnCategory.Text = "Category";
            this.columnCategory.Width = 165;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(13, 299);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(91, 28);
            this.btnOpen.TabIndex = 14;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(116, 299);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 28);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 344);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(521, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // WikiApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 366);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.listViewItems);
            this.Controls.Add(this.textboxDefinition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBoxRadioBtn);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxSearch);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WikiApplication";
            this.Text = "Wiki Application";
            this.Load += new System.EventHandler(this.WikiApplication_Load);
            this.groupBoxRadioBtn.ResumeLayout(false);
            this.groupBoxRadioBtn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.TextBox textboxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.GroupBox groupBoxRadioBtn;
        private System.Windows.Forms.RadioButton radioBtnNonLinear;
        private System.Windows.Forms.RadioButton radioBtnLinear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxDefinition;
        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnCategory;
    }
}

