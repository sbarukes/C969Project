﻿using System;
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
    public partial class UpdateAppointmentForm : Form
    {
        public UpdateAppointmentForm()
        {
            InitializeComponent();
        }

        private void UpdateAppointmentForm_Load(object sender, EventArgs e)
        {
            updateTimePickerStart.Format = DateTimePickerFormat.Time;
            updateTimePickerStart.ShowUpDown = true;
            updateTimePickerEnd.Format = DateTimePickerFormat.Time;
            updateTimePickerEnd.ShowUpDown = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DateTime dateTimeToUploadStart = updateDateTimePickStart.Value.Date + updateTimePickerStart.Value.TimeOfDay;
            DateTime dateTimeToUploadEnd = updateDateTimePickStart.Value.Date + updateTimePickerEnd.Value.TimeOfDay;

            TimeSpan businessStart = TimeSpan.Parse("08:00");
            TimeSpan businessEnd = TimeSpan.Parse("17:00");

            bool overlapCheck = Data.checkCalandar(dateTimeToUploadStart, dateTimeToUploadEnd, Convert.ToInt32(appIDText.Text));

            if ((dateTimeToUploadStart.TimeOfDay > businessStart) && (dateTimeToUploadStart.TimeOfDay < businessEnd) && (dateTimeToUploadEnd.TimeOfDay > businessStart) && (dateTimeToUploadEnd.TimeOfDay < businessEnd)) {
                if (!overlapCheck)
                {
                    Data.updateAppointment(Convert.ToInt32(appIDText.Text),
                        appTitleText.Text,
                        appDescText.Text,
                        appLocText.Text,
                        appContactText.Text,
                        appURLText.Text,
                        dateTimeToUploadStart,
                        dateTimeToUploadEnd,
                        appTypeText.Text);

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
