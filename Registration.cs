using System;
using System.IO;

namespace PassGuard
{
    public class Registration
    {
        private static readonly string filePath = "C:\\Users\\mosta\\Documents\\OneDrive\\Desktop\\projects\\PassGuard\\Registration.txt";

        public string Email { get; set; }
        public string Password { get; set; }

        public Registration()
        {
        }

        public Registration(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public string Read()
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                return sr.ReadLine();
            }
        }

        public void AddNewAccount(string email, string password)
        {
            using (StreamWriter sw = new StreamWriter(filePath, append: true))
            {
                sw.WriteLine($"{email}//{password}");
            }
        }

        public bool CheckIsExist(string email, string password)
        {
            string account = $"{email}//{password}";

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line == account)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void TestWriteToFile()
        {
            using (StreamWriter sw = new StreamWriter("TestFile.txt", append: true))
            {
                sw.WriteLine("Test line");
            }
        }

    }
}
