using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDate();
            LoadPrograms();
        }
        
        private void LoadDate()
        {
            
            for (int i = 1; i <= 31; i++)
            {
                cbDay.Items.Add(i);
            }

           
            string[] months = {
                "January", "February", "March", "April",
                "May", "June", "July", "August",
                "September", "October", "November", "December"
            };

            foreach (string month in months)
            {
                cbMonth.Items.Add(month);
            }

           
            for (int i = 1980; i <= 2025; i++)
            {
                cbYear.Items.Add(i);
            }
        }

        
        private void LoadPrograms()
        {
            ArrayList programs = new ArrayList();

            programs.Add("Bachelor of Science in Computer Science");
            programs.Add("Bachelor of Science in Information Technology");
            programs.Add("Bachelor of Science in Information Systems");
            programs.Add("Bachelor of Science in Computer Engineering");

            foreach (string program in programs)
            {
                cbProgram.Items.Add(program);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            string middleName = txtMiddleName.Text;

            string gender = rbMale.Checked ? "Male" : "Female";

            string day = cbDay.Text;
            string month = cbMonth.Text;
            string year = cbYear.Text;

            string program = cbProgram.Text;

            string output =
                "Student name: " + firstName + " " + middleName + " " + lastName + "\n" +
                "Gender: " + gender + "\n" +
                "Date of birth: " + day + "/" + month + "/" + year + "\n" +
                "Program: " + program;

            MessageBox.Show(output, "Student Information");
        }
    }
}
        
    

