using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoLibrary;
using DemoLibrary.Models;

namespace WinFormUI
{
    public partial class Dashboard : Form
    {




        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double FirstNumber = double.Parse(FirstNumberTextBox.Text.Trim());
            double SecondNumber = double.Parse(SecondNumberTextBox.Text.Trim());


            double result = Calculator.Add(FirstNumber, SecondNumber);
            ResultsTextBox.Text = result.ToString();


        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadUsers();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            PersonModel person = new PersonModel();
            person.FirstName  = FirsrtNameTextBox.Text.Trim();
            person.LastName = LastNameTextBox.Text.Trim();


            DataAccess.AddNewPerson(person);
            LoadUsers();

        }


        public void LoadUsers()
        {
            List<PersonModel> people = DataAccess.getAllPeople();

            UsersComboBox.DataSource = people;
            UsersComboBox.DisplayMember = "FullName";

            
        }

    }
}
