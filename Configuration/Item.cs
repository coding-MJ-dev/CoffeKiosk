using Microsoft.VisualBasic;
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

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Coffee_Kiosk.Configuration
{
    public partial class Item : Form
    {
        public Item()
        {
            InitializeComponent();
        }
        public SqlConnection con { get; private set; }


        //show the ItemDB in the dataGrid
        private void ItemLoad(object sender, EventArgs e)
        {
            string dbpath = System.Windows.Forms.Application.StartupPath + "Database1.mdf";
            con = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;AttachDbFilename= " + dbpath + ";";
            SqlDataAdapter da = new SqlDataAdapter("select * from Item ", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Item");
            dataGridItem.DataSource = ds.Tables["Item"].DefaultView;

        }

        // create new Item
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string dbFileName = "Database1.mdf";
                string dbpath = System.IO.Path.Combine(Application.StartupPath, dbFileName);
                string ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;AttachDbFilename={dbpath};";

                string query = "SELECT * FROM Item"; // Use a SELECT query to get the structure of the table

                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        // Create a SqlCommandBuilder to generate insert commands
                        SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "Item");

                        // Create a new row with the data to be inserted
                        DataRow newRow = ds.Tables["Item"].NewRow();
                        newRow["ItemId"] = Convert.ToInt32(ItemId.Text);
                        newRow["ItemName"] = ItemName.Text;
                        newRow["Category"] = Category.Text;
                        newRow["ItemPrice"] = Convert.ToDecimal(ItemPrice.Text);
                        newRow["IsAvailable"] = Convert.ToInt32(IsAvailable.Checked);

                        // Add the new row to the dataset
                        ds.Tables["Item"].Rows.Add(newRow);

                        // Update the database using the data adapter
                        adapter.Update(ds, "Item");

                        MessageBox.Show("Data inserted successfully!");

                        // Reload dataGridItem
                        ItemLoad(sender, e);

                        // Reset input fields
                        ResetInputFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        //when create or modify item finished, it's empty the boxes
        private void ResetInputFields()
        {
            // Reset or clear your TextBoxes or other input controls
            ItemId.Text = string.Empty;
            ItemName.Text = string.Empty;
            Category.Text = string.Empty;
            ItemPrice.Text = string.Empty;
            IsAvailable.Checked = false;
        }

        // select the data row in the grid
        private void SelectItemToModify(object sender, EventArgs e)
        {
            if (dataGridItem.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridItem.SelectedRows[0];

                // Populate TextBoxes with the selected row's data
                ItemId.Text = selectedRow.Cells["ItemId"].Value.ToString();
                ItemName.Text = selectedRow.Cells["ItemName"].Value.ToString();
                Category.Text = selectedRow.Cells["Category"].Value.ToString();
                ItemPrice.Text = selectedRow.Cells["ItemPrice"].Value.ToString();
                IsAvailable.Checked = Convert.ToBoolean(selectedRow.Cells["IsAvailable"].Value);
            }
        }

        // after changed the data, it updates the database
        private void buttonModify_Click(object sender, EventArgs e)
        {
            string dbpath = System.Windows.Forms.Application.StartupPath + "Database1.mdf";
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;AttachDbFilename=" + dbpath + ";";
            string query = "UPDATE Item SET ItemName = @ItemName, Category = @Category, ItemPrice = @ItemPrice, IsAvailable = @IsAvailable WHERE ItemId = @ItemId";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ItemId", Convert.ToInt32(ItemId.Text));
                    cmd.Parameters.AddWithValue("@ItemName", ItemName.Text);
                    cmd.Parameters.AddWithValue("@Category", Category.Text);
                    cmd.Parameters.AddWithValue("@ItemPrice", Convert.ToDecimal(ItemPrice.Text));
                    cmd.Parameters.AddWithValue("@IsAvailable", Convert.ToInt32(IsAvailable.Checked));

                    con.Open();

                    try
                    {
                        // Execute the update query
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data modified successfully!");

                        // Reload dataGridItem
                        ItemLoad(sender, e);

                        // Reset input fields
                        ResetInputFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }

    }
}
