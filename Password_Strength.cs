using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGuard
{ public class Checkpassstrenght
    {
        public string password { get; set; }
        public bool is_long { get; set; } = false;
        public bool has_uppercase { get; set; }=false;
        public bool has_lowercase { get; set; } = false;

        public bool has_number { get; set; } = false;
        public  bool has_spicalchar { get; set; }=false ;


        private void  Islong()
        { if (password.Length >= 8)
          {
                is_long = true;

            }




        }
        private void Isupercase()
        {
            foreach (char c in password)
            { if (char.IsUpper(c))
                {
                    has_uppercase = true; break;

                }


            }
           
        }
        private void Islowercase()
        { foreach (char c in password)
            {
                if (char.IsLower(c))
                {
                  has_lowercase = true; break;
                }
            }
     
        }
        private void Isnumber()
        { foreach(char c in password)
            { if (char.IsNumber(c))
                {
                    has_number = true;
                    break;
                }
            }

        }

        private void ISspicalchar()
        {  foreach(char c in password)
            { if(!char.IsLetterOrDigit(c))
                { has_spicalchar= true;
                    break;
                }

            }
         



        }

        private void checksAll_set()
        {   Islong();
            Isupercase();
            Islowercase();
            Isnumber();
            ISspicalchar();


        }
         public int Measure_strength ()
        {    // to get each rule percentage we have to divide the 100 by the number of rules 
            int percentage = (100 / 5);
            int strength = 0;
            checksAll_set();
            if (is_long)
            { strength += percentage; }
            if(has_lowercase)
            { strength += percentage; }
            if (has_uppercase)
            { strength += percentage; }
            if(has_number)
                { strength += percentage; }
            if(has_spicalchar)
            { strength += percentage; }
            


            return strength;
        }



    }
}
