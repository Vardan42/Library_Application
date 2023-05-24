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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderHeader order = new OrderHeader()
            {
                Name = textBox1.Text,
                Surname=textBox2.Text,
                PhoneNumber=textBox3.Text,
                Address=textBox4.Text,
                City=textBox5.Text,
                PostalCode=textBox6.Text,
                BankCard=textBox7.Text,
            };
            using (ApplicationDbContext db=new ApplicationDbContext())
            {
                db.OrderHeaders.Add(order);
                db.SaveChanges();
            }

            Close();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
        }
    }
}
