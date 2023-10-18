using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Library;

namespace Laba_3
{
    public partial class Queue : Form
    {
        public Que<string> que1 = new Que<string>();
        public Queue()
        {
            InitializeComponent();
        }

        private void ListBoxRefresh() // Заполнение ListBox 
        {
            {
                listBox1.Items.Clear();
                foreach (string element in que1.value)
                {
                    listBox1.Items.Add(element);
                }
            }
        }
        private void Queue_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                que1.Enqueue(textBox1.Text);
                textBox1.Text = "";
                ListBoxRefresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (que1.value.Count > 0)
            {
                que1.Dequeue();
                ListBoxRefresh();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                int index = que1.Needtofind(textBox2.Text);
                if (index != -1)
                {
                    listBox1.SetSelected(index, true);
                }
                else
                {
                    MessageBox.Show("Не найдено");

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            que1.value.Sort();
            ListBoxRefresh();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                string change = listBox1.SelectedItem.ToString();
                int index = que1.Needtofind(change);
                if (textBox3.Text != null)
                {
                    que1.value[index] = textBox3.Text;
                }
                ListBoxRefresh();
            }
        }
    }
}
