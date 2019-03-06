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
        public static DataSet calDS;
        DataRow[] calArray;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dbQueries();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            retrieveReminder(DateTime.Now);
        }

        private void cusDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            retrieveAppDB();

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

            dbQueries();
        }

        private void addAppButton_Click(object sender, EventArgs e)
        {
            AddAppointmentForm appForm = new AddAppointmentForm();
            appForm.cusNameText.Text = cusDataView.CurrentRow.Cells[1].Value.ToString();
            appForm.cusIdText.Text = cusDataView.CurrentRow.Cells[0].Value.ToString();
            appForm.ShowDialog();
        }

        private void upAppButton_Click(object sender, EventArgs e)
        {
            UpdateAppointmentForm upAppForm = new UpdateAppointmentForm();
            upAppForm.cusIdText.Text = cusDataView.CurrentRow.Cells[0].Value.ToString();
            upAppForm.cusNameText.Text = cusDataView.CurrentRow.Cells[1].Value.ToString();
            upAppForm.appIDText.Text = appDataGridView.CurrentRow.Cells[0].Value.ToString();
            upAppForm.appTitleText.Text = appDataGridView.CurrentRow.Cells[3].Value.ToString();
            upAppForm.appDescText.Text = appDataGridView.CurrentRow.Cells[4].Value.ToString();
            upAppForm.appLocText.Text = appDataGridView.CurrentRow.Cells[5].Value.ToString();
            upAppForm.appContactText.Text = appDataGridView.CurrentRow.Cells[6].Value.ToString();
            upAppForm.appTypeText.Text = appDataGridView.CurrentRow.Cells[9].Value.ToString();
            upAppForm.appURLText.Text = appDataGridView.CurrentRow.Cells[10].Value.ToString();
            upAppForm.updateDateTimePickStart.Value = (DateTime)appDataGridView.CurrentRow.Cells[7].Value;
            upAppForm.updateTimePickerStart.Value = (DateTime)appDataGridView.CurrentRow.Cells[7].Value;
            upAppForm.updateTimePickerEnd.Value = (DateTime)appDataGridView.CurrentRow.Cells[8].Value;

            upAppForm.ShowDialog();
        }

        private void delAppButton_Click(object sender, EventArgs e)
        {
            string delApp = $"DELETE FROM appointment WHERE appointmentId = '{Convert.ToInt32(appDataGridView.CurrentRow.Cells[0].Value.ToString())}'";
            MySqlConnection con = Data.getConnection();
            MySqlCommand com = new MySqlCommand(delApp, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

            dbQueries();
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
            calDS = new DataSet();
            Data.getConnection().Open();
            calDA.Fill(calDS);
            Data.setCalendarSet(calDS);
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

        public void retrieveAppDB() {
            string appCom = $"SELECT        appointment.appointmentId, customer.customerName, customer.customerId, appointment.title, appointment.description, appointment.location, appointment.contact, appointment.start, appointment.end, appointment.type, appointment.url FROM appointment INNER JOIN customer ON appointment.customerId = customer.customerId INNER JOIN `user` ON appointment.userId = `user`.userId WHERE customer.customerId = '{cusDataView.CurrentRow.Cells[0].Value}'";
            MySqlDataAdapter appDA = new MySqlDataAdapter(appCom, Data.getConnection());
            DataSet appDS = new DataSet();
            Data.getConnection().Open();
            appDA.Fill(appDS);

            appDataGridView.DataSource = appDS.Tables[0];
            Data.getConnection().Close();
        }

        //Method that checks for appointments based on login
        public void retrieveReminder(DateTime now)
        {
            //Lambda Expression 1 removes need for looping or if/else statements to check if an appointment is within 15 minutes
            var query = calDS.Tables[0].AsEnumerable().Where(z => (DateTime)z.ItemArray[7] >= DateTime.Now && (DateTime)z.ItemArray[7] <= DateTime.Now.AddMinutes(15));

            List<DataRow> ls = query.ToList();
            if(ls.Count > 0)
            {
                foreach(DataRow row in ls)
                {
                    MessageBox.Show($"You have an appointment at {row.ItemArray[7]}");
                }
            }
        }

        //Controls Calendar DataGridView
        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            EnumerableRowCollection<DataRow> query;

            //lambda expressions 2 reduce the need for more if/else statements by 
            if (weekButton.Checked)
            {
                query = calDS.Tables[0].AsEnumerable().Where(z => (DateTime)z.ItemArray[7] >= DateTime.Today && (DateTime)z.ItemArray[7] <= DateTime.Today.AddDays(7));
            }
            else
            {
                query = calDS.Tables[0].AsEnumerable().Where(z => (DateTime)z.ItemArray[7] >= DateTime.Today && (DateTime)z.ItemArray[7] <= DateTime.Today.AddDays(30));
            }
            try
            {
                DataTable dt = query.CopyToDataTable();
                calDataView.DataSource = dt;
            }
            catch(InvalidOperationException ioe)
            {
                if (weekButton.Checked)
                {
                    MessageBox.Show("There are no appointments in the next 7 days!");
                }
                else
                {
                    MessageBox.Show("There are no appointments in the next 30 days!");
                }
            }
        }

        //Report Button Methods are Below
        private void typeReport_Click(object sender, EventArgs e)
        {
            AppointmentsForm appForm = new AppointmentsForm();
            appForm.ShowDialog();
        }

        private void scheduleReport_Click(object sender, EventArgs e)
        {
            ConsultantSchedules schedulesForm = new ConsultantSchedules();
            schedulesForm.ShowDialog();
        }

        private void cityReport_Click(object sender, EventArgs e)
        {
            CustomersCityForm cusCityForm = new CustomersCityForm();
            cusCityForm.ShowDialog();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            dbQueries();
        }

        public void dbQueries()
        {
            retrieveCusDB();

            retriveCalDB();

            retrieveAppDB();

            calArray = new DataRow[10000];
            calDS.Tables[0].Rows.CopyTo(calArray, 0);
            
        }
    }
}
