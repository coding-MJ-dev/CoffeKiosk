using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Coffee_Kiosk
{
    public partial class Form1 : Form
    {
        private string user_position;

        public SqlConnection con { get; private set; }

        public Form1()
        {
            InitializeComponent();
            menuKiosk.Visible = false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            menuKiosk.Visible = true;

            string dbpath = System.Windows.Forms.Application.StartupPath + "Database1.mdf";
            con = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;AttachDbFilename= " + dbpath + ";";
            SqlCommand cmd = new SqlCommand("select * from Users where Id=@UserName and Password =@Password", con);
            cmd.Parameters.AddWithValue("@UserName", int.Parse(textUser.Text));
            cmd.Parameters.AddWithValue("@Password", textPassword.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //Connection open here   
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Successfully loged in");
                //after successful it will redirect  to next page .  
                //  WelcomePage settingsForm = new WelcomePage(); //redirect to new page
                // settingsForm.Show();
                con.Open();
                string selectquery = "select type from Users where Id = '" + int.Parse(textUser.Text) + "';";
                cmd = new SqlCommand(selectquery, con);
                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    string type = reader1.GetValue(0).ToString();
                    type = type.Trim();
                    if (type == "S")
                    {
                        user_position = "Store Manager";
                    }
                    // textAGE.Text = reader1.GetValue(2).ToString();
                    //textDEPTID.Text = reader1.GetValue(3).ToString();
                }
                else
                {
                    MessageBox.Show("NO DATA FOUND");
                }
                con.Close();

                switch (user_position)
                {
                    case "Store Manager":
                        // code block
                        break;
                    case "Admin":
                        // code block
                        break;
                    case "Cashier":
                        // code block
                        break;
                    case "Barista":
                        // code block
                        break;
                    default:
                        // code block
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please enter Correct Username and Password");
                //Reset();
                textUser.Text = string.Empty;
                textPassword.Text = string.Empty;
                textUser.Focus();
                //this.Refresh();
                //Form1 form = new Form1();
                //form.InitializeComponent();
            }

            

        }

        private void ConfigurationToolStripMenuUser_Click(object sender, EventArgs e)
        {
            if (user_position == "Store Manager" || user_position == "Admin")
            {
                Configuration.User frm = new Configuration.User();
                frm.Show();
            }
            else
            {
                MessageBox.Show("No access");
            }

        }

        private void ConfigurationToolStripMenuCustomer_Click(object sender, EventArgs e)
        {
            Configuration.Customer frm = new Configuration.Customer();
            frm.Show();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user_position == "Store Manager" || user_position == "Admin")
            {
                Configuration.Item frm = new Configuration.Item();
                frm.Show();
            }
            else
            {
                MessageBox.Show("No access");
            }
        }

        private void OrdersToolStripMenuPlaceOrder_Click(object sender, EventArgs e)
        {
            Orders.Place_Order frm = new Orders.Place_Order();
            frm.Show();
        }

        private void OrdersToolStripMenuCompleteOrder_Click(object sender, EventArgs e)
        {
            Orders.Complete_Order frm = new Orders.Complete_Order();
            frm.Show();
        }

        private void OrdersToolStripMenuModifyOrder_Click(object sender, EventArgs e)
        {
            Orders.Modify_Order frm = new Orders.Modify_Order();
            frm.Show();
        }

        private void ViewToolStripMenuItems_Click(object sender, EventArgs e)
        {
            View.Items_List frm = new View.Items_List();
            frm.Show();
        }

        private void ViewToolStripMenuOrders_Click(object sender, EventArgs e)
        {
            View.Order_List frm = new View.Order_List();
            frm.Show();
        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}