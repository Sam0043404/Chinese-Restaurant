using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chinese_restaraunt
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items = checkedListBox1.CheckedItems;

            foreach (string item in items)
            {
                textBox1.Clear();
                textBox1.Text += item;
            }
            CheckedListBox.CheckedItemCollection items1 = checkedListBox2.CheckedItems;

            foreach (string item in items1)
            {
                textBox2.Clear();
                textBox2.Text += item;
            }
            CheckedListBox.CheckedItemCollection items2 = checkedListBox3.CheckedItems;

            foreach (string item in items2)
            {
                textBox3.Clear();
                textBox3.Text += item;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

       
    }
    }

