using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PassGuard.RanodomPassword;

namespace PassGuard.User_control
{
    public partial class Uc_passwordgenerator : UserControl
    {
        RanodomPassword rng = new RanodomPassword();
        public Uc_passwordgenerator()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            strengthvalue.Text=sizeTracker.Value.ToString();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            int size = sizeTracker.Value;
            if (chbnumber.Checked && chbspecialChars.Checked)
            {

                Gpasswordtbox.Text = rng.Generatepassword(size, PassType.all);

            }
            else
            {
                if (chbnumber.Checked)
                {


                    Gpasswordtbox.Text = rng.Generatepassword(size, PassType.char_and_numbers);
                }
                else if (chbspecialChars.Checked)
                {


                    Gpasswordtbox.Text = rng.Generatepassword(size, PassType.char_and_specialChars);
                }
                else
                {

                    Gpasswordtbox.Text = rng.Generatepassword(size, PassType.jus_tchar);
                }




            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
             
        }

        private void Uc_passwordgenerator_Load(object sender, EventArgs e)
        {

        }
    }
}
