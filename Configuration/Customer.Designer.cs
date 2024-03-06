namespace Coffee_Kiosk.Configuration
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            buttonModify = new Button();
            buttonCreate = new Button();
            textAddress = new TextBox();
            textPhone = new TextBox();
            textEmail = new TextBox();
            textName = new TextBox();
            dataGridCustomers = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridCustomers).BeginInit();
            SuspendLayout();
            // 
            // buttonModify
            // 
            buttonModify.Location = new Point(749, 332);
            buttonModify.Margin = new Padding(4);
            buttonModify.Name = "buttonModify";
            buttonModify.Size = new Size(158, 77);
            buttonModify.TabIndex = 28;
            buttonModify.Text = "Modify";
            buttonModify.UseVisualStyleBackColor = true;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(561, 329);
            buttonCreate.Margin = new Padding(4);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(158, 80);
            buttonCreate.TabIndex = 27;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            // 
            // textAddress
            // 
            textAddress.Location = new Point(165, 226);
            textAddress.Margin = new Padding(4);
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(456, 34);
            textAddress.TabIndex = 26;
            // 
            // textPhone
            // 
            textPhone.Location = new Point(165, 158);
            textPhone.Margin = new Padding(4);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(456, 34);
            textPhone.TabIndex = 25;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(165, 92);
            textEmail.Margin = new Padding(4);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(456, 34);
            textEmail.TabIndex = 24;
            // 
            // textName
            // 
            textName.Location = new Point(165, 31);
            textName.Margin = new Padding(4);
            textName.Name = "textName";
            textName.Size = new Size(456, 34);
            textName.TabIndex = 23;
            textName.TextChanged += textName_TextChanged;
            // 
            // dataGridCustomers
            // 
            dataGridCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCustomers.Location = new Point(24, 435);
            dataGridCustomers.Margin = new Padding(4);
            dataGridCustomers.Name = "dataGridCustomers";
            dataGridCustomers.RowHeadersWidth = 51;
            dataGridCustomers.RowTemplate.Height = 29;
            dataGridCustomers.Size = new Size(882, 263);
            dataGridCustomers.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 31);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 18;
            label4.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 92);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 17;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 231);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 16;
            label2.Text = "Address:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 162);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 15;
            label1.Text = "Phone:";
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(936, 726);
            Controls.Add(buttonModify);
            Controls.Add(buttonCreate);
            Controls.Add(textAddress);
            Controls.Add(textPhone);
            Controls.Add(textEmail);
            Controls.Add(textName);
            Controls.Add(dataGridCustomers);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Customer";
            Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)dataGridCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonModify;
        private Button buttonCreate;
        private TextBox textAddress;
        private TextBox textPhone;
        private TextBox textEmail;
        private TextBox textName;
        private DataGridView dataGridCustomers;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}