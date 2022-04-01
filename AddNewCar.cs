using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRegistration
{
    public partial class AddNewCar : Form
    {
        public AddNewCar()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fileName = "car.txt";

            if (textBoxType.Text != "" && textBoxNumberPlate.Text != "" && textBoxOwner.Text != "" && 
                numericUpDownYear.Value >= 1900 && numericUpDownYear.Value <= 2022)
            {
                StreamWriter writer = new StreamWriter(fileName, true);
                writer.WriteLine(textBoxNumberPlate.Text);
                writer.WriteLine(textBoxOwner.Text);
                writer.WriteLine(textBoxType.Text);
                writer.WriteLine(numericUpDownYear.Value);
                writer.WriteLine(dateTimePickerMotTest.Value);
                writer.WriteLine(checkBoxDiesel.Checked);
                writer.Close();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("There is not all data fulfilled!");
            }
        }
    }
}
