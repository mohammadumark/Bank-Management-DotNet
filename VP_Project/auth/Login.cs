using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Project.auth
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            emailtextBox.Text = "Enter your email";
            passtextBox.Text = "Enter your password";
            emailtextBox.ForeColor = Color.Gray;
            passtextBox.ForeColor = Color.Gray;
        }

        private void emailtextBox_Enter(object sender, EventArgs e)
        {
            if(emailtextBox.Text == "Enter your email")
            {
                emailtextBox.Text = "";
                emailtextBox.ForeColor = Color.Black;
            }
        }

        private void passtextBox_Enter(object sender, EventArgs e)
        {
            if(passtextBox.Text == "Enter your password")
            {
                passtextBox.Text = "";
                passtextBox.ForeColor= Color.Black;
            }
        }

        private void Login_Enter(object sender, EventArgs e)
        {

        }

        private void Login_Leave(object sender, EventArgs e)
        {

        }

        private void emailtextBox_Leave(object sender, EventArgs e)
        {
            if (emailtextBox.Text == "")
            {
                emailtextBox.Text = "Enter your email";
                emailtextBox.ForeColor = Color.Gray;
            }
        }

        private void passtextBox_Leave(object sender, EventArgs e)
        {
            if (passtextBox.Text == "")
            {
                passtextBox.Text = "Enter your password";
                passtextBox.ForeColor = Color.Gray;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Register register= new Register();
            this.Hide();
            register.Show();
        }
    }
}
