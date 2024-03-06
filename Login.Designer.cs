namespace Coffee_Kiosk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            labelUser = new Label();
            labelPassword = new Label();
            textUser = new TextBox();
            textPassword = new TextBox();
            buttonLogin = new Button();
            menuKiosk = new MenuStrip();
            configurationToolStripMenuItem = new ToolStripMenuItem();
            ConfigurationToolStripMenuUser = new ToolStripMenuItem();
            ConfigurationToolStripMenuCustomer = new ToolStripMenuItem();
            itemsToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            OrdersToolStripMenuPlaceOrder = new ToolStripMenuItem();
            OrdersToolStripMenuCompleteOrder = new ToolStripMenuItem();
            OrdersToolStripMenuModifyOrder = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            ViewToolStripMenuItems = new ToolStripMenuItem();
            ViewToolStripMenuOrders = new ToolStripMenuItem();
            menuKiosk.SuspendLayout();
            SuspendLayout();
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.BackColor = Color.Transparent;
            labelUser.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelUser.ForeColor = Color.FromArgb(64, 0, 0);
            labelUser.ImeMode = ImeMode.NoControl;
            labelUser.Location = new Point(101, 331);
            labelUser.Margin = new Padding(4, 0, 4, 0);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(92, 45);
            labelUser.TabIndex = 0;
            labelUser.Text = "User:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.ForeColor = Color.FromArgb(64, 0, 0);
            labelPassword.ImeMode = ImeMode.NoControl;
            labelPassword.Location = new Point(101, 410);
            labelPassword.Margin = new Padding(4, 0, 4, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(162, 45);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "Password:";
            // 
            // textUser
            // 
            textUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textUser.Location = new Point(281, 331);
            textUser.Margin = new Padding(4);
            textUser.Name = "textUser";
            textUser.Size = new Size(274, 39);
            textUser.TabIndex = 2;
            textUser.TextChanged += textUser_TextChanged;
            // 
            // textPassword
            // 
            textPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPassword.Location = new Point(281, 410);
            textPassword.Margin = new Padding(4);
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '*';
            textPassword.Size = new Size(274, 39);
            textPassword.TabIndex = 3;
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogin.ForeColor = Color.FromArgb(64, 0, 0);
            buttonLogin.ImeMode = ImeMode.NoControl;
            buttonLogin.Location = new Point(432, 471);
            buttonLogin.Margin = new Padding(4);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(124, 54);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // menuKiosk
            // 
            menuKiosk.ImageScalingSize = new Size(20, 20);
            menuKiosk.Items.AddRange(new ToolStripItem[] { configurationToolStripMenuItem, inventoryToolStripMenuItem, viewToolStripMenuItem });
            menuKiosk.Location = new Point(0, 0);
            menuKiosk.Name = "menuKiosk";
            menuKiosk.Padding = new Padding(8, 2, 0, 2);
            menuKiosk.Size = new Size(995, 33);
            menuKiosk.TabIndex = 5;
            menuKiosk.Text = "menuStrip1";
            // 
            // configurationToolStripMenuItem
            // 
            configurationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ConfigurationToolStripMenuUser, ConfigurationToolStripMenuCustomer, itemsToolStripMenuItem });
            configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            configurationToolStripMenuItem.Size = new Size(137, 29);
            configurationToolStripMenuItem.Text = "Configuration";
            // 
            // ConfigurationToolStripMenuUser
            // 
            ConfigurationToolStripMenuUser.Name = "ConfigurationToolStripMenuUser";
            ConfigurationToolStripMenuUser.Size = new Size(308, 34);
            ConfigurationToolStripMenuUser.Text = "Create/Modify User";
            ConfigurationToolStripMenuUser.Click += ConfigurationToolStripMenuUser_Click;
            // 
            // ConfigurationToolStripMenuCustomer
            // 
            ConfigurationToolStripMenuCustomer.Name = "ConfigurationToolStripMenuCustomer";
            ConfigurationToolStripMenuCustomer.Size = new Size(308, 34);
            ConfigurationToolStripMenuCustomer.Text = "Create Modify Customer";
            ConfigurationToolStripMenuCustomer.Click += ConfigurationToolStripMenuCustomer_Click;
            // 
            // itemsToolStripMenuItem
            // 
            itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            itemsToolStripMenuItem.Size = new Size(308, 34);
            itemsToolStripMenuItem.Text = "Create/Modify Items";
            itemsToolStripMenuItem.Click += itemsToolStripMenuItem_Click;
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OrdersToolStripMenuPlaceOrder, OrdersToolStripMenuCompleteOrder, OrdersToolStripMenuModifyOrder });
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(82, 29);
            inventoryToolStripMenuItem.Text = "Orders";
            // 
            // OrdersToolStripMenuPlaceOrder
            // 
            OrdersToolStripMenuPlaceOrder.Name = "OrdersToolStripMenuPlaceOrder";
            OrdersToolStripMenuPlaceOrder.Size = new Size(242, 34);
            OrdersToolStripMenuPlaceOrder.Text = "Place Order";
            OrdersToolStripMenuPlaceOrder.Click += OrdersToolStripMenuPlaceOrder_Click;
            // 
            // OrdersToolStripMenuCompleteOrder
            // 
            OrdersToolStripMenuCompleteOrder.Name = "OrdersToolStripMenuCompleteOrder";
            OrdersToolStripMenuCompleteOrder.Size = new Size(242, 34);
            OrdersToolStripMenuCompleteOrder.Text = "Complete Order";
            OrdersToolStripMenuCompleteOrder.Click += OrdersToolStripMenuCompleteOrder_Click;
            // 
            // OrdersToolStripMenuModifyOrder
            // 
            OrdersToolStripMenuModifyOrder.Name = "OrdersToolStripMenuModifyOrder";
            OrdersToolStripMenuModifyOrder.Size = new Size(242, 34);
            OrdersToolStripMenuModifyOrder.Text = "Modify Order";
            OrdersToolStripMenuModifyOrder.Click += OrdersToolStripMenuModifyOrder_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ViewToolStripMenuItems, ViewToolStripMenuOrders });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(65, 29);
            viewToolStripMenuItem.Text = "View";
            // 
            // ViewToolStripMenuItems
            // 
            ViewToolStripMenuItems.Name = "ViewToolStripMenuItems";
            ViewToolStripMenuItems.Size = new Size(199, 34);
            ViewToolStripMenuItems.Text = "Items List";
            ViewToolStripMenuItems.Click += ViewToolStripMenuItems_Click;
            // 
            // ViewToolStripMenuOrders
            // 
            ViewToolStripMenuOrders.Name = "ViewToolStripMenuOrders";
            ViewToolStripMenuOrders.Size = new Size(199, 34);
            ViewToolStripMenuOrders.Text = "Orders List";
            ViewToolStripMenuOrders.Click += ViewToolStripMenuOrders_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(995, 551);
            Controls.Add(buttonLogin);
            Controls.Add(textPassword);
            Controls.Add(textUser);
            Controls.Add(labelPassword);
            Controls.Add(labelUser);
            Controls.Add(menuKiosk);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuKiosk;
            Margin = new Padding(4);
            MaximumSize = new Size(1017, 607);
            MinimumSize = new Size(1017, 607);
            Name = "Form1";
            Text = "Coffee Kiosk";
            menuKiosk.ResumeLayout(false);
            menuKiosk.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUser;
        private Label labelPassword;
        private TextBox textUser;
        private TextBox textPassword;
        private Button buttonLogin;
        private MenuStrip menuKiosk;
        private ToolStripMenuItem configurationToolStripMenuItem;
        private ToolStripMenuItem ConfigurationToolStripMenuUser;
        private ToolStripMenuItem ConfigurationToolStripMenuCustomer;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private ToolStripMenuItem OrdersToolStripMenuPlaceOrder;
        private ToolStripMenuItem OrdersToolStripMenuModifyOrder;
        private ToolStripMenuItem itemsToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem ViewToolStripMenuItems;
        private ToolStripMenuItem ViewToolStripMenuOrders;
        private ToolStripMenuItem OrdersToolStripMenuCompleteOrder;
    }
}