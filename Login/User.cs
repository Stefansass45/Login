using System.Security.Cryptography;
using System.Text;

namespace Login
{
    public class User
    {
        private String username = "";
        private String password = "";

        public User(String username, String password)
        {
            this.username = username;
            setPassword(password);
        }

        public User(String username, String password,bool skipHashing)
        {
            this.username = username;
            this.password = password;
        }


        public String getUsername() { return username; }
        public String getPassword() { return password; }

        public String setPassword(String rawPassword) {

            string salt = "0CA7AD4D2C49F55334FC92150E72A024742B9EABCEC93C1077673004BD8CE69E";

            //Microsoft. 2024.SHA256 class (system.security.cryptography), 2024. [Online]. Available at: https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.sha256?view=net-8.0 [Accessed 20 March 2024].

            using (SHA256 sha256Instance = SHA256.Create())
            {
                byte[] rawPasswordBytes = Encoding.Default.GetBytes((rawPassword + salt));
                byte[] hashedPasswordBytes = sha256Instance.ComputeHash(rawPasswordBytes);
                string hashedPassword = "";
                foreach (byte currentByte in hashedPasswordBytes)
                {
                    hashedPassword += currentByte.ToString("X2");
                }

                this.password = hashedPassword;
            }

            return this.password;
        }

    }
}
