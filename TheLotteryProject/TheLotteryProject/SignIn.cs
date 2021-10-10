using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TheLotteryProject
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        ConnectionID connect = new ConnectionID();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connect.Address);
            conn.Open();
            SqlCommand sign = new SqlCommand("insert into Tbl_Account (Name, Surname, Age, Username, Password) values (@p1, @p2, @p3, @p4, @p5)", conn);
            sign.Parameters.AddWithValue("@p1", TxtName.Text);
            sign.Parameters.AddWithValue("@p2", TxtSurname.Text);
            sign.Parameters.AddWithValue("@p3", TxtAge.Text);
            sign.Parameters.AddWithValue("@p4", TxtUsername.Text);
            sign.Parameters.AddWithValue("@p5", TxtPassword.Text);
            sign.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sign In Successfull!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
