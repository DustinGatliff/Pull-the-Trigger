using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pull_the_Trigger
{
    public partial class Form1 : Form
    {
        public TimerManager manager;
        public Form1()
        {
            InitializeComponent();
            radio5bar.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView5Bar.Rows.Clear();
            

        }

        private void buttonAddTo5List_Click(object sender, EventArgs e)
        {
            if (listBoxOptions5.SelectedItem != null)
            {
                String optionString = listBoxOptions5.SelectedItem.ToString();
                foreach (DataGridViewRow row in dataGridView5Bar.Rows)
                {
                    if (row.Cells[0].Value.ToString() == optionString)
                    {
                        return;
                    }
                }
                dataGridView5Bar.Rows.Add(optionString, 10);
            }
        }

        private void buttonClear3List_Click(object sender, EventArgs e)
        {
            dataGridView3Bar.Rows.Clear();
        }

        private void buttonAddTo3List_Click(object sender, EventArgs e)
        {
            if (listBoxOptions3.SelectedItem != null)
            {
                String optionString = listBoxOptions3.SelectedItem.ToString();
                foreach (DataGridViewRow row in dataGridView3Bar.Rows)
                {
                    if (row.Cells[0].Value.ToString() == optionString)
                    {
                        return;
                    }
                }
                dataGridView3Bar.Rows.Add(optionString, 10);
            }
        }

        private void listBoxOptions3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            buttonAddTo3List_Click(sender, e);
        }

        private void listBoxOptions5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            buttonAddTo5List_Click(sender, e);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            manager = null;
            foreach (Control item in Controls)
            {
                item.Enabled = true;
            }
            buttonStop.Enabled = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            DataGridView selectedView;
            List<string> options = new List<string>();
            List<int> weights = new List<int>();
            if (numericMaxTime.Value < numericMinTime.Value)
            {
                MessageBox.Show("Min time cannot be greater than max time");
                return;
            }
            if (radio3bar.Checked)
            {
                selectedView = dataGridView3Bar;
            }
            else
            {
                selectedView = dataGridView5Bar;
            }
            if (selectedView.Rows.Count == 0)
            {
                return;
            }
            foreach (DataGridViewRow row in selectedView.Rows)
            {
                options.Add(row.Cells[0].Value.ToString());
                if (!row.Cells[1].Value.ToString().All(Char.IsDigit))
                {
                    MessageBox.Show("Weight can only be a whole number.");
                    return;
                }
                weights.Add(Int16.Parse(row.Cells[1].Value.ToString()));
            }
            int timeCallValue = (int)numericUpDown1.Value * 1000;
            if (!checkBoxTimeCall.Checked)
            {
                timeCallValue = -1;
            }
            
            manager = new TimerManager((int)numericMinTime.Value, (int)numericMaxTime.Value, (int)numericSetTime.Value, options, weights, timeCallValue);
            foreach (Control item in Controls)
            {
                item.Enabled = false;
            }
            timer1.Enabled = true;
            timer1.Start();
            buttonStop.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (manager != null)
            {
                manager.DecrementTime(100);
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            About newForm = new About();
            newForm.ShowDialog();

        }
    }
}
