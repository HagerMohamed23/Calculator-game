using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGame
{
    public class User
    {
        string userName;
        int Points;

        public User(string username, int points)
        {
            this.userName = username;
            this.Points = points;
        }
        public void setUsername(string username)
        {
            this.userName = username;
        }
        //return userName
        public string getUsername()
        {
            return userName;
        }

        public void setPoints(int point)
        {
            this.Points = point;
        }
        //return score of the user
        public int getPoints()
        {
            return Points;
        }
    }
}
