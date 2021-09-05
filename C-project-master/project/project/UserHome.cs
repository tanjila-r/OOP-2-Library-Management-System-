using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class UserHome : Form
    {
        UserClass user;
        public UserHome(UserClass user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookDetailsFrom bdf = new BookDetailsFrom(user);
            bdf.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BorrowHistoryForm bhf = new BorrowHistoryForm(user);
            bhf.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserHome_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 one = new Form1();
            one.Show();
            this.Close();
        }
    }
}
