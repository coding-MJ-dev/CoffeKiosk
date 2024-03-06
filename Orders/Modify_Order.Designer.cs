namespace Coffee_Kiosk.Orders
{
    partial class Modify_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modify_Order));
            buttonModifyOrder = new Button();
            textTotal = new TextBox();
            textDiscount = new TextBox();
            label9 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            numericAmount = new NumericUpDown();
            comboItem = new ComboBox();
            comboCategory = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dataGridItems = new DataGridView();
            comboCustomer = new ComboBox();
            label4 = new Label();
            comboClerk = new ComboBox();
            label3 = new Label();
            dateTimeDate = new DateTimePicker();
            label2 = new Label();
            textOrderNo = new TextBox();
            label1 = new Label();
            buttonSearchOrder = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridItems).BeginInit();
            SuspendLayout();
            // 
            // buttonModifyOrder
            // 
            buttonModifyOrder.Location = new Point(759, 401);
            buttonModifyOrder.Name = "buttonModifyOrder";
            buttonModifyOrder.Size = new Size(150, 81);
            buttonModifyOrder.TabIndex = 29;
            buttonModifyOrder.Text = "Modify Order";
            buttonModifyOrder.UseVisualStyleBackColor = true;
            // 
            // textTotal
            // 
            textTotal.Location = new Point(759, 356);
            textTotal.Name = "textTotal";
            textTotal.Size = new Size(150, 34);
            textTotal.TabIndex = 28;
            // 
            // textDiscount
            // 
            textDiscount.Location = new Point(759, 288);
            textDiscount.Name = "textDiscount";
            textDiscount.Size = new Size(150, 34);
            textDiscount.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(759, 325);
            label9.Name = "label9";
            label9.Size = new Size(58, 28);
            label9.TabIndex = 26;
            label9.Text = "Total:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(759, 257);
            label8.Name = "label8";
            label8.Size = new Size(121, 28);
            label8.TabIndex = 25;
            label8.Text = "Discount ($):";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericAmount);
            groupBox1.Controls.Add(comboItem);
            groupBox1.Controls.Add(comboCategory);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dataGridItems);
            groupBox1.Location = new Point(11, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(742, 379);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Items";
            // 
            // numericAmount
            // 
            numericAmount.Location = new Point(539, 88);
            numericAmount.Name = "numericAmount";
            numericAmount.Size = new Size(180, 34);
            numericAmount.TabIndex = 6;
            // 
            // comboItem
            // 
            comboItem.FormattingEnabled = true;
            comboItem.Location = new Point(76, 85);
            comboItem.Name = "comboItem";
            comboItem.Size = new Size(352, 36);
            comboItem.TabIndex = 5;
            // 
            // comboCategory
            // 
            comboCategory.FormattingEnabled = true;
            comboCategory.Items.AddRange(new object[] { "Hot Drinks", "Cold Drinks", "Cakes", "Sandwiches", "Pastries" });
            comboCategory.Location = new Point(117, 36);
            comboCategory.Name = "comboCategory";
            comboCategory.Size = new Size(311, 36);
            comboCategory.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(446, 90);
            label7.Name = "label7";
            label7.Size = new Size(87, 28);
            label7.TabIndex = 3;
            label7.Text = "Amount:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 88);
            label6.Name = "label6";
            label6.Size = new Size(55, 28);
            label6.TabIndex = 2;
            label6.Text = "Item:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 39);
            label5.Name = "label5";
            label5.Size = new Size(96, 28);
            label5.TabIndex = 1;
            label5.Text = "Category:";
            // 
            // dataGridItems
            // 
            dataGridItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridItems.Location = new Point(6, 136);
            dataGridItems.Name = "dataGridItems";
            dataGridItems.RowHeadersWidth = 62;
            dataGridItems.RowTemplate.Height = 33;
            dataGridItems.Size = new Size(713, 225);
            dataGridItems.TabIndex = 0;
            // 
            // comboCustomer
            // 
            comboCustomer.FormattingEnabled = true;
            comboCustomer.Location = new Point(466, 68);
            comboCustomer.Name = "comboCustomer";
            comboCustomer.Size = new Size(287, 36);
            comboCustomer.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(360, 71);
            label4.Name = "label4";
            label4.Size = new Size(100, 28);
            label4.TabIndex = 21;
            label4.Text = "Customer:";
            // 
            // comboClerk
            // 
            comboClerk.FormattingEnabled = true;
            comboClerk.Location = new Point(85, 68);
            comboClerk.Name = "comboClerk";
            comboClerk.Size = new Size(244, 36);
            comboClerk.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 71);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 19;
            label3.Text = "Clerk:";
            // 
            // dateTimeDate
            // 
            dateTimeDate.Location = new Point(466, 19);
            dateTimeDate.Name = "dateTimeDate";
            dateTimeDate.Size = new Size(330, 34);
            dateTimeDate.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(403, 22);
            label2.Name = "label2";
            label2.Size = new Size(57, 28);
            label2.TabIndex = 17;
            label2.Text = "Date:";
            // 
            // textOrderNo
            // 
            textOrderNo.Location = new Point(117, 19);
            textOrderNo.Name = "textOrderNo";
            textOrderNo.Size = new Size(165, 34);
            textOrderNo.TabIndex = 16;
            textOrderNo.TextChanged += textOrderNo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 15;
            label1.Text = "Order No:";
            // 
            // buttonSearchOrder
            // 
            buttonSearchOrder.Location = new Point(288, 17);
            buttonSearchOrder.Name = "buttonSearchOrder";
            buttonSearchOrder.Size = new Size(82, 38);
            buttonSearchOrder.TabIndex = 23;
            buttonSearchOrder.Text = "Search";
            buttonSearchOrder.UseVisualStyleBackColor = true;
            // 
            // Modify_Order
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(927, 523);
            Controls.Add(buttonModifyOrder);
            Controls.Add(textTotal);
            Controls.Add(textDiscount);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(buttonSearchOrder);
            Controls.Add(comboCustomer);
            Controls.Add(label4);
            Controls.Add(comboClerk);
            Controls.Add(label3);
            Controls.Add(dateTimeDate);
            Controls.Add(label2);
            Controls.Add(textOrderNo);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Modify_Order";
            Text = "Modify_Order";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonModifyOrder;
        private TextBox textTotal;
        private TextBox textDiscount;
        private Label label9;
        private Label label8;
        private GroupBox groupBox1;
        private NumericUpDown numericAmount;
        private ComboBox comboItem;
        private ComboBox comboCategory;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridView dataGridItems;
        private ComboBox comboCustomer;
        private Label label4;
        private ComboBox comboClerk;
        private Label label3;
        private DateTimePicker dateTimeDate;
        private Label label2;
        private TextBox textOrderNo;
        private Label label1;
        private Button buttonSearchOrder;
    }
}