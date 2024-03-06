namespace Coffee_Kiosk.Configuration
{
    partial class Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item));
            buttonModify = new Button();
            buttonCreate = new Button();
            ItemName = new TextBox();
            dataGridItem = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            IsAvailable = new CheckBox();
            Category = new ComboBox();
            label2 = new Label();
            ItemPrice = new TextBox();
            label1 = new Label();
            ItemId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridItem).BeginInit();
            SuspendLayout();
            // 
            // buttonModify
            // 
            buttonModify.Location = new Point(1080, 278);
            buttonModify.Margin = new Padding(4);
            buttonModify.Name = "buttonModify";
            buttonModify.Size = new Size(158, 77);
            buttonModify.TabIndex = 39;
            buttonModify.Text = "Modify";
            buttonModify.UseVisualStyleBackColor = true;
            buttonModify.Click += buttonModify_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(895, 275);
            buttonCreate.Margin = new Padding(4);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(158, 80);
            buttonCreate.TabIndex = 38;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
 
            // 
            // ItemName
            // 
            ItemName.Location = new Point(167, 103);
            ItemName.Margin = new Padding(4);
            ItemName.Name = "ItemName";
            ItemName.Size = new Size(456, 39);
            ItemName.TabIndex = 34;
            
            // 
            // dataGridItem
            // 
            dataGridItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridItem.Location = new Point(17, 375);
            dataGridItem.Margin = new Padding(4);
            dataGridItem.Name = "dataGridItem";
            dataGridItem.RowHeadersWidth = 51;
            dataGridItem.RowTemplate.Height = 29;
            dataGridItem.Size = new Size(1240, 263);
            dataGridItem.TabIndex = 33;
            dataGridItem.CellContentClick += SelectItemToModify;
            this.dataGridItem.SelectionChanged += new System.EventHandler(this.SelectItemToModify);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 106);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(83, 32);
            label4.TabIndex = 32;
            label4.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 169);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 32);
            label3.TabIndex = 31;
            label3.Text = "Category:";
            // 
            // IsAvailable
            // 
            IsAvailable.AutoSize = true;
            IsAvailable.Location = new Point(34, 298);
            IsAvailable.Margin = new Padding(4);
            IsAvailable.Name = "IsAvailable";
            IsAvailable.Size = new Size(136, 36);
            IsAvailable.TabIndex = 40;
            IsAvailable.Text = "Available";
            IsAvailable.UseVisualStyleBackColor = true;
            
            // 
            // Category
            // 
            Category.FormattingEnabled = true;
            Category.Items.AddRange(new object[] { "Hot Drinks", "Cold Drinks", "Cakes", "Sandwiches" });
            Category.Location = new Point(167, 169);
            Category.Margin = new Padding(4);
            Category.Name = "Category";
            Category.Size = new Size(456, 39);
            Category.TabIndex = 43;
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 232);
            label2.Name = "label2";
            label2.Size = new Size(104, 32);
            label2.TabIndex = 44;
            label2.Text = "Price ($):";
            // 
            // ItemPrice
            // 
            ItemPrice.Location = new Point(167, 229);
            ItemPrice.Margin = new Padding(4);
            ItemPrice.Name = "ItemPrice";
            ItemPrice.Size = new Size(456, 39);
            ItemPrice.TabIndex = 45;
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 32);
            label1.TabIndex = 46;
            label1.Text = "ID:";
            // 
            // ItemId
            // 
            ItemId.Location = new Point(167, 39);
            ItemId.Margin = new Padding(4);
            ItemId.Name = "ItemId";
            ItemId.Size = new Size(456, 39);
            ItemId.TabIndex = 47;
            
            // 
            // Item
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1270, 653);
            Controls.Add(ItemId);
            Controls.Add(label1);
            Controls.Add(ItemPrice);
            Controls.Add(label2);
            Controls.Add(Category);
            Controls.Add(IsAvailable);
            Controls.Add(buttonModify);
            Controls.Add(buttonCreate);
            Controls.Add(ItemName);
            Controls.Add(dataGridItem);
            Controls.Add(label4);
            Controls.Add(label3);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Item";
            Text = "Item";
            Load += ItemLoad;
            ((System.ComponentModel.ISupportInitialize)dataGridItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonModify;
        private Button buttonCreate;
        private TextBox ItemName;
        private DataGridView dataGridItem;
        private Label label4;
        private Label label3;
        private CheckBox IsAvailable;
        private ComboBox Category;
        private Label label2;
        private TextBox ItemPrice;
        private Label label1;
        private TextBox ItemId;
    }
}