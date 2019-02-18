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
    public partial class UpdateCusForm : Form
    {
        public UpdateCusForm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            int cityID = 0;

            switch (CityListBox.FindString(CityListBox.SelectedItem.ToString()))
            {
                case 0:
                    cityID = 1;
                    break;
                case 1:
                    cityID = 2;
                    break;
                case 2:
                    cityID = 3;
                    break;
                case 3:
                    cityID = 4;
                    break;
                case 4:
                    cityID = 5;
                    break;
                case 5:
                    cityID = 6;
                    break;
                case 6:
                    cityID = 7;
                    break;
                case 7:
                    cityID = 8;
                    break;
                case 8:
                    cityID = 9;
                    break;
                case 9:
                    cityID = 10;
                    break;
                case 10:
                    cityID = 11;
                    break;
                case 11:
                    cityID = 12;
                    break;
                case 12:
                    cityID = 13;
                    break;
            }
            Data.updateCus(
                Convert.ToInt32(currentCusID.Text),
                nameText.Text,
                Convert.ToInt32(currentAddressID.Text),
                numText.Text,
                addText.Text,
                pCodeText.Text,
                cityID
                );
            this.Close();
        }

        private void cancBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
