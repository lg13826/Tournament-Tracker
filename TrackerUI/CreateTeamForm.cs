using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class createTeamForm : Form
    {
        public createTeamForm()
        {
            InitializeComponent();
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = firstNameValue.Text; 
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.PhoneNumber = phoneValue.Text;

                GlobalConfig.Connection.CreatePerson(p);

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                phoneValue.Text = "";

            }
            else
            {
                MessageBox.Show("You need to fill in all fields.");
            }
        }

        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0 || lastNameValue.Text.Length == 0 || emailValue.Text.Length == 0 || phoneValue.Text.Length == 0)
            {
                return false;
            }

            return true;


        }

    }
}
