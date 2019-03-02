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
    public partial class AddAppointmentForm : Form
    {
        public AddAppointmentForm()
        {
            InitializeComponent();
        }

        private void AddAppointmentForm_Load(object sender, EventArgs e)
        {
            addTimePickerStart.Format = DateTimePickerFormat.Time;
            addTimePickerStart.ShowUpDown = true;
            addTimePickerEnd.Format = DateTimePickerFormat.Time;
            addTimePickerEnd.ShowUpDown = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DateTime dateTimeToUploadStart = addDateTimePickStart.Value.Date + addTimePickerStart.Value.TimeOfDay;
            DateTime dateTimeToUploadEnd = addDateTimePickStart.Value.Date + addTimePickerEnd.Value.TimeOfDay;

            TimeSpan businessStart = TimeSpan.Parse("08:00");
            TimeSpan businessEnd = TimeSpan.Parse("17:00");

            bool overlapCheck = Data.checkCalandar(dateTimeToUploadStart, dateTimeToUploadEnd, 0);

            if((dateTimeToUploadStart.TimeOfDay > businessStart) && (dateTimeToUploadStart.TimeOfDay < businessEnd) &&(dateTimeToUploadEnd.TimeOfDay > businessStart) && (dateTimeToUploadEnd.TimeOfDay < businessEnd))
            {
                if (!overlapCheck)
                {
                    Data.addAppointment(Convert.ToInt32(cusIdText.Text),
                    appTitleText.Text,
                    appDescText.Text,
                    appLocText.Text,
                    appContactText.Text,
                    appURLText.Text,
                    dateTimeToUploadStart,
                    dateTimeToUploadEnd,
                    appTypeText.Text,
                    Data.getCurrentUser());

                    this.Close();
                }
                else
                {
                    Exception ex = new Exception("Appointments Overlap");
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Exception ex = new Exception("Time must be between normal business hours.");
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
