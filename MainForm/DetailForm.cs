using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingSourceMultipleForms
{
    public partial class DetailForm : Form
    {
        private BindingSource formDataSource;
        public DetailForm(BindingSource dataSource)
        {
            InitializeComponent();
            formDataSource = dataSource;
            this.ClientSize = new Size(240, 200);
            TextBox textBox1 = new TextBox();
            this.Text = "Selection Details";
            textBox1.Width = 220;
            TextBox textBox2 = new TextBox();
            TextBox textBox3 = new TextBox();
            TextBox textBox4 = new TextBox();
            textBox4.Width = 30;
            textBox3.Width = 50;

            // Associate each text box with a column from the data source.
            textBox1.DataBindings.Add("Text", formDataSource, "cd", true, DataSourceUpdateMode.OnPropertyChanged);

            textBox2.DataBindings.Add("Text", formDataSource, "artist", true);
            textBox3.DataBindings.Add("Text", formDataSource, "releaseDate", true);
            textBox4.DataBindings.Add("Text", formDataSource, "rating", true);
            textBox1.Location = new Point(10, 10);
            textBox2.Location = new Point(10, 40);
            textBox3.Location = new Point(10, 80);
            textBox4.Location = new Point(10, 120);
            this.Controls.AddRange(new Control[] { textBox1, textBox2, textBox3, textBox4 });
        }
    }
}
