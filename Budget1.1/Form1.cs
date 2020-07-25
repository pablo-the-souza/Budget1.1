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

        private void button1_Click(object sender, EventArgs e)
        {
            this.mainTableAdapter.FillByCategory(this.dataSet1.main, category.Text);
            sum(category.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.mainTableAdapter.GetWeek(this.dataSet1.main, monthCalendarStart.SelectionRange.Start.ToString() , monthCalendarStart.SelectionRange.End.ToString());
              
        }

        private void sum(String category)
        {
            decimal sum = 0;
            foreach (DataRow row in dataSet1.main)
            {
                if (row["category"].ToString().Equals(category))
                {
                    decimal value = Decimal.Parse(row["value"].ToString());
                    sum = value + sum;
                }
            }
            MessageBox.Show("This category = " + sum.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal sum = 0;
            foreach (DataRow row in dataSet1.main)
            {
                decimal value = Decimal.Parse(row["value"].ToString());
                sum = value + sum; 
            }
            MessageBox.Show(sum.ToString());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void valueLabel_Click(object sender, EventArgs e)
        {

        }

        private void valueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void categoryLabel_Click(object sender, EventArgs e)
        {

        }

        private void categoryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void category_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.mainTableAdapter.FillByCategoryAndDate
                (
                this.dataSet1.main, 
                category.Text, 
                monthCalendarStart.SelectionRange.Start.ToString(), monthCalendarStart.SelectionRange.End.ToString()
                );
               
        }
    }
}
