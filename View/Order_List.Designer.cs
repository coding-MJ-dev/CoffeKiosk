namespace Coffee_Kiosk.View
{
    partial class Order_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_List));
            groupBox1 = new GroupBox();
            dataGridOrders = new DataGridView();
            dateTimeDate = new DateTimePicker();
            label1 = new Label();
            buttonSearch = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOrders).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridOrders);
            groupBox1.Location = new Point(21, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(723, 329);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Orders";
            // 
            // dataGridOrders
            // 
            dataGridOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOrders.Location = new Point(16, 33);
            dataGridOrders.Name = "dataGridOrders";
            dataGridOrders.RowHeadersWidth = 62;
            dataGridOrders.RowTemplate.Height = 33;
            dataGridOrders.Size = new Size(685, 273);
            dataGridOrders.TabIndex = 1;
            dataGridOrders.CellContentClick += dataGridOrders_CellContentClick;
            // 
            // dateTimeDate
            // 
            dateTimeDate.Location = new Point(84, 27);
            dateTimeDate.Name = "dateTimeDate";
            dateTimeDate.Size = new Size(330, 34);
            dateTimeDate.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 27);
            label1.Name = "label1";
            label1.Size = new Size(57, 28);
            label1.TabIndex = 2;
            label1.Text = "Date:";
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(420, 27);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(123, 38);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // Order_List
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(762, 435);
            Controls.Add(buttonSearch);
            Controls.Add(label1);
            Controls.Add(dateTimeDate);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Order_List";
            Text = "Order_List";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridOrders;
        private DateTimePicker dateTimeDate;
        private Label label1;
        private Button buttonSearch;
    }
}