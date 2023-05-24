using Library_Application.Data;
using Library_Application.Models;

namespace Library_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Empty Error", "Can not Null", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            }
            else if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Password Error", "Error???", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            else
            {
                using (ApplicationDbContext application = new ApplicationDbContext())
                {
                    User user = new User() { Email = textBox1.Text, Password = textBox2.Text, ConfirmPassword = textBox3.Text };
                    application.Users.Add(user);
                    application.SaveChanges();
                    
                    Form2 form2 = new Form2();
                    form2.label2.Text = textBox1.Text;
                    form2.pictureBox1.Image = pictureBox4.Image;
                    form2.Show();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
            {
                pictureBox4.ImageLocation = of.FileName;
            }
        }
    }
}