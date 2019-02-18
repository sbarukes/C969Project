using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            MySqlCommand com = new MySqlCommand($"SELECT * FROM user WHERE userName = '{usernameText.Text}' AND password = '{passwordText.Text}'", con);
            con.Open();
            MySqlDataReader read = com.ExecuteReader();

            if (read.HasRows)
            {
                MainForm mf = new MainForm();
                mf.ShowDialog();
                this.Close();
            }
            else
            {
                Exception ex = new Exception("The username or password is incorrect!\n" +
                    "Russian: Неверное имя пользователя или пароль");
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }
    }
}
