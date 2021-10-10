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
    public partial class Game1 : Form
    {
        public Game1()
        {
            InitializeComponent();
        }

        ConnectionID connect = new ConnectionID();

        private void Game1_Load(object sender, EventArgs e)
        { 
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connect.Address);
            conn.Open();
            SqlCommand login = new SqlCommand("Select * From Tbl_Account where Username = @p1 and Password = @p2", conn);
            login.Parameters.AddWithValue("@p1", TxtUsername.Text);
            login.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader dr = login.ExecuteReader();
            if (dr.Read())
            {
                BtnTryChance.Enabled = true;
                MskNum1.Enabled = true;
                MskNum2.Enabled = true;
                MskNum3.Enabled = true;
                MskNum4.Enabled = true;
                TxtUsername.Enabled = false;
                TxtPassword.Enabled = false;
                BtnLogin.Enabled = false;
                LLblSignIn.Enabled = false;
                MessageBox.Show("Login Successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Username or Password Wrong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            BtnTryChance.Enabled = false;
            MskNum1.Enabled = false;
            MskNum2.Enabled = false;
            MskNum3.Enabled = false;
            MskNum4.Enabled = false;
            TxtUsername.Enabled = true;
            TxtUsername.Text = "";
            TxtPassword.Enabled = true;
            TxtPassword.Text = "";
            BtnLogin.Enabled = true;
            LLblSignIn.Enabled = true;
            MessageBox.Show("Successfull Logout!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LLblSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIn ss = new SignIn();
            ss.Show();
        }

        private void BtnTryChance_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int s1, s2, s3, s4;
            s1 = rd.Next(1, 6);
            s2 = rd.Next(1, 6);
            s3 = rd.Next(1, 6);
            s4 = rd.Next(1, 6);
            LblNum1.Text = s1.ToString();
            LblNum2.Text = s2.ToString();
            LblNum3.Text = s3.ToString();
            LblNum4.Text = s4.ToString();

            // Number 1

            if (MskNum1.Text == LblNum1.Text)
            {
                MskNum1.BackColor = Color.Green;
            }
            else
            {
                MskNum1.BackColor = Color.Red;
            }

            // Number 2

            if (MskNum2.Text == LblNum2.Text)
            {
                MskNum2.BackColor = Color.Green;
            }
            else
            {
                MskNum2.BackColor = Color.Red;
            }

            // Number 3

            if (MskNum3.Text == LblNum3.Text)
            {
                MskNum3.BackColor = Color.Green;
            }
            else
            {
                MskNum3.BackColor = Color.Red;
            }

            // Number 4

            if (MskNum4.Text == LblNum4.Text)
            {
                MskNum4.BackColor = Color.Green;
            }
            else
            {
                MskNum4.BackColor = Color.Red;
            }

            // Win or Lose

            if(MskNum1.BackColor == Color.Green && MskNum2.BackColor == Color.Green && MskNum3.BackColor == Color.Green && MskNum4.BackColor == Color.Green)
            {
                PctWin.Visible = true;
                PctLose.Visible = false;
            }
            else
            {
                PctLose.Visible = true;
                PctWin.Visible = false;
            }
        }

        private void gameInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Choose 1-5 and Win or Lose!", "Game Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitTurnToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TheLottery tl = new TheLottery();
            tl.Show();
            this.Hide();
        }

        private void producerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This project was made by Taha Tokucu", "Producer Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
