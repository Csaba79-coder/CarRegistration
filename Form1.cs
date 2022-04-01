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
    public partial class Form1 : Form
    {

        List<Car> cars = new List<Car>();

        public Form1()
        {
            InitializeComponent();
            ReadData();
            WriteData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddNewCar_Click(object sender, EventArgs e)
        {
            AddNewCar newCar = new AddNewCar();
            newCar.ShowDialog();

            if (newCar.DialogResult == DialogResult.OK)
            {
                ReadData();
                WriteData();
            }
        }

        private void ReadData()
        {
            string fileName = "car.txt";
            StreamReader reader = new StreamReader(fileName);

            while (!reader.EndOfStream)
            {
                Car currentCar = new Car();
                currentCar.NumberPlate = reader.ReadLine();
                currentCar.Owner = reader.ReadLine();
                currentCar.Type = reader.ReadLine();
                currentCar.YearOfProduction = Convert.ToInt32(reader.ReadLine());
                currentCar.MotTestExpireDate = Convert.ToDateTime(reader.ReadLine());
                currentCar.IsGasoline = Convert.ToBoolean(reader.ReadLine());
                cars.Add(currentCar);
            }
            reader.Close();
        }

        private void WriteData()
        {
            listBoxCars.Items.Clear();

            foreach (Car car in cars)
            {
                listBoxCars.Items.Add(car.NumberPlate + " : " + car.Owner);
            }
        }

        private void listBoxCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBoxDiesel.Checked = false;

            if (listBoxCars.SelectedIndex >= 0)
            {
                textBoxNumberPlate.Text = cars[listBoxCars.SelectedIndex].NumberPlate.ToString();
                textBoxOwner.Text = cars[listBoxCars.SelectedIndex].Owner.ToString();
                textBoxType.Text = cars[listBoxCars.SelectedIndex].Type.ToString();
                textBoxYearOfProd.Text = cars[listBoxCars.SelectedIndex].ToString();
                textBoxMotTestExpDate.Text = cars[listBoxCars.SelectedIndex].ToString();

                bool diesel = cars[listBoxCars.SelectedIndex].IsGasoline;

                if (diesel)
                {
                    checkBoxDiesel.Checked = true;
                }
                else
                {
                    checkBoxDiesel.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("There is no data choosen!");
            }
        }
    }
}
