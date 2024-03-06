namespace Coffee_Kiosk.View
{
    partial class Items_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Items_List));
            buttonSearch = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dataItemList = new DataGridView();
            comboCategory = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataItemList).BeginInit();
            SuspendLayout();
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(460, 26);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(135, 43);
            buttonSearch.TabIndex = 7;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 26);
            label1.Name = "label1";
            label1.Size = new Size(115, 32);
            label1.TabIndex = 6;
            label1.Text = "Category:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataItemList);
            groupBox1.Location = new Point(21, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(795, 380);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Items";
            // 
            // dataItemList
            // 
            dataItemList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataItemList.Location = new Point(22, 34);
            dataItemList.Name = "dataItemList";
            dataItemList.RowHeadersWidth = 62;
            dataItemList.RowTemplate.Height = 33;
            dataItemList.Size = new Size(754, 324);
            dataItemList.TabIndex = 1;
            // 
            // comboCategory
            // 
            comboCategory.FormattingEnabled = true;
            comboCategory.Items.AddRange(new object[] { "Hot Drinks", "Cold Drinks", "Cakes", "Sandwiches" });
            comboCategory.Location = new Point(125, 26);
            comboCategory.Margin = new Padding(4);
            comboCategory.Name = "comboCategory";
            comboCategory.Size = new Size(326, 39);
            comboCategory.TabIndex = 44;
            comboCategory.SelectedIndexChanged += comboCategory_SelectedIndexChanged;
            // 
            // Items_List
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(832, 485);
            Controls.Add(comboCategory);
            Controls.Add(buttonSearch);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Items_List";
            Text = "Items_List";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataItemList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSearch;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dataItemList;
        private ComboBox comboCategory;
    }
}