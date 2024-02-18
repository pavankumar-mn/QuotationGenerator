using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationAndLogin
{
    public partial class SchoolRegistration : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public SchoolRegistration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PavanKumarMN\Downloads\RegistrationAndLogin\RegistrationAndLogin\Quotations.mdf;Integrated Security=True");
            cn.Open();
            DataRefresh();
            if (Login.UserRole == 1)
            {
                btnSDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (txtSchoolname.Text != string.Empty && txtSchoolRep.Text != string.Empty)
            {
                cmd = new SqlCommand("select * from Schools where SchoolName like'" + txtSchoolname.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("School Name Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("insert into Schools(SchoolName,SchoolRep,Address) values(@SchoolName,@SchoolRep,@Address)", cn);
                    cmd.Parameters.AddWithValue("SchoolName", txtSchoolname.Text);
                    cmd.Parameters.AddWithValue("SchoolRep", txtSchoolRep.Text);
                    cmd.Parameters.AddWithValue("Address", txtSchoolAddress.Text);
                    cmd.ExecuteNonQuery();
                    txtSchoolname.Text = string.Empty;
                    txtSchoolAddress.Text = string.Empty;
                    txtSchoolRep.Text = string.Empty;
                    DataRefresh();
                    MessageBox.Show("School is created.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter both School Name and Representative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void DataRefresh()
        {
            cmd = new SqlCommand("Select * from Schools", cn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            this.schoolsTableAdapter.Update(this.quotationsDataSetSchoolListing.Schools);
            dataGridViewSchool.DataSource = ds.Tables[0].DefaultView;
            dataGridViewSchool.Refresh();
        }
        private void btnSDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewSchool.CurrentCell != null && dataGridViewSchool.CurrentCell.RowIndex >= 0)
                DeleteSelectedData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int[] NumberofColumns = { 0, 1, 2, 3 };
            if (dataGridViewSchool.CurrentCell != null && dataGridViewSchool.CurrentCell.RowIndex >= 0)
            {
                int rowindex = dataGridViewSchool.CurrentCell.RowIndex;
                List<dynamic> Data = new List<dynamic>();
                foreach (int eachrow in NumberofColumns)
                {
                    int columnindex = dataGridViewSchool.Columns[eachrow].Index;
                    Data.Add(dataGridViewSchool.Rows[rowindex].Cells[columnindex].Value);
                }
                if ((!String.IsNullOrEmpty(Data[1].ToString()) && !String.IsNullOrWhiteSpace(Data[1].ToString())) && (!String.IsNullOrEmpty(Data[2].ToString()) && !String.IsNullOrWhiteSpace(Data[2].ToString())))
                {
                    cmd = new SqlCommand("UPDATE Schools SET SchoolName = '" + Data[1] + "', SchoolRep= '" + Data[2] + "', Address = '" + Data[3] + "' WHERE SchoolId =" + Data[0], cn);
                    cmd.ExecuteNonQuery();
                    DataRefresh();
                    MessageBox.Show("Updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("School Name and Representative cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void DeleteSelectedData()
        {
            int rowindex = dataGridViewSchool.CurrentCell.RowIndex;
            int columnindex = dataGridViewSchool.Columns[0].Index;
            var ID = dataGridViewSchool.Rows[rowindex].Cells[columnindex].Value;
            cmd = new SqlCommand("Delete from Schools where SchoolId =" + ID, cn);
            cmd.ExecuteNonQuery();
            DataRefresh();
            MessageBox.Show("Deleted");
        }
        private void dataGridViewSchool_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            int[] NumberofColumns = { 1, 2 };
            int rowindex = dataGridViewSchool.CurrentCell.RowIndex;
            foreach (int eachrow in NumberofColumns)
            {
                int columnindex = dataGridViewSchool.Columns[eachrow].Index;
                string RowValue = dataGridViewSchool.Rows[rowindex].Cells[columnindex].Value.ToString();
                if (!String.IsNullOrEmpty(RowValue) && !String.IsNullOrWhiteSpace(RowValue))
                {
                    MessageBox.Show("School Name and Representative cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
        }
    }
}
