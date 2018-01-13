using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;


class Form1:Form
    {
    // This button causes the value of a list element to be changed.
    private Button changeItemBtn = new Button();

    // This DataGridView control displays the contents of the list.
    private DataGridView customersDataGridView = new DataGridView();

    // This BindingSource binds the list to the DataGridView control.
    private BindingSource customersBindingSource = new BindingSource();

    public Form1()
    {
       // InitializeComponent();

        // Set up the "Change Item" button.
        this.changeItemBtn.Text = "Change Item";
        this.changeItemBtn.Dock = DockStyle.Bottom;
        this.changeItemBtn.Click += changeItemBtn_Click;
        this.Load += Form1_Load;
        

        // Set up the DataGridView.
        customersDataGridView.Width = 700;
        customersDataGridView.Height = 400;
        customersDataGridView.Dock = DockStyle.Top;


        this.Controls.Add(this.changeItemBtn);
        this.Controls.Add(customersDataGridView);

 
        Height =400;
        Width = 600;

    }

    private void Form1_Load(object sender, EventArgs e)
    {
        // Create and populate the list of DemoCustomer objects
        // which will supply data to the DataGridView.
        BindingList<DemoCustomer> customerList = new BindingList<DemoCustomer>();
        customerList.Add(DemoCustomer.CreateNewCustomer());
        customerList.Add(DemoCustomer.CreateNewCustomer());
        customerList.Add(DemoCustomer.CreateNewCustomer());

        // Bind the list to the BindingSource.
        this.customersBindingSource.DataSource = customerList;

        // Attach the BindingSource to the DataGridView.
        this.customersDataGridView.DataSource =
        this.customersBindingSource;

    }

    private void changeItemBtn_Click(object sender, EventArgs e)
    {
        // Get a reference to the list from the BindingSource.
        BindingList<DemoCustomer> customerList =  this.customersBindingSource.DataSource as BindingList<DemoCustomer>;

        // Change the value of the CompanyName property for the 
        // first item in the list.
        customerList[0].CustomerName = "Tailspin Toys";
        customerList[0].PhoneNumber = "(708)555-0150";
    }

    private void InitializeComponent()
    {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(300, 342);
            this.Name = "Form1";
            this.ResumeLayout(false);

    }
}

