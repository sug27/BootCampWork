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

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e) {
            string selectedTable = comboBox1.Text;
            string getTable = String.Format("select * from {0}",selectedTable);
            using ( SqlConnection conn = new SqlConnection(@"Data Source=.\TRAININGDB;Initial Catalog=OfficeSupply;Integrated Security=True"))
            {
                using (SqlCommand comm = new SqlCommand(getTable, conn)) {
                    SqlDataAdapter adapt = new SqlDataAdapter(getTable, conn);
                    comm.Connection.Open();
                    adapt.InsertCommand = comm;
                    adapt.InsertCommand.CommandText = getTable;
                    
                    adapt.InsertCommand.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            string selectedTable = comboBox1.Text;
            string[] arr1; 
            if(selectedTable == "Product") {
                
            }
            else if(selectedTable == "Orders") {
               
            }
            else if(selectedTable == "OrderItem") {
               
            }
            else if(selectedTable == "Employees") {
               
            }
            else if(selectedTable == "Category") {
               
            }
            else if(selectedTable == "Supplier") {
                
            }


            string getTable = String.Format("select * from Product", selectedTable);
            using (SqlConnection conn = new SqlConnection(@"Data Source=.\TRAININGDB;Initial Catalog=OfficeSupply;Integrated Security=True")) {
                using (SqlCommand comm = new SqlCommand(getTable, conn)) {
                    SqlDataAdapter adapt = new SqlDataAdapter(getTable, conn);
                    comm.Connection.Open();
                    adapt.InsertCommand = comm;
                    adapt.InsertCommand.CommandText = String.Format("insert into Product Values(@CatID,@Name,@Descript,@UnitCost,@SuppID)");
                    comm.Parameters.AddWithValue("@CatID",int.Parse(textBox1.Text.Trim()));
                    comm.Parameters.AddWithValue("@Name", textBox2.Text.Trim());
                    comm.Parameters.AddWithValue("@Descript",textBox3.Text.Trim());
                    comm.Parameters.AddWithValue("@UnitCost", textBox4.Text.Trim());
                   
                    comm.Parameters.AddWithValue("@SuppID", Int32.Parse(textBox5.Text));
                    adapt.InsertCommand.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            string getTable = "select * from Product";
            using (SqlConnection conn = new SqlConnection(@"Data Source=.\TRAININGDB;Initial Catalog=OfficeSupply;Integrated Security=True")) {
                using (SqlCommand comm = new SqlCommand("", conn)) {
                    SqlDataAdapter adapt = new SqlDataAdapter(getTable, conn);
                    comm.Connection.Open();
                    adapt.UpdateCommand = comm;
                    adapt.UpdateCommand.CommandText = "Update Product set CatID = @CatID, Name = @Name, Descript = @Descript,UnitCost = @UnitCost,SuppID = @SuppID where ProductID = @ProductID";
                    comm.Parameters.AddWithValue("@CatID", int.Parse(textBox1.Text.Trim()));
                    comm.Parameters.AddWithValue("@Name", textBox2.Text.Trim());
                    comm.Parameters.AddWithValue("@Descript", textBox3.Text.Trim());
                    comm.Parameters.AddWithValue("@UnitCost", textBox4.Text.Trim());

                    comm.Parameters.AddWithValue("@SuppID", Int32.Parse(textBox5.Text));
                    comm.Parameters.AddWithValue("@ProductID", Int32.Parse(textBox6.Text.Trim()));
                    adapt.UpdateCommand.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            string getTable = "select * from Product";
            using (SqlConnection conn = new SqlConnection(@"Data Source=.\TRAININGDB;Initial Catalog=OfficeSupply;Integrated Security=True")) {
                using (SqlCommand comm = new SqlCommand("", conn)) {
                    SqlDataAdapter adapt = new SqlDataAdapter(getTable, conn);
                    comm.Connection.Open();
                    adapt.DeleteCommand = comm;
                    adapt.DeleteCommand.CommandText = "Delete from Product where ProductID = @ProductID";
                   
                    comm.Parameters.AddWithValue("@ProductID", Int32.Parse(textBox6.Text.Trim()));

                    adapt.DeleteCommand.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
            }
        }

        
    }
}
