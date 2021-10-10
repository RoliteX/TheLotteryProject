using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheLotteryProject
{
    public partial class TheLottery : Form
    {
        public TheLottery()
        {
            InitializeComponent();
        }

        private void BtnLottery_Click(object sender, EventArgs e)
        {
            Game1 g1 = new Game1();
            g1.Show();
            this.Hide();
        }
    }
}
