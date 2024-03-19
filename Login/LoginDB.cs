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
                    verified = usersDB[counter].getUsername(); //as dit tot die punt kom is die username reg met die password so dit is wat ek gebruik het om dit te verify
                    break; //stop die while loop
                    }
                }                
                counter++;
            }
            return "";    
        }
        
    }
}
