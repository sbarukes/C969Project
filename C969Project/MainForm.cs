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
            retrieveCusDB();

            retriveCalDB();
        }

        private void cusDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string appCom = $"SELECT        appointment.appointmentId, customer.customerName, customer.customerId, appointment.title, appointment.description, appointment.location, appointment.contact, appointment.start, appointment.end, appointment.type FROM appointment INNER JOIN customer ON appointment.customerId = customer.customerId INNER JOIN `user` ON appointment.userId = `user`.userId WHERE customer.customerId = '{cusDataView.CurrentRow.Cells[0].Value}'";
            MySqlDataAdapter appDA = new MySqlDataAdapter(appCom, Data.getConnection());
            DataSet appDS = new DataSet();
            Data.getConnection().Open();
            appDA.Fill(appDS);

            appDataGridView.DataSource = appDS.Tables[0];
            Data.getConnection().Close();

            foreach (DataGridViewRow row in appDataGridView.Rows)
            {
                DateTime startDateTime = Convert.ToDateTime(row.Cells[7].Value);
                DateTime localStartTime = startDateTime.ToLocalTime();
                row.Cells[7].Value = localStartTime;

                DateTime endDateTime = Convert.ToDateTime(row.Cells[8].Value);
                DateTime localEndTime = endDateTime.ToLocalTime();
                row.Cells[8].Value = localEndTime;
            }

        }

        private void addCusButton_Click(object sender, EventArgs e)
        {
            AddCusForm add = new AddCusForm();
            add.ShowDialog();
        }

        private void upCusButton_Click(object sender, EventArgs e)
        {
            UpdateCusForm upForm = new UpdateCusForm();
            upForm.currentCusID.Text = cusDataView.CurrentRow.Cells[0].Value.ToString();
            upForm.currentAddressID.Text = cusDataView.CurrentRow.Cells[3].Value.ToString();
            upForm.nameText.Text = cusDataView.CurrentRow.Cells[1].Value.ToString();
            upForm.addText.Text = cusDataView.CurrentRow.Cells[4].Value.ToString();
            upForm.numText.Text = cusDataView.CurrentRow.Cells[7].Value.ToString();
            upForm.pCodeText.Text = cusDataView.CurrentRow.Cells[6].Value.ToString();
            upForm.CityListBox.SelectedItem = cusDataView.CurrentRow.Cells[9].Value.ToString();
            upForm.ShowDialog();
        }

        private void delCusButton_Click(object sender, EventArgs e)
        {
            string delCus = $"DELETE FROM customer WHERE customerId = '{Convert.ToInt32(cusDataView.CurrentRow.Cells[0].Value.ToString())}'";
            MySqlConnection con = Data.getConnection();
            MySqlCommand com = new MySqlCommand(delCus, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        private void addAppButton_Click(object sender, EventArgs e)
        {
            AddAppointmentForm appForm = new AddAppointmentForm();
            appForm.cusNameText.Text = cusDataView.CurrentRow.Cells[1].Value.ToString();
            appForm.cusIdText.Text = cusDataView.CurrentRow.Cells[0].Value.ToString();
            appForm.ShowDialog();
        }

        public void retrieveCusDB()
        {
            string cusCom = $"SELECT        customer.customerId, customer.customerName, customer.active, customer.addressId, address.address, address.address2, address.postalCode, address.phone, address.cityId, city.city, city.countryId, country.country FROM customer INNER JOIN address ON customer.addressId = address.addressId INNER JOIN city ON address.cityId = city.cityId INNER JOIN country ON city.countryId = country.countryId";
            MySqlDataAdapter cusda = new MySqlDataAdapter(cusCom, Data.getConnection());
            DataSet cusDS = new DataSet();
            Data.getConnection().Open();
            cusda.Fill(cusDS);
            cusDataView.DataSource = cusDS.Tables[0];
            Data.getConnection().Close();
        }

        public void retriveCalDB()
        {
            string calCom = $"SELECT        appointment.appointmentId, customer.customerName, customer.customerId, appointment.title, appointment.description, appointment.location, appointment.contact, appointment.start, appointment.end, appointment.type FROM appointment INNER JOIN customer ON appointment.customerId = customer.customerId INNER JOIN `user` ON appointment.userId = `user`.userId";
            MySqlDataAdapter calDA = new MySqlDataAdapter(calCom, Data.getConnection());
            DataSet calDS = new DataSet();
            Data.getConnection().Open();
            calDA.Fill(calDS);

            calDataView.DataSource = calDS.Tables[0];
            Data.getConnection().Close();

            foreach (DataGridViewRow row in calDataView.Rows)
            {
                DateTime startDateTime = Convert.ToDateTime(row.Cells[7].Value);
                DateTime localStartTime = startDateTime.ToLocalTime();
                row.Cells[7].Value = localStartTime;

                DateTime endDateTime = Convert.ToDateTime(row.Cells[8].Value);
                DateTime localEndTime = endDateTime.ToLocalTime();
                row.Cells[8].Value = localEndTime;
            }
        }
    }
}
