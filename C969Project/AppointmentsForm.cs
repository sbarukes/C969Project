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
    public partial class AppointmentsForm : Form
    {
        public AppointmentsForm()
        {
            InitializeComponent();
        }

        private void AppointmentsForm_Load(object sender, EventArgs e)
        {
            MySqlConnection con = Data.getConnection();
            string com = $"SELECT type, COUNT(*) AS 'Number' FROM appointment GROUP BY type";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(com, con);
            con.Open();
            da.Fill(dt);
            con.Close();

            dataViewAppointmentType.DataSource = dt;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
