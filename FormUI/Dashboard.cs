using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();
        public Dashboard()
        {
            InitializeComponent();
            UpdateBinding();


        }

        private void UpdateBinding()
        {
            peopleFound.DataSource = people;
            peopleFound.DisplayMember = "FullInfo";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people= db.GetPeople(LastNameText.Text);

            UpdateBinding();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void EmailAdressInsLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstNameInsText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.InsertPerson(firstNameInsText.Text, lastNameInsText.Text, EmailAdressInsText.Text, PhoneNumberInsText.Text);
            firstNameInsText.Text = "Eric";
            lastNameInsText.Text = "Fischer";
            EmailAdressInsText.Text = "Hello@Mail.de";
            PhoneNumberInsText.Text = "0176778899";
        }
    }
}
