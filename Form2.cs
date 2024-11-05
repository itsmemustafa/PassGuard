using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  ComponentFactory.Krypton.Toolkit;
using PassGuard.User_control;
using static PassGuard.RanodomPassword;


namespace PassGuard
{
    public partial class Form2 : KryptonForm
    {
        Uc_passwordgenerator uc_Passwordgenerator;
        Uc_passstrenght uc_Passstrenght;

        public Form2()
        {
            InitializeComponent();

            // Initialize the UserControls
            uc_Passwordgenerator = new Uc_passwordgenerator();
            uc_Passstrenght = new Uc_passstrenght();

            // Add them to the Panel or Form
            panel1.Controls.Add(uc_Passwordgenerator);
            panel1.Controls.Add(uc_Passstrenght);

            // Position and visibility
            uc_Passwordgenerator.Dock = DockStyle.Fill;
            uc_Passstrenght.Dock = DockStyle.Fill;

            uc_Passstrenght.SendToBack();
            uc_Passwordgenerator.BringToFront();
        }

        private void btn_open_pgpanel_Click(object sender, EventArgs e)
        {
            uc_Passstrenght.SendToBack();
            uc_Passwordgenerator.BringToFront();
        }

        private void btn_open_pspanel_Click(object sender, EventArgs e)
        {
            uc_Passstrenght.BringToFront();
            uc_Passwordgenerator.SendToBack();
        }

        private void kryptonGroupBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }

}