using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace CalculatorGame
{
    public class FilesManagment
    {
        //user-his points
        //list (user) carry allUsers;
        List<User> allUsers;

        //get the users-points (dashboard) from file
        public void ReadFile()
        {
            allUsers = new List<User>();
            FileStream f = new FileStream("users.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(f);
            while (sr.Peek() > -1)
            {
                string l = sr.ReadLine();
                string[] vals = l.Split(',');
                allUsers.Add(new User(vals[0], Convert.ToInt16(vals[1])));
            }
            sr.Close();
            f.Close();
        }

        //save the user-points to the file
        public void saveUsers()
        {
            FileStream f = new FileStream("users.txt", FileMode.Truncate);
            StreamWriter sw = new StreamWriter(f);
            foreach(User u in allUsers)
            {
                sw.WriteLine(u.getUsername() + "," + u.getPoints());
            }

            sw.Close();
            f.Close();
        }

        //return the dashboard from file
        public List<User> getUsers()
        {
            return allUsers;
        }

        //add new user to the list
        public void AddUser(User user)
        {
            allUsers.Add(user);
        }
    }
}
