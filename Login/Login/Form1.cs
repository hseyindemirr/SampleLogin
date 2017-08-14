using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SampleEntities sampleDB = new SampleEntities();
            string username = textBox1.Text;
            string pw = textBox2.Text;

            var isOkey = sampleDB.People
                 .Where(UserName => UserName.Name == username)
                 .Where(PassWord => PassWord.Surname == pw)
                 .FirstOrDefault();

            if (isOkey!=null)
            {
                MessageBox.Show("Giriş Okey");
            }
            else
            {
                MessageBox.Show("Başarısız DENEME");
            }
//DENEME
        }
    }
}
