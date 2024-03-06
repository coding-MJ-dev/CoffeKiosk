using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Kiosk.View
{
    public partial class Items_List : Form
    {
        public Items_List()
        {
            InitializeComponent();
        }
        public SqlConnection con { get; private set; }
        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string category = comboCategory.Text;
            ItemLoad(sender, e, category);
        }
        private void ItemLoad(object sender, EventArgs e, string category)
        {
            
            string dbpath = System.Windows.Forms.Application.StartupPath + "Database1.mdf";
            con = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;AttachDbFilename= " + dbpath + ";";
            SqlCommand cmd = new SqlCommand("SELECT * FROM Item WHERE Category = @Category", con);
            cmd.Parameters.AddWithValue("@Category", category);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Item");
            dataItemList.DataSource = ds.Tables["Item"].DefaultView;

        }
    }
}
