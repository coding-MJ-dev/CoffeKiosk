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

namespace Coffee_Kiosk.Configuration
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        public SqlConnection con { get; private set; }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {
            string dbpath = System.Windows.Forms.Application.StartupPath + "Database1.mdf";
            con = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;AttachDbFilename= " + dbpath + ";";
         //   con.Open();
            //string selectquery = "select * from Users where Id = '" + int.Parse(textUser.Text) + "';";
            //SqlCommand cmd = new SqlCommand(selectquery, con);
            //SqlDataReader reader1;
            //reader1 = cmd.ExecuteReader();

            SqlDataAdapter da = new SqlDataAdapter("select * from Users ", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Users");
            dataGridUsers.DataSource = ds.Tables["Users"].DefaultView;

        }
    }
}
