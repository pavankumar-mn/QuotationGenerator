using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RegistrationAndLogin
{
    public partial class Home : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public static int SchoolId { get; set; }
        public static string School { get; set; }
        public static string Brand { get; set; }
        public static string Model { get; set; } = string.Empty;
        public static double? Disount { get; set; } = 0;
        public static string Place { get; set; }

        public Home()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SchoolRegistration schoollist = new SchoolRegistration();
            schoollist.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductRegistration productReg = new ProductRegistration();
            productReg.ShowDialog();
        }

        public void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quotationsDataSetProductDrop.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.DistinctFill(this.quotationsDataSetProductDrop.Products);
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PavanKumarMN\Downloads\RegistrationAndLogin\RegistrationAndLogin\Quotations.mdf;Integrated Security=True");
            cn.Open();
            // TODO: This line of code loads data into the 'quotationsDataSetSchoolListing.Schools' table. You can move, or remove it, as needed.
            this.schoolsTableAdapter.Fill(this.quotationsDataSetSchoolListing.Schools);
            if (Login.UserRole == 1)
            {
                btnPReg.Visible = false;
                lbDiscount.Visible = false;
                txtDiscount.Visible = false;
            }

            cbSchool.SelectedItem = null;
            cbSchool.SelectedText = "--select--";
            cbBrand.SelectedItem = null;
            cbBrand.SelectedText = "--select--";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataRefreshSchools();
        }
        public void DataRefreshSchools()
        {
            cmd = new SqlCommand("Select * from Schools", cn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            this.schoolsTableAdapter.Update(this.quotationsDataSetSchoolListing.Schools);
            cbSchool.DataSource = ds.Tables[0].DefaultView;
            cbSchool.SelectedItem = null;
            cbSchool.SelectedText = "--select--";
        }
        public void DataRefreshProduct()
        {
            cmd = new SqlCommand("SELECT Distinct Brand FROM Products", cn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            cbBrand.DataSource = ds.Tables[0].DefaultView;
            this.productsTableAdapter.DistinctFill(this.quotationsDataSetProductDrop.Products);
            cbBrand.SelectedItem = null;
            cbBrand.SelectedText = "--select--";
        }
        private void btnGetQuotation_Click(object sender, EventArgs e)
        {

            School = cbSchool.Text.ToString();
            SchoolId = Convert.ToInt32(cbSchool.SelectedValue);
            //ProductId = Convert.ToInt32(cbBrand.SelectedValue);
            Brand = cbBrand.Text.ToString();
            Model = cbModel.Text.ToString();
            
            Disount = Convert.ToDouble(txtDiscount.Text.ToString());
            Place = txtLocation.Text.ToString();

            Quotation quotation = new Quotation();
            quotation.ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as System.Windows.Forms.TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            RegisterUser registerUser = new RegisterUser();
            registerUser.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataRefreshSchools();
            DataRefreshProduct();
        }

        private void cbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbModel.Items.Clear();

            if (cbBrand.SelectedIndex > -1)
            {
                cmd = new SqlCommand("Select * from Products where Brand = '" + cbBrand.Text.ToString() + "'", cn);
                dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                if (dt.Rows.Count > 0)
                    foreach (DataRow row in dt.Rows)
                        cbModel.Items.Add(row.ItemArray[2]);
            }
        }

        private void distinctFillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.DistinctFill(this.quotationsDataSetProductDrop.Products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
