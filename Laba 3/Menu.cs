using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laba_3
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Stack stack = new Stack();
            stack.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Queue queue = new Queue();
            queue.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dequeue dequeue = new Dequeue();
            dequeue.Show();
        }
    }
}
