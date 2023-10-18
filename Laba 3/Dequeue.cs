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
    public partial class Dequeue : Form
    {
        public Deque<string> deque1 = new Deque<string>();
        public Dequeue()
        {
            InitializeComponent();
        }

        private void ListBoxRefresh() // Заполнение ListBox 
        {
            {
                listBox1.Items.Clear();
                foreach (string element in deque1.value)
                {
                    listBox1.Items.Add(element);
                }
            }
        }
        private void Dequeue_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                deque1.AddFirst(textBox1.Text);
                textBox1.Text = "";
                ListBoxRefresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                deque1.AddLast(textBox1.Text);
                textBox1.Text = "";
                ListBoxRefresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (deque1.value.Count > 0)
            {
                deque1.RemoveFirst();
                ListBoxRefresh();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (deque1.value.Count > 0)
            {
                deque1.RemoveLast();
                ListBoxRefresh();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                int index = deque1.Needtofind(textBox2.Text);
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

        private void button6_Click(object sender, EventArgs e)
        {
            deque1.value.Sort();
            ListBoxRefresh();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                string change = listBox1.SelectedItem.ToString();
                int index = deque1.Needtofind(change);
                if (textBox3.Text != null)
                {
                    deque1.value[index] = textBox3.Text;
                }
                ListBoxRefresh();
            }
        }
    }
}
