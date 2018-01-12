using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace NotifyPropertyChangedSample
{
    public partial class SimpleCarForm : Form
    {
        public SimpleCarForm()
        {
            InitializeComponent();
        }
        BindingList<SimpleCar> cars = new BindingList<SimpleCar>();
        BindingSource bs = new BindingSource();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void timerUpdateCurrentSpeeds_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            foreach (SimpleCar sc in cars)
            {
                sc.CurrentSpeed = r.Next(30, 120);
            }
        }
       
        private void btnInitiateCars_Click(object sender, EventArgs e)
        {
            SimpleCar sc1 = new SimpleCar { Plate = "34 AAA 34", Driver = "Mustafa", CurrentSpeed = 0 };
            SimpleCar sc2 = new SimpleCar { Plate = "34 BBB 34", Driver = "Ahmet", CurrentSpeed = 0 };
            SimpleCar sc3 = new SimpleCar { Plate = "34 CCC 34", Driver = "Mehmet", CurrentSpeed = 0 };
            cars.Add(sc1);
            cars.Add(sc2);
            cars.Add(sc3);

            bs.DataSource = cars;
            grvCars.DataSource = bs;
        }
    }
}
