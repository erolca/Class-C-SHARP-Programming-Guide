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
    public partial class MainForm : Form
    {

        private BindingSource bindingSource1;
        private Button button1;

        public MainForm()
        {
            
            this.Load += Form1_Load; ;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DetailForm detailForm = new DetailForm(bindingSource1);
            detailForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void InitializeData()
        {
            bindingSource1 = new System.Windows.Forms.BindingSource();

            // Handle the BindingComplete event to ensure the two forms
            // remain synchronized.
            bindingSource1.BindingComplete +=
                new BindingCompleteEventHandler(bindingSource1_BindingComplete);
            ClientSize = new System.Drawing.Size(292, 266);
            DataSet dataset1 = new DataSet();

            // Some xml data to populate the DataSet with.
            string musicXml =
                "<?xml version='1.0' encoding='UTF-8'?>" +
                "<music>" +
                 "<recording><artist>Dave Matthews</artist>" +
                 "<cd>Under the Table and Dreaming</cd>" +
                 "<releaseDate>1994</releaseDate><rating>3.5</rating></recording>" +
                 "<recording><artist>Coldplay</artist><cd>X&amp;Y</cd>" +
                 "<releaseDate>2005</releaseDate><rating>4</rating></recording>" +
                 "<recording><artist>Dave Matthews</artist>" +
                 "<cd>Live at Red Rocks</cd>" +
                 "<releaseDate>1997</releaseDate><rating>4</rating></recording>" +
                 "<recording><artist>U2</artist>" +
                 "<cd>Joshua Tree</cd><releaseDate>1987</releaseDate>" +
                 "<rating>5</rating></recording>" +
                 "<recording><artist>U2</artist>" +
                 "<cd>How to Dismantle an Atomic Bomb</cd>" +
                 "<releaseDate>2004</releaseDate><rating>4.5</rating></recording>" +
                 "<recording><artist>Natalie Merchant</artist>" +
                 "<cd>Tigerlily</cd><releaseDate>1995</releaseDate>" +
                 "<rating>3.5</rating></recording>" +
                 "</music>";

            // Read the xml.
            System.IO.StringReader reader = new System.IO.StringReader(musicXml);
            dataset1.ReadXml(reader);
            PrintValues(dataset1, "New DataSet");

            // Get a DataView of the table contained in the dataset.
            DataTableCollection tables = dataset1.Tables;
            DataView view1 = new DataView(tables[0]);

            // Create a DataGridView control and add it to the form.
            DataGridView datagridview1 = new DataGridView();
            datagridview1.ReadOnly = true;
            datagridview1.AutoGenerateColumns = true;
            datagridview1.Width = 300;
            this.Controls.Add(datagridview1);
            bindingSource1.DataSource = view1;
            datagridview1.DataSource = bindingSource1;
            datagridview1.Columns.Remove("artist");
            datagridview1.Columns.Remove("releaseDate");

            // Create and add a button to the form. 
            button1 = new Button();
            button1.AutoSize = true;
            button1.Text = "Show/Edit Details";
            this.Controls.Add(button1);
            button1.Location = new Point(50, 200);
            button1.Click += Button1_Click;
        }

        // Handle the BindingComplete event to ensure the two forms
        // remain synchronized.
        private void bindingSource1_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            if (e.BindingCompleteContext == BindingCompleteContext.DataSourceUpdate
                && e.Exception == null)
                e.Binding.BindingManagerBase.EndCurrentEdit();
        }

        // The detailed form will be shown when the button is clicked.
        private void button1_Click(object sender, EventArgs e)
        {
            DetailForm detailForm = new DetailForm(bindingSource1);
            detailForm.Show();
        }

        private void PrintValues(DataSet dataSet, string label)
        {
            Console.WriteLine("\n" + label);
            foreach (DataTable table in dataSet.Tables)
            {
                Console.WriteLine("TableName: " + table.TableName);
                foreach (DataRow row in table.Rows)
                {
                    foreach (DataColumn column in table.Columns)
                    {
                        Console.Write("\t table " + row[column]);
                    }
                    Console.WriteLine();
                }
            }
        }

    }
}
