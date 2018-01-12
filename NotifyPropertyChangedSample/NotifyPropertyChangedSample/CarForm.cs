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
    public partial class CarForm : Form
    {
        public CarForm()
        {
            InitializeComponent();
        }
        BindingList<Car> cars = new BindingList<Car>();
        BindingSource bs = new BindingSource();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timerUpdateCurrentSpeeds_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            foreach (Car sc in cars)
            {
                sc.CurrentSpeed = r.Next(30, 120);
            }
        }

        private void btnInitiateCars_Click(object sender, EventArgs e)
        {
            Car sc1 = new Car("34 AAA 34", "Mustafa");
            Car sc2 = new Car("34 BBB 34", "Ahmet");
            Car sc3 = new Car("34 CCC 34", "Mehmet");
            cars.Add(sc1);
            cars.Add(sc2);
            cars.Add(sc3);

            bs.DataSource = cars;
            grvCars.DataSource = bs;
        }
    }
}
