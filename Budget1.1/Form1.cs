using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;

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
            this.tableAdapterManager1.UpdateAll(this.dataSet2);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.mainTableAdapter1.DeleteQuery(Int32.Parse(deleteTxt.Text));
            this.tableAdapterManager1.UpdateAll(this.dataSet2);
            this.mainTableAdapter1.Fill(this.dataSet2.main);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.main' table. You can move, or remove it, as needed.
            this.mainTableAdapter1.Fill(this.dataSet2.main);

            List<String> categories = new List<String>();

            foreach (DataRow row in dataSet2.main)
            {
                categories.Add(row["category"].ToString());
            }

            var distinct = categories.Distinct();
            foreach (String cat in distinct) {
                categoryCB.Items.Add(cat);
             }

            typeCB.Items.Add("Expense");
            typeCB.Items.Add("Income");

            monthCB.Items.Add("July");
            monthCB.Items.Add("August");
        }

        private void fillByCategoryBtn_Click(object sender, EventArgs e)
        {
            this.mainTableAdapter1.FillByCategory(this.dataSet2.main, categoryCB.SelectedItem.ToString());
            
        }

        private void fillByDateBtn_Click(object sender, EventArgs e)
        {
            this.mainTableAdapter1.FillByDate
               (
               this.dataSet2.main,
               monthCalendarStart.SelectionRange.Start.ToString(),
               monthCalendarStart.SelectionRange.End.ToString()
               );
        }

        private void fillByTypeBtn_Click(object sender, EventArgs e)
        {
            this.mainTableAdapter1.FillByType
               (
               this.dataSet2.main,
               typeCB.SelectedItem.ToString()
               );
        }

        private void fillByDateAndCategoryBtn_Click(object sender, EventArgs e)
        {
            this.mainTableAdapter1.FillByDateAndCategory
               (
               this.dataSet2.main,
               categoryCB.SelectedItem.ToString(),
               monthCalendarStart.SelectionRange.Start.ToString(), monthCalendarStart.SelectionRange.End.ToString()
               );
        }

        private void FillByDateAndTypeBtn_Click(object sender, EventArgs e)
        {
            this.mainTableAdapter1.FillByDateAndType
               (
               this.dataSet2.main,
               typeCB.SelectedItem.ToString(),
               monthCalendarStart.SelectionRange.Start.ToString(), monthCalendarStart.SelectionRange.End.ToString()
               );
        }


        private void fillByMonthBtn_Click(object sender, EventArgs e)
        {
                this.mainTableAdapter1.FillByDate
                   (
                   this.dataSet2.main,
                   monthCalendarStart.SelectionRange.Start.ToString(),
                   monthCalendarStart.SelectionRange.End.ToString()
                   );
            Console.WriteLine(monthCalendarStart.SelectionRange.Start.ToString());

            if (monthCB.SelectedItem.ToString().Equals("August"))
            {
                this.mainTableAdapter1.FillByDate
                   (
                   this.dataSet2.main,
                    "8 / 01 / 2020 12:00:00 AM",
                    "8 / 31 / 2020 11:59:59 PM"
                   );
            } else if (monthCB.SelectedItem.ToString().Equals("July"))

            {
                this.mainTableAdapter1.FillByDate
                   (
                   this.dataSet2.main,
                    "7 / 01 / 2020 12:00:00 AM",
                    "7 / 31 / 2020 11:59:59 PM"
                   );
            }
            else if (monthCB.SelectedItem.ToString().Equals("June"))

            {
                this.mainTableAdapter1.FillByDate
                   (
                   this.dataSet2.main,
                    "6 / 01 / 2020 12:00:00 AM",
                    "6 / 30 / 2020 11:59:59 PM"
                   );
            }
        }

        // 8/14/2020 12:00:00 AM


        private void showAllBtn_Click(object sender, EventArgs e)
        {
            this.mainTableAdapter1.Fill(this.dataSet2.main);
            sumExpenses();
            //sumIncomes();
        }

        //private void sumIncomes()
        //{
        //    throw new NotImplementedException();
        //}


        // calculation methods

        private void sumExpensesByDate()
        {

            decimal sumGroceries = 0;
            decimal sumTransport = 0; 
            foreach (DataRow row in dataSet2.main)
            {
                string dbDate = row["date"].ToString();
                string date1 = monthCalendarStart.SelectionRange.Start.ToString();
                string date2 = monthCalendarStart.SelectionRange.End.ToString();

                DateTime DbDate = Convert.ToDateTime(dbDate);
                DateTime Date1 = Convert.ToDateTime(date1);
                DateTime Date2 = Convert.ToDateTime(date2);

                int compare1 = DateTime.Compare(DbDate, Date1);
                int compare2 = DateTime.Compare(DbDate, Date2);

                if (compare1 >= 0 && compare2 <= 0)
                {
                    if (row["category"].ToString().Equals("Groceries"))
                    {
                        sumGroceries = sumGroceries + Decimal.Parse(row["value"].ToString());
                    }  else if (row["category"].ToString().Equals("Transport")) 
                    {
                        sumTransport = sumTransport + Decimal.Parse(row["value"].ToString());
                    }
                    

                }
            }
            MessageBox.Show("Groceries: " + sumGroceries + ", Transport: " + sumTransport);
        }



        private void sumExpenses()
        {
            decimal sum = 0;
            foreach (DataRow row in dataSet2.main)
            {
                if (row["type"].ToString().Equals("Expense"))
                {
                    decimal value = Decimal.Parse(row["value"].ToString());
                    sum = value + sum;
                }
            }
            MessageBox.Show("Expenses = " + sum.ToString());
           
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            sumExpensesByDate();
 
        }

        private void categoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }






        //private void button3_Click(object sender, EventArgs e)
        //{
        //    decimal sum = (decimal)this.mainTableAdapter1.GetSum(monthCalendarStart.SelectionRange.Start.ToString(), monthCalendarStart.SelectionRange.End.ToString());
        //}



        //private void sum(String category)
        //{
        //    decimal sum = 0;
        //    foreach (DataRow row in dataSet2.main)
        //    {
        //        if (row["category"].ToString().Equals(category))
        //        {
        //            decimal value = Decimal.Parse(row["value"].ToString());
        //            sum = value + sum;
        //        }
        //    }
        //    MessageBox.Show("This category = " + sum.ToString());
        //}

    }
}
