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
    public partial class Stack : Form
    {
        public NodeStack<string> stack1 = new NodeStack<string>(); //Создание public стэка   
        public Stack()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            button2.Click += button2_Click;
        }
        private void ListBoxRefresh() // Заполнение ListBox 
        {
            {
                listBox1.Items.Clear();
                foreach (string element in stack1.value)
                {
                    listBox1.Items.Add(element);
                }
            }
        }
        private void listBox(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e) // нажатие кнопки - добавить
        {
            if (textBox1.Text != "")
            {
                stack1.Push(textBox1.Text);
                textBox1.Text = "";
                ListBoxRefresh();
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (stack1.value.Count > 0)
            {
                stack1.Pop();
                ListBoxRefresh();
            }
        }

        private void Stack_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                int index = stack1.Needtofind(textBox2.Text);
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
            stack1.value.Sort();
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
                int index = stack1.Needtofind(change);
                if (textBox3.Text != null)
                {
                    stack1.value[index] = textBox3.Text;
                }
                ListBoxRefresh();
            }
        }
    }
}
