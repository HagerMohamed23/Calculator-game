using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.IO;
using System.Diagnostics;


namespace CalculatorGame
{
    public partial class Calculator : Form
    {
        //save user points
        int points = 0;
        //level (1-2-3)
        int rank = 1;
        //save user time
        int totalTime = 0;
        //(+ - * /)
        char sign;
        //user name
        string name = "";
        //timer
        System.Timers.Timer t;
        int hour, minute, seconds;
        //list to random sign
        List<char> signs = new List<char> { '+', '-', '*', '/' };
        User user;
        FilesManagment f;

        Random rnd = new Random();
        public Calculator(User u, FilesManagment ff)
        {
            InitializeComponent();
            this.user = u;
            this.f = ff;
        }

        //generte new calculations while running
        private void GenerateNewRandom()
        {
            Random rndm = new Random();

            //Easy Level (1-10)   (+ -)
            if (points >= 0 && points <= 2)
            {
                //2 numbers random
                rndNum1.Text = rndm.Next(1, 10).ToString();
                rndNum2.Text = rndm.Next(1, 10).ToString();
                //random the sign
                int index = rndm.Next(signs.Count - 2);
                rndSign.Text = signs[index].ToString();
                sign = Convert.ToChar(rndSign.Text);
                rank = 1;
            }
            //Easy Level(10-100)   (+ -)
            if (points > 2 && points < 6)
            {
                //2 numbers random
                rndNum1.Text = rndm.Next(10, 100).ToString();
                rndNum2.Text = rndm.Next(10, 100).ToString();
                //random the sign
                int index = rndm.Next(signs.Count - 2);
                rndSign.Text = signs[index].ToString();
                sign = Convert.ToChar(rndSign.Text);
                rank = 1;
            }
            //Medium Level(1-100)  (+ - *)
            if (points >= 6 && points < 8)
            {
                //2 numbers random
                rndNum1.Text = rndm.Next(1, 100).ToString();
                rndNum2.Text = rndm.Next(1, 50).ToString();
                //random the sign
                int index = rndm.Next(signs.Count - 1);
                rndSign.Text = signs[index].ToString();
                sign = Convert.ToChar(rndSign.Text);
                rank = 2;
            }
            //Medium Level(10-100) (+ - *)
            if (points >= 8 && points < 12)
            {
                //2 numbers random
                rndNum1.Text = rndm.Next(10, 100).ToString();
                rndNum2.Text = rndm.Next(10, 100).ToString();
                //random the sign
                int index = rndm.Next(signs.Count - 1);
                rndSign.Text = signs[index].ToString();
                sign = Convert.ToChar(rndSign.Text);
                rank = 2;

            }
            //Hard Level(1-100) (+ - * /)
            if (points >= 12 && points < 30)
            {
                //2 numbers random
                rndNum1.Text = rndm.Next(1, 100).ToString();
                rndNum2.Text = rndm.Next(1, 100).ToString();
                //random the sign
                int index = rndm.Next(signs.Count);
                rndSign.Text = signs[index].ToString();
                sign = Convert.ToChar(rndSign.Text);
                rank = 3;
            }
            //Hard Level(100-1000) (+ - * /)
            if (points >= 30)
            {
                //2 numbers random
                rndNum1.Text = rndm.Next(100, 1000).ToString();
                rndNum2.Text = rndm.Next(100, 1000).ToString();
                //random the sign
                int index = rndm.Next(signs.Count);
                rndSign.Text = signs[index].ToString();
                sign = Convert.ToChar(rndSign.Text);
                rank = 3;
            }
        }

        //click calculate with no result - not integer
        private void validation()
        {
            MessageBox.Show("please enter number in the result!");
        }

        private void CalculateTimeAndExit()
        {
            //go to final form (game over)
            time_label.Hide();
            panel1.Show();
            totalTime = seconds + (minute * 60) + (hour * 60 * 60);
            //final results (points - rank - time)
            pts_final_label.Text = points.ToString();
            rank_final_label.Text = rank.ToString();
            time_final_label.Text = totalTime.ToString() + " seconds";
        }

        //check the result if right or not
        private void CheckTheResult()
        {
            if (sign == '+')
            {
                //if the answer right
                if (Convert.ToInt16(result_txtbox.Text) == (Convert.ToInt16(rndNum1.Text) + Convert.ToInt16(rndNum2.Text)))
                {
                    // points = level number ( level 1 = 1 points , level 2 = 2 points, level 3 = 3 points)
                    if (rank == 1)
                        points++;
                    else if (rank == 2)
                        points += 2;
                    else if (rank == 3)
                        points += 3;
                }
                else
                {
                    //if the answer wrong, get the final results (game over)
                    CalculateTimeAndExit();
                }
                pts_label.Text = points.ToString();
                //generate new qestion
                GenerateNewRandom();
                result_txtbox.Text = "";
            }
            else if (sign == '-')
            {
                if (Convert.ToInt16(result_txtbox.Text) == (Convert.ToInt16(rndNum1.Text) - Convert.ToInt16(rndNum2.Text)))
                {
                    if (rank == 1)
                        points++;
                    else if (rank == 2)
                        points += 2;
                    else if (rank == 3)
                        points += 3;
                }
                else
                {
                    CalculateTimeAndExit();
                }
                pts_label.Text = points.ToString();
                GenerateNewRandom();
                result_txtbox.Text = "";
            }
            if (sign == '*')
            {
                if (Convert.ToInt16(result_txtbox.Text) == (Convert.ToInt16(rndNum1.Text) * Convert.ToInt16(rndNum2.Text)))
                {
                    if (rank == 1)
                        points++;
                    else if (rank == 2)
                        points += 2;
                    else if (rank == 3)
                        points += 3;
                }
                else
                {
                    CalculateTimeAndExit();
                }
                pts_label.Text = points.ToString();
                GenerateNewRandom();
                result_txtbox.Text = "";

            }
            if (sign == '/' && rndNum2.Text != "0")
            {
                if (Convert.ToInt16(result_txtbox.Text) == (Convert.ToInt16(rndNum1.Text) / Convert.ToInt16(rndNum2.Text)))
                {
                    if (rank == 1)
                        points++;
                    else if (rank == 2)
                        points += 2;
                    else if (rank == 3)
                        points += 3;
                }
                else
                {
                    CalculateTimeAndExit();
                }
                pts_label.Text = points.ToString();
                GenerateNewRandom();
                result_txtbox.Text = "";
            }

        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            //start the timer onLoad
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
            t.Start();
            
            panel1.Hide();
            //get questions
            GenerateNewRandom();
        }

        //Calculate timer
        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            seconds += 1;
            Invoke(new Action(() =>
            {
                if (seconds == 60)
                {
                    seconds = 0;
                    minute += 1;
                    time_label.BackColor = Color.Red;
                }
                if (minute == 60)
                {
                    minute = 0;
                    hour += 1;
                    time_label.BackColor = Color.Red;
                }
                time_label.Text = String.Format("{0}:{1}:{2}", hour.ToString().PadLeft(2, '0'), minute.ToString().PadLeft(2, '0'), seconds.ToString().PadLeft(2, '0'));
            }));
        }

        //Calculate the result
        private void calculate_btn_Click(object sender, EventArgs e)
        {
            //check if the result right
            try
            {
                CheckTheResult();
            }
            catch
            {
                int num = -1;
                //chekk if empty/ not integer
                if (result_txtbox.Text == "" || !int.TryParse(result_txtbox.Text, out num))
                {
                    validation();
                }

            }
        }

        //Calculator buttons (numbers)
        private void bttn1_Click(object sender, EventArgs e)
        {
            if (result_txtbox.Text == "")
            {
                result_txtbox.Text = "1";
            }
            else
            {
                result_txtbox.Text = result_txtbox.Text + "1";
            }
        }
        private void bttn2_Click(object sender, EventArgs e)
        {
            if (result_txtbox.Text == "")
            {
                result_txtbox.Text = "2";
            }
            else
            {
                result_txtbox.Text = result_txtbox.Text + "2";
            }
        }
        private void bttn3_Click(object sender, EventArgs e)
        {
            if (result_txtbox.Text == "")
            {
                result_txtbox.Text = "3";
            }
            else
            {
                result_txtbox.Text = result_txtbox.Text + "3";
            }
        }
        private void bttn4_Click(object sender, EventArgs e)
        {
            if (result_txtbox.Text == "")
            {
                result_txtbox.Text = "4";
            }
            else
            {
                result_txtbox.Text = result_txtbox.Text + "4";
            }
        }
        private void bttn5_Click(object sender, EventArgs e)
        {
            if (result_txtbox.Text == "")
            {
                result_txtbox.Text = "5";
            }
            else
            {
                result_txtbox.Text = result_txtbox.Text + "5";
            }
        }
        private void bttn6_Click(object sender, EventArgs e)
        {
            if (result_txtbox.Text == "")
            {
                result_txtbox.Text = "6";
            }
            else
            {
                result_txtbox.Text = result_txtbox.Text + "6";
            }
        }
        private void bttn7_Click(object sender, EventArgs e)
        {
            if (result_txtbox.Text == "")
            {
                result_txtbox.Text = "7";
            }
            else
            {
                result_txtbox.Text = result_txtbox.Text + "7";
            }
        }
        private void bttn8_Click(object sender, EventArgs e)
        {
            if (result_txtbox.Text == "")
            {
                result_txtbox.Text = "8";
            }
            else
            {
                result_txtbox.Text = result_txtbox.Text + "8";
            }
        }
        private void bttn9_Click(object sender, EventArgs e)
        {
            if (result_txtbox.Text == "")
            {
                result_txtbox.Text = "9";
            }
            else
            {
                result_txtbox.Text = result_txtbox.Text + "9";
            }
        }
        private void bttn0_Click(object sender, EventArgs e)
        {
            if (result_txtbox.Text == "")
            {
                result_txtbox.Text = "0";
            }
            else
            {
                result_txtbox.Text = result_txtbox.Text + "0";
            }
        }
        private void minus_btn_Click(object sender, EventArgs e)
        {
            if (result_txtbox.Text == "")
            {
                result_txtbox.Text = "-";
            }
            else
            {
                MessageBox.Show("Error!");
            }

        }

        //read current user's name
        private void getNameFromFile()
        {
            FileStream ff = new FileStream("newNames.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(ff);
            while (sr.Peek() > -1)
            {
                name = sr.ReadLine();
            }
            sr.Close();
            ff.Close();
        }

        //Close the form
        private void exit_btn_Click(object sender, EventArgs e)
        {
            //save user name to the file before closing
            getNameFromFile();
            user = new User(name,points);
            f.AddUser(user);
            f.saveUsers();
            //Close
            Application.Exit();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
