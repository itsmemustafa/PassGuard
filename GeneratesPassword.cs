using System;


namespace PassGuard
{   class RanodomPassword
    {
       private readonly string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
       private readonly string numbers = "0123456789";
       private readonly string specialChars = "!@#$%^&*()-__-=+[]{}|;:'\",.<>?/";
       public enum PassType{ jus_tchar, char_and_numbers, char_and_specialChars,all }
  
        public string Generatepassword(int length, PassType PasswordType)
        {
            string GeneratorSympols ="";



            switch (PasswordType)
            {
                case PassType.jus_tchar:
                    {
                        GeneratorSympols = chars;
                        break;
                    }
                case PassType.char_and_numbers:
                    {
                        GeneratorSympols = chars + numbers;
                        break;
                    }

                case PassType.char_and_specialChars:
                    {
                        GeneratorSympols = chars + specialChars;
                        break;
                    }

                case PassType.all:
                    {       GeneratorSympols = chars + specialChars + numbers;
                    break;
                    }







            }
            var random = new Random();
            string password = "";
        
            for (int i = 0; i < length; i++)
            {
                password += GeneratorSympols[ random.Next(GeneratorSympols.Length)];
            }


            return password;
        }



    }
}
