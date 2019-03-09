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
        Exception ex;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = Data.getConnection();

            string culture = CultureInfo.CurrentCulture.EnglishName;

            if(culture == "Russian (Russia)")
            {
                ex = new Exception("Неверное имя пользователя или пароль!");
                loginButton.Text = "Авторизоваться";
                loginLabel.Text = "Пожалуйста, введите ваш логин и пароль, чтобы войти.";
                usernameLabel.Text = "имя пользователя";
                passwordLabel.Text = "пароль";
                this.Text = "Назначение Планировщик";
            }
            else
            {
                ex = new Exception("The username or password is incorrect!");
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameText.Text;
            string password = passwordText.Text;

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
            else if(!read.HasRows)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }
    }
}
