using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace C969Project
{
    public partial class LoginForm : Form
    {
        MySqlConnection con;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = Data.getConnection();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameText.Text;
            string password = passwordText.Text;

            string culture = CultureInfo.CurrentCulture.EnglishName;
            string country = culture.Substring(culture.IndexOf('(') + 1, culture.LastIndexOf(')') - culture.IndexOf('(') - 1);

            MySqlCommand com = new MySqlCommand($"SELECT * FROM user WHERE userName = '{usernameText.Text}' AND password = '{passwordText.Text}'", con);
            con.Open();
            MySqlDataReader read = com.ExecuteReader();

            if (read.HasRows)
            {
                while (read.Read())
                {
                    Data.setCurrentUser(Convert.ToInt32(read.GetString(0)));
                }
                MainForm mf = new MainForm();
                mf.ShowDialog();

                //Logs user activity in debug/log.txt
                using (StreamWriter streamWriter = new StreamWriter("log.txt", true))
                {
                    streamWriter.WriteLine(usernameText.Text);
                    streamWriter.WriteLine(DateTime.Now.ToString());
                }

                this.Close();
            }
            else if(!read.HasRows && country != "United States")
            {
                Exception ex = new Exception("The username or password is incorrect!\n" +
                    "Russian: Неверное имя пользователя или пароль");
                MessageBox.Show(ex.Message);
            }
            else if(!read.HasRows && country == "United States")
            {
                Exception ex = new Exception("The username or password is incorrect!");
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }
    }
}
