using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassGuard.User_control
{
    public partial class Uc_passstrenght : UserControl
    {
        Checkpassstrenght chs=new Checkpassstrenght();
        public Uc_passstrenght()
        {
            InitializeComponent();
        }
        public void change_lble_color(Label lbl,bool state)
        {
            if (state)
            {
                lbl.ForeColor = Color.Green;
        
            }
            else
            {
                lbl.ForeColor = Color.Red;
     
            }
        }
 private void strengthtoword(int strength)
        { if (strength <=21)
            { strength_lbl.Text = " Very Weak !";
              strength_lbl.ForeColor = Color.Red;
            }
            else
            {
                if(strength >=21&&strength<=40)
                {
                    strength_lbl.Text = "Weak !";
                    strength_lbl.ForeColor = Color.LightCoral;

                }
                else
                { if(strength >=41&&strength<=60)
                    {
                        strength_lbl.Text = "Medium";
                        strength_lbl.ForeColor = Color.Gold;
 
                    }
                    else
                    { if (strength >= 61 && strength <= 80)
                        {
                            strength_lbl.Text = "Strong ";
                            strength_lbl.ForeColor = Color.LightBlue;

                        }
                        else
                        {
                            strength_lbl.Text = "Secure ";
                            strength_lbl.ForeColor = Color.Green;
                        }

                    }

                }
            }

        }

        private void btn_Checkstrenght_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PS_txtbox.Text))
            {    chs.password = PS_txtbox.Text;
                int strengthinnumber = chs.Measure_strength();
               
                strengthtoword(strengthinnumber);
                change_lble_color(lbl_long, chs.is_long);
                change_lble_color(lbl_Numbers, chs.has_number);
                change_lble_color(lbl_uppercase, chs.has_uppercase);
                change_lble_color(lbl_spicalchars, chs.has_spicalchar);
            }
            else
            {
                MessageBox.Show("Please enter a password before checking its strength.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reset();
            }
        }

        private void PS_txtbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PS_txtbox.Text))
            {
                reset();
            }
        }

        private void reset()
        {
            lbl_long.ForeColor=Color.Black;
            lbl_Numbers.ForeColor=Color.Black;
            lbl_spicalchars.ForeColor=Color.Black;
            lbl_uppercase.ForeColor=Color.Black;
            strength_lbl.Text = "";


        }
        private void Uc_passstrenght_Load(object sender, EventArgs e)
        {

        }

        private void PS_txtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Checkstrenght_Click(sender, e);
                //to turn off enter sound 
                e.SuppressKeyPress = true;
            }
        }
    }
}
