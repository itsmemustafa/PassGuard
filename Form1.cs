  using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PassGuard
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            lblwelcome.Focus();
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void kryptonTextBox1_Enter(object sender, EventArgs e)
        {
            if(Emailtbox.Text== "Enter Email ")
                {
                Emailtbox.Text = "";
                Emailtbox.ForeColor = Color.Black;

            }
        }
       private void kryptonTextBox1_Leave(object sender, EventArgs e)
        {
            if (Emailtbox.Text == "")
            {    Emailtbox.ForeColor = Color.Gray;
                Emailtbox.Text = "Enter Email ";
            

            }

        }
     

        private void kryptonTextBox2_Enter(object sender, EventArgs e)
        {
            if (Passtbox.Text == "Enter Password")
            {
                Passtbox.Text = "";
                Passtbox.ForeColor = Color.Black;

            }

        }

        private void kryptonTextBox2_Leave(object sender, EventArgs e)
        {
            if (Passtbox.Text == "")
            {
                Passtbox.ForeColor = Color.Gray;
                Passtbox.Text = "Enter Password";
          

            }
        }

        private void rdhidepass_Click(object sender, EventArgs e)
        { if(Passtbox.Text!= "Enter Password")
            if (!Passtbox.UseSystemPasswordChar)
            {
                Passtbox.UseSystemPasswordChar = true;
                Passtbox.PasswordChar = '*';
               
            }
            else
            {
                Passtbox.UseSystemPasswordChar = false;

            }
        }

        private void rdsignup_Click(object sender, EventArgs e)
        {
            {
                Registration registration = new Registration();
                bool isExist = registration.CheckIsExist(Emailtbox.Text, Passtbox.Text);

                if (!isExist)
                {
                    registration.AddNewAccount(Emailtbox.Text, Passtbox.Text);
                    registration.TestWriteToFile();
                    MessageBox.Show("Account created successfully!");
                }
                else
                {
                    MessageBox.Show("This email is already used");
                }

            }
           

        }

        private void rdsignin_Click(object sender, EventArgs e)
        {
        
            Registration registration = new Registration();
            bool isExist = registration.CheckIsExist(Emailtbox.Text, Passtbox.Text);

            if (isExist)
            {
                Form frm = new Form2();
                frm.Show();
                this.Hide();
             frm.FormClosed += (s, args) => this.Close();
            }
            else
            {
                wrongpassmasseglbl.Visible = true;
            }

        }

        private void Passtbox_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void kryptonRibbonGroup1_DialogBoxLauncherClick(object sender, EventArgs e)
        {

        }
    }
}
