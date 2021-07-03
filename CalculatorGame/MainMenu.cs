using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CalculatorGame
{
    public partial class MainMenu : Form
    {
        //save-read (file)
        List<User> allusers;
        //hold the username
        string tempName;
        FilesManagment f;
        User u;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void names_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //click start (save the name,hide the form, open calculator game form)
        private void name_bttn_Click(object sender, EventArgs e)
        {
            //check if the user enter his name
            if (name_textbox.Text == "")
                validation();
            else
            {
                //save the name to "newNames" file
                tempName = name_textbox.Text;
                FileStream ff = new FileStream("newNames.txt", FileMode.Truncate);
                StreamWriter sw = new StreamWriter(ff);
                sw.WriteLine(tempName);
                sw.Close();
                ff.Close();
                //hide main menu form
                this.Hide();
                //f.ReadFile();
                //open calculator form
                Calculator c = new Calculator(u, f);
                c.Show();
            }
        }

        //check if the user entered his name
        private void validation()
        {
            MessageBox.Show("please enter your name!");
        }

        private void MainMenu_Load_1(object sender, EventArgs e)
        {
            //get the users (name-points) from the file
            f = new FilesManagment();
            f.ReadFile();
            allusers = f.getUsers();

            //show the Dashboard(users)
                 // columns of datagrid view (userID, userName, userPoints)
            string[] columns = { "ID", "Name", "Points" };
            names_dataGridView1.ColumnCount = columns.Length;
            for (int i = 0; i < columns.Length; i++)
            {
                names_dataGridView1.Columns[i].Name = columns[i];
            }
                 //rows of datagridview for eachUser
            for (int i = 0; i < allusers.Count; i++)
            {
                List<string> row = new List<string>();
                row.Add((i + 1).ToString() + " - ");
                row.Add(allusers[i].getUsername());
                row.Add(allusers[i].getPoints().ToString());

                names_dataGridView1.Rows.Add(row.ToArray());
            }
        }

        //Close the form
        private void Exit_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
