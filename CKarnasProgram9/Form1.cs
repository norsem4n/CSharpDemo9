/* CIS 605 Homework 4 - Program 9
 * Created:             October 2020
 * Last Modified:       10.18.20
 * Developed by:        Christopher Karnas
 * Class name:          Form1
 */ 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CKarnasProgram9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // declare class level variables 

        private Conference aConference;
        private string conferenceName;
        private int numberOfAttendees, numberOfNights;
        private bool internetYN, recCenterYN;
        private AccommodationType accommodationChoice;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //check Name TexBox

            if (txtConferenceName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Conference name is required", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConferenceName.Focus();
                return;
            }

            // call assign input method

            AssignInputs();

            // instantiate object

            aConference = new Conference(conferenceName, numberOfAttendees, numberOfNights, accommodationChoice, internetYN, recCenterYN);

            // call the display charges method

            DisplayCharges();

            //disable controls

            txtConferenceName.Enabled = false;
            btnCreate.Enabled = false;
            btnModify.Enabled = true;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            // call the Assign Inputs method

            AssignInputs();

            aConference.AccommodationChoice = accommodationChoice;
            aConference.NumberOfAttendees = numberOfAttendees;
            aConference.NumberOfNights = numberOfNights;
            aConference.InternetAccess = internetYN;
            aConference.RecAccess = recCenterYN;

            // call the Display Charges method

            DisplayCharges();

            //disable controls

            btnCreate.Enabled = false;
        }

        private void AssignInputs()
        {
            // assign field inputs
            
            conferenceName = txtConferenceName.Text;
            numberOfAttendees = Convert.ToInt32(nudAttendees.Value);
            numberOfNights = Convert.ToInt32(nudNights.Value);

            accommodationChoice = (radiobuttonSingle.Checked) ? AccommodationType.Single : (radiobuttonDouble.Checked) ? AccommodationType.Double : AccommodationType.Suite;

            internetYN = (chkboxInternet.Checked) ? true : false;
            recCenterYN = (chkboxRec.Checked) ? true : false;
        }

        private void DisplayCharges()
        {
            // display message 

            string strCharges = $"Accommodation Charge: {aConference.AccommodationCharge.ToString("C")} \nOptional Services Charge: {aConference.OptionalServices.ToString("C")} \nDiscount: -{aConference.Discount.ToString("C")} \nTotal Charges: {aConference.TotalCharge.ToString("C")}";

            //display result

            lblCharges.Text = strCharges;
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            //reset values 

            txtConferenceName.Clear();
            nudAttendees.Value = nudAttendees.Minimum;
            nudNights.Value = nudNights.Minimum;
            chkboxInternet.Checked = false;
            chkboxRec.Checked = false;
            radiobuttonSingle.Checked = true;
            lblCharges.Text = null;

            // enable controls
            btnCreate.Enabled = true;
            btnModify.Enabled = false;
            txtConferenceName.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // declare variable of type DialogResult

            DialogResult aResult;

            // display warning

            aResult = MessageBox.Show("Do You Wish To Exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            // if else for action taken

            if (aResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                txtConferenceName.Focus();
            }
        }
    }
}
