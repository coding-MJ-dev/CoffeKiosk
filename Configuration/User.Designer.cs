namespace Coffee_Kiosk.Configuration
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridUsers = new DataGridView();
            comboPosition = new ComboBox();
            label5 = new Label();
            checkActive = new CheckBox();
            textName = new TextBox();
            textEmail = new TextBox();
            textUser = new TextBox();
            textPassword = new TextBox();
            buttonCreate = new Button();
            buttonModify = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridUsers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 167);
            label1.Name = "label1";
            label1.Size = new Size(59, 30);
            label1.TabIndex = 1;
            label1.Text = "User:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 212);
            label2.Name = "label2";
            label2.Size = new Size(104, 30);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 74);
            label3.Name = "label3";
            label3.Size = new Size(68, 30);
            label3.TabIndex = 3;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 30);
            label4.Name = "label4";
            label4.Size = new Size(74, 30);
            label4.TabIndex = 4;
            label4.Text = "Name:";
            // 
            // dataGridUsers
            // 
            dataGridUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsers.Location = new Point(19, 375);
            dataGridUsers.Name = "dataGridUsers";
            dataGridUsers.RowHeadersWidth = 51;
            dataGridUsers.RowTemplate.Height = 29;
            dataGridUsers.Size = new Size(642, 188);
            dataGridUsers.TabIndex = 5;
            dataGridUsers.CellContentClick += dataGridUsers_CellContentClick;
            // 
            // comboPosition
            // 
            comboPosition.FormattingEnabled = true;
            comboPosition.Items.AddRange(new object[] { "Store Manager", "Admin", "Cashier", "Barista" });
            comboPosition.Location = new Point(126, 117);
            comboPosition.Name = "comboPosition";
            comboPosition.Size = new Size(151, 36);
            comboPosition.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 120);
            label5.Name = "label5";
            label5.Size = new Size(91, 30);
            label5.TabIndex = 7;
            label5.Text = "Position:";
            // 
            // checkActive
            // 
            checkActive.AutoSize = true;
            checkActive.Location = new Point(24, 263);
            checkActive.Name = "checkActive";
            checkActive.Size = new Size(96, 34);
            checkActive.TabIndex = 8;
            checkActive.Text = "Active";
            checkActive.UseVisualStyleBackColor = true;
            // 
            // textName
            // 
            textName.Location = new Point(126, 30);
            textName.Name = "textName";
            textName.Size = new Size(333, 35);
            textName.TabIndex = 9;
            textName.TextChanged += textName_TextChanged;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(126, 76);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(333, 35);
            textEmail.TabIndex = 10;
            // 
            // textUser
            // 
            textUser.Location = new Point(126, 164);
            textUser.Name = "textUser";
            textUser.Size = new Size(151, 35);
            textUser.TabIndex = 11;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(126, 209);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(151, 35);
            textPassword.TabIndex = 12;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(408, 303);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(115, 57);
            buttonCreate.TabIndex = 13;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            // 
            // buttonModify
            // 
            buttonModify.Location = new Point(546, 303);
            buttonModify.Name = "buttonModify";
            buttonModify.Size = new Size(115, 55);
            buttonModify.TabIndex = 14;
            buttonModify.Text = "Modify";
            buttonModify.UseVisualStyleBackColor = true;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(673, 586);
            Controls.Add(buttonModify);
            Controls.Add(buttonCreate);
            Controls.Add(textPassword);
            Controls.Add(textUser);
            Controls.Add(textEmail);
            Controls.Add(textName);
            Controls.Add(checkActive);
            Controls.Add(label5);
            Controls.Add(comboPosition);
            Controls.Add(dataGridUsers);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "User";
            Text = "User";
            Load += User_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridUsers;
        private ComboBox comboPosition;
        private Label label5;
        private CheckBox checkActive;
        private TextBox textName;
        private TextBox textEmail;
        private TextBox textUser;
        private TextBox textPassword;
        private Button buttonCreate;
        private Button buttonModify;
    }
}