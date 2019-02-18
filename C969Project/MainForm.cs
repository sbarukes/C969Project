using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace C969Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string cusCom = $"SELECT        customer.customerId, customer.customerName, customer.active, customer.addressId, address.address, address.address2, address.postalCode, address.phone, address.cityId, city.city, city.countryId, country.country FROM customer INNER JOIN address ON customer.addressId = address.addressId INNER JOIN city ON address.cityId = city.cityId INNER JOIN country ON city.countryId = country.countryId";
            MySqlDataAdapter cusda = new MySqlDataAdapter(cusCom, Data.getConnection());
            DataSet cusDS = new DataSet();
            Data.getConnection().Open();
            cusda.Fill(cusDS);
            cusDataView.DataSource = cusDS.Tables[0];
            Data.getConnection().Close();

            string calCom = $"SELECT        appointment.appointmentId, customer.customerName, customer.customerId, appointment.title, appointment.description, appointment.location, appointment.contact, appointment.start, appointment.end, appointment.type FROM appointment INNER JOIN customer ON appointment.customerId = customer.customerId INNER JOIN `user` ON appointment.userId = `user`.userId";
            MySqlDataAdapter calDA = new MySqlDataAdapter(calCom, Data.getConnection());
            DataSet calDS = new DataSet();
            Data.getConnection().Open();
            calDA.Fill(calDS);
            calDataView.DataSource = calDS.Tables[0];
            Data.getConnection().Close();
        }

        private void cusDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string appCom = $"SELECT        appointment.appointmentId, customer.customerName, customer.customerId, appointment.title, appointment.description, appointment.location, appointment.contact, appointment.start, appointment.end, appointment.type FROM appointment INNER JOIN customer ON appointment.customerId = customer.customerId INNER JOIN `user` ON appointment.userId = `user`.userId WHERE customer.customerId = '{cusDataView.CurrentRow.Cells[0].Value}'";
            MySqlDataAdapter appDA = new MySqlDataAdapter(appCom, Data.getConnection());
            DataSet appDS = new DataSet();
            Data.getConnection().Open();
            appDA.Fill(appDS);
            dataGridView1.DataSource = appDS.Tables[0];
            Data.getConnection().Close();
        }
    }
}
