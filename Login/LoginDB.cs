using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class LoginDB
    {
        private List<User> usersDB = new List<User>();

        public LoginDB()
        {

                usersDB.Add(new User("Morgan_Freeman", "SpaceTime25"));
                usersDB.Add(new User("Zuko4Firelord", "WhereAvatar8"));
                usersDB.Add(new User("Youre_FIU_Lady", "uhmekweetnie57"));
                usersDB.Add(new User("admin", "admin"));


        }
        public bool verifyUser(String username, String password)
        {
            int counter = 0;
            bool userIsVerified = false;

            while (counter < usersDB.Count)
            {
                if (usersDB[counter].getUsername() == username)
                {
                    if (usersDB[counter].getPassword() == password)
                    {
                        userIsVerified = true;
                        break; //stop die while loop
                    }
                }
                counter++;
            }
            return userIsVerified;
        }

        public bool isUsernameAvailable(string username)
        {
            bool existingUsernameFound = false;
            foreach (User currentUserRecord in usersDB)
            {
                if (currentUserRecord.getUsername() == username)
                {
                    existingUsernameFound = true;
                }
            }
            return !existingUsernameFound;

        }

        public User addNewUser(User newUser)
        {
            //Check if username already exists
            if (isUsernameAvailable(newUser.getUsername()))
            {
                usersDB.Add(newUser);
                return newUser;
            }
            else
            {
                throw new Exception("Username invalid or not unique");
            }

        }

        public bool deleteUser(String username)
        {

            bool userDeleted = false;

            for (int i = 0; i < usersDB.Count; i++)
            {
                if (usersDB[i].getUsername() == username)
                {
                    usersDB.RemoveAt(i);
                    userDeleted = true;
                    break;
                }
            }

            return userDeleted;

        }

    }
}
