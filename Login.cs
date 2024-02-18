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
    public partial class Login : Form
    {
        SqlConnection cn;
        public static int UserId { get; set; }
        public static string UserName { get; set; }
        public static int UserRole { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PavanKumarMN\Downloads\RegistrationAndLogin\RegistrationAndLogin\Quotations.mdf;Integrated Security=True");
            cn.Open();
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            UserId = 1;
            UserName = "pav";
            UserRole = 0;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            UserId = 1;
            UserName = "pav";
            UserRole = 0;


            //if (txtpassword.Text != string.Empty || txtusername.Text != string.Empty)
            //{

            //    cmd = new SqlCommand("select * from Users where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'", cn);
            //    dr = cmd.ExecuteReader();
            //    DataTable dt = new DataTable();
            //    // DataTable.Load automatically advances the reader to the next result set
            //    dt.Load(dr);
            //    if (dt.Rows.Count > 0)
            //    {
            //        UserId = Convert.ToInt32(dt.Rows[0].ItemArray[0]);
            //        UserName = dt.Rows[0].ItemArray[1].ToString();
            //        UserRole = Convert.ToInt32(dt.Rows[0].ItemArray[3]);
            //        dr.Close();
            //        this.Hide();
            //        Home home = new Home();
            //        home.ShowDialog();
            //    }
            //    else
            //    {
            //        dr.Close();
            //        MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
