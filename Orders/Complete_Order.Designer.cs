namespace Coffee_Kiosk.Orders
{
    partial class Complete_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Complete_Order));
            buttonCompleteOrder = new Button();
            groupBox1 = new GroupBox();
            dataGridItems = new DataGridView();
            comboClerk = new ComboBox();
            label3 = new Label();
            dateTimeDate = new DateTimePicker();
            label2 = new Label();
            textOrderNo = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridItems).BeginInit();
            SuspendLayout();
            // 
            // buttonCompleteOrder
            // 
            buttonCompleteOrder.Location = new Point(675, 78);
            buttonCompleteOrder.Name = "buttonCompleteOrder";
            buttonCompleteOrder.Size = new Size(165, 53);
            buttonCompleteOrder.TabIndex = 29;
            buttonCompleteOrder.Text = "Complete Order";
            buttonCompleteOrder.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridItems);
            groupBox1.Location = new Point(24, 134);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(816, 309);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Items";
            // 
            // dataGridItems
            // 
            dataGridItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridItems.Location = new Point(7, 34);
            dataGridItems.Name = "dataGridItems";
            dataGridItems.RowHeadersWidth = 62;
            dataGridItems.RowTemplate.Height = 33;
            dataGridItems.Size = new Size(784, 255);
            dataGridItems.TabIndex = 0;
            // 
            // comboClerk
            // 
            comboClerk.FormattingEnabled = true;
            comboClerk.Location = new Point(106, 75);
            comboClerk.Name = "comboClerk";
            comboClerk.Size = new Size(268, 36);
            comboClerk.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 78);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 19;
            label3.Text = "Clerk:";
            // 
            // dateTimeDate
            // 
            dateTimeDate.Location = new Point(477, 24);
            dateTimeDate.Name = "dateTimeDate";
            dateTimeDate.Size = new Size(363, 34);
            dateTimeDate.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(408, 24);
            label2.Name = "label2";
            label2.Size = new Size(57, 28);
            label2.TabIndex = 17;
            label2.Text = "Date:";
            // 
            // textOrderNo
            // 
            textOrderNo.Location = new Point(192, 20);
            textOrderNo.Name = "textOrderNo";
            textOrderNo.Size = new Size(181, 34);
            textOrderNo.TabIndex = 16;
            textOrderNo.TextChanged += textOrderNo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 24);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 15;
            label1.Text = "Order Number:";
            // 
            // Complete_Order
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(867, 469);
            Controls.Add(buttonCompleteOrder);
            Controls.Add(groupBox1);
            Controls.Add(comboClerk);
            Controls.Add(label3);
            Controls.Add(dateTimeDate);
            Controls.Add(label2);
            Controls.Add(textOrderNo);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Complete_Order";
            Text = "Complete_Order";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCompleteOrder;
        private GroupBox groupBox1;
        private DataGridView dataGridItems;
        private ComboBox comboClerk;
        private Label label3;
        private DateTimePicker dateTimeDate;
        private Label label2;
        private TextBox textOrderNo;
        private Label label1;
    }
}