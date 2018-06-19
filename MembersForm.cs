using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GymManagementSystem
{
    public partial class MembersForm : Form
    {
        public MembersForm()
        {
            InitializeComponent();
        }

        

        private void FNTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Character Is Allowed");
            }
        }

        private void LNTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Character Is Allowed");
            }
        }

       
        private void adressRichTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Character,Numeric,punctuation,symbol Is Allowed");
                
            }
        }

        private void PhNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Numeric Is Allowed");
            }
        }

    

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MembersForm_Load(object sender, EventArgs e)
        {

        }

        private void emailTextBox_Validating(object sender, CancelEventArgs e)
        {
            String s1, s2;
            s1 = emialTextBox.Text;
            s2 = @"^[\w-]+@([\w-]+\.)+[\w-]+$";
            if (Regex.IsMatch(s1, s2))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(emialTextBox, "Email Id Not Entered Correctly");
                emialTextBox.Focus();
                emialTextBox.SelectAll();
            }
        }

        private void FNTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void packageGBox_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPkDateFrom_Click(object sender, EventArgs e)
        {

        }
    }
}
