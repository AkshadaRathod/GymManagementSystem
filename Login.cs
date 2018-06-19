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

namespace GymManagementSystem
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection();
        public Login()
        {
            //con.ConnectionString = "Data Source=AKSHU-PC\\SQLEXPRESS;Initial Catalog=logintable;Integrated Security=True";


            InitializeComponent();
            timer1.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=AKSHU-PC\\SQLEXPRESS;Initial Catalog=logintable;Integrated Security=True");
            //con.Open();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (usrName.Text.Equals("admin") && usrPassword.Text.Equals("admin"))
            {
                timer2.Enabled = true;
                timer2.Start();
                Home h = new Home();
                h.Show();
            }
            else
            {
                MessageBox.Show("      Incorrect Login Id or Password      ");
                usrName.Text = "";
                usrPassword.Text = "";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.01;
            if (this.Opacity >= 0.98)
            {
                timer1.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.01;
            if (this.Opacity <= 0)
            {
                this.Visible = false;
                timer2.Enabled = false;
                //new MembersForm().Show();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
