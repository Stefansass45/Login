using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class LoginDB
    {
        private List<User> usersDB = new List<User>();
        
        public LoginDB() { 
        

        }    
     public String verifyUser(String username, String password){
            int counter = 0;
            String verified ="";            
            while (counter < usersDB.Count) {

                if (usersDB[counter].getUsername() == username) {
                    if (usersDB[counter].getPassword() == password) {
                    verified=
                    }
                    else { }
                }                
                counter++;
            }
            return "";    
        }
        
    }
}
