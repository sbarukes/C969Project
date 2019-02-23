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
            DateTime dateTimeToUploadEnd = addDateTimePickEnd.Value.Date + addTimePickerEnd.Value.TimeOfDay;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
