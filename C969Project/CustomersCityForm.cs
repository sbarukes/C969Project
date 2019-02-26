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
    public partial class CustomersCityForm : Form
    {
        public CustomersCityForm()
        {
            InitializeComponent();
        }

        private void CustomersCityForm_Load(object sender, EventArgs e)
        {
            MySqlConnection con = Data.getConnection();
            string com = $"SELECT city.city, COUNT(customer.customerId) AS Expr1 FROM customer INNER JOIN address ON customer.addressId = address.addressId INNER JOIN city ON address.cityId = city.cityId GROUP BY city.city";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(com, con);
            con.Open();
            da.Fill(dt);
            con.Close();

            dataViewCities.DataSource = dt;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
