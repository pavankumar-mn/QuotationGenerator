using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RegistrationAndLogin
{
    public partial class ProductRegistration : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        public ProductRegistration()
        {
            InitializeComponent();
        }
        private void Registration_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PavanKumarMN\Downloads\RegistrationAndLogin\RegistrationAndLogin\Quotations.mdf;Integrated Security=True");
            cn.Open();
            DataRefresh();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtBrand.Text != string.Empty && txtMrp.Text != string.Empty)
            {
                cmd = new SqlCommand("insert into Products(Brand,Model,Color,Size,MRP) values(@Brand,@Model,@Color,@Size,@MRP)", cn);
                cmd.Parameters.AddWithValue("Brand", txtBrand.Text);
                cmd.Parameters.AddWithValue("Model", txtModel.Text);
                cmd.Parameters.AddWithValue("Color", txtColor.Text);
                cmd.Parameters.AddWithValue("Size", txtSize.Text);
                cmd.Parameters.AddWithValue("MRP", txtMrp.Text);
                cmd.ExecuteNonQuery();
                txtBrand.Text = string.Empty;
                txtColor.Text = string.Empty;
                txtModel.Text = string.Empty;
                txtSize.Text = string.Empty;
                txtMrp.Text = string.Empty;
                DataRefresh();
                MessageBox.Show("Product is created.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter both Brand Name and MRP", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DataRefresh()
        {
            cmd = new SqlCommand("Select * from Products", cn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            this.productsTableAdapter.Update(this.quotationsDataSetProductListing.Products);
            dataGridViewProduct.DataSource = ds.Tables[0].DefaultView;
            dataGridViewProduct.Refresh();
        }

        private void btnPUpdate_Click(object sender, EventArgs e)
        {
            int[] NumberofColumns = { 0, 1, 2, 3, 4, 5 };
            if (dataGridViewProduct.CurrentCell != null && dataGridViewProduct.CurrentCell.RowIndex >= 0)
            {
                int rowindex = dataGridViewProduct.CurrentCell.RowIndex;
                List<dynamic> Data = new List<dynamic>();
                foreach (int eachrow in NumberofColumns)
                {
                    int columnindex = dataGridViewProduct.Columns[eachrow].Index;
                    Data.Add(dataGridViewProduct.Rows[rowindex].Cells[columnindex].Value);
                }
                if ((!String.IsNullOrEmpty(Data[1].ToString()) && !String.IsNullOrWhiteSpace(Data[1].ToString())) && (!String.IsNullOrEmpty(Data[5].ToString()) && !String.IsNullOrWhiteSpace(Data[5].ToString())))
                {
                    cmd = new SqlCommand("UPDATE Products SET Brand = '" + Data[1] + "', Model= '" + Data[2] + "', Color = '" + Data[3] + "', Size = '" + Data[4] + "', MRP = '" + Data[5] + "' WHERE ProductId =" + Data[0], cn);
                    cmd.ExecuteNonQuery();
                    DataRefresh();
                    MessageBox.Show("Updated");
                }
                else
                {
                    MessageBox.Show("Brand Name and MRP cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduct.CurrentCell != null && dataGridViewProduct.CurrentCell.RowIndex >= 0)
                DeleteSelectedData();
        }
        public void DeleteSelectedData()
        {
            int rowindex = dataGridViewProduct.CurrentCell.RowIndex;
            int columnindex = dataGridViewProduct.Columns[0].Index;
            var ID = dataGridViewProduct.Rows[rowindex].Cells[columnindex].Value;
            cmd = new SqlCommand("Delete from Products where ProductId =" + ID, cn);
            cmd.ExecuteNonQuery();
            DataRefresh();
            MessageBox.Show("Deleted");
        }

        private void btnPClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewProduct_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            int[] NumberofColumns = { 1, 5 };
            int rowindex = dataGridViewProduct.CurrentCell.RowIndex;
            foreach (int eachrow in NumberofColumns)
            {
                int columnindex = dataGridViewProduct.Columns[eachrow].Index;
                string RowValue = dataGridViewProduct.Rows[rowindex].Cells[columnindex].Value.ToString();
                if (!String.IsNullOrEmpty(RowValue) && !String.IsNullOrWhiteSpace(RowValue))
                {
                    MessageBox.Show("Brand Name and MRP cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
        }
    }
}
