using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace LabRnd
{
    public partial class MainForm : Form
    {

        Randstaff randstaff = new Randstaff();
        Sluchislo sluchislo = new Sluchislo();


        public MainForm()
        {
            InitializeComponent();
        }

        private void getRndNumber(object sender, EventArgs e)
        {
            if (cbResource.SelectedIndex == 0)
                sluchislo.countClient(resultRnd, valMin, valMax, cbResource);
            else if (cbResource.SelectedIndex == 1)
                randstaff.countClient(resultRnd, valMin, valMax, cbResource);
            else
                MessageBox.Show("Что-то не так");

        }
        private void refreshForm()
        {
            this.resourceTableAdapter.Fill(this.dataResouce.Resource);
            this.dataTable1TableAdapter.Fill(this.dataHistory.DataTable1);
        }

        private void refreshFormBtn(object sender, EventArgs e)
        {
            refreshForm();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            refreshForm();
        }
    }
}
