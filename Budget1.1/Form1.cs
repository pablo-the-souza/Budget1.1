using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Budget1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mainBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mainBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.main' table. You can move, or remove it, as needed.
            this.mainTableAdapter.Fill(this.dataSet1.main);

        }

        private void mainDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
