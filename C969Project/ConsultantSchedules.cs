using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969Project
{
    public partial class ConsultantSchedules : Form
    {
        public ConsultantSchedules()
        {
            InitializeComponent();
        }

        private void ConsultantSchedules_Load(object sender, EventArgs e)
        {
            MySqlConnection con = Data.getConnection();
            string com = $"SELECT        `user`.userName, appointment.start FROM            `user` INNER JOIN appointment ON `user`.userId = appointment.userId ORDER BY `user`.userName, appointment.start";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(com, con);
            con.Open();
            da.Fill(dt);
            con.Close();

            dataViewSchedules.DataSource = dt;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
