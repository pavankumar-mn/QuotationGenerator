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

namespace RegistrationAndLogin
{
    public partial class RegisterUser : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public RegisterUser()
        {
            InitializeComponent();
        }
        private void RegisterUser_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PavanKumarMN\Downloads\RegistrationAndLogin\RegistrationAndLogin\Quotations.mdf;Integrated Security=True");
            cn.Open();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string password = txtpassword.Text.Trim();
            string confirmPassword = txtconfirmpassword.Text.Trim();
            if (txtusername.Text != string.Empty)
            {
                if ((String.IsNullOrEmpty(confirmPassword) && !String.IsNullOrEmpty(password)) || (!String.IsNullOrEmpty(confirmPassword) && String.IsNullOrEmpty(password)))
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtpassword.Text == txtconfirmpassword.Text)
                {
                    if (String.IsNullOrEmpty(confirmPassword) && String.IsNullOrEmpty(password))
                        password = txtusername.Text.ToString() + "@123";
                    cmd = new SqlCommand("select * from Users where username='" + txtusername.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into Users(username,password) values(@username,@password)", cn);
                        cmd.Parameters.AddWithValue("username", txtusername.Text);
                        cmd.Parameters.AddWithValue("password", password);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Please enter User Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtconfirmpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

    }
}