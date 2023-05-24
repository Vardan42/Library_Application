using Library_Application.Data;
using Library_Application.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Application
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DbIntializer.GetAll(label3, label5, button1,1);
            DbIntializer.GetAll(label8, label6, button2,2);
            DbIntializer.GetAll(label11, label9, button3,3);
            DbIntializer.GetAll(label14, label12, button4,4);
            DbIntializer.GetAll(label17, label15, button5,5);
            DbIntializer.GetAll(label20, label18, button6, 6);
            DbIntializer.GetAll(label23, label21, button7, 7);
            DbIntializer.GetAll(label26, label24, button8, 8);
            DbIntializer.GetAll(label29, label27, button8, 9);
            DbIntializer.GetAll(label32, label30, button10, 10);
        }
        Form3 Form3 = new Form3();
        private void button1_Click(object sender, EventArgs e)
        {
            DbIntializer.GetAll(Form3.label3, Form3.label5, Form3.button1, 1);
            Form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DbIntializer.GetAll(Form3.label3, Form3.label5, Form3.button1, 2);
            Form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DbIntializer.GetAll(Form3.label3, Form3.label5, Form3.button1, 3);
            Form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DbIntializer.GetAll(Form3.label3, Form3.label5, Form3.button1, 4);
            Form3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DbIntializer.GetAll(Form3.label3, Form3.label5, Form3.button1, 5);
            Form3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DbIntializer.GetAll(Form3.label3, Form3.label5, Form3.button1, 6);
            Form3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DbIntializer.GetAll(Form3.label3, Form3.label5, Form3.button1, 7);
            Form3.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DbIntializer.GetAll(Form3.label3, Form3.label5, Form3.button1, 9);
            Form3.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DbIntializer.GetAll(Form3.label3, Form3.label5, Form3.button1, 9);
            Form3.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DbIntializer.GetAll(Form3.label3, Form3.label5, Form3.button1, 10);
            Form3.Show();
        }
    }
}
