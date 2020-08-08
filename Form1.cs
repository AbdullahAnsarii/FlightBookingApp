using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flightBookingApp
{
    public partial class Form1 : Form
    {
        public static bool Passport, IDCard;
        public static string countryTo;
        public static string countryFrom;
        public static string firstName;
        public static string lastName;
        public static string documentNo;
        public static string tripStartdate;
        public static string tripEnddate;
        public static string docIssuedate;
        public static string docExpirydate;
        public static string baggage;
        public static string formattedDate;

        Display dis = new Display();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime myDate = DateTime.Now;
            formattedDate = string.Format("{0:dd/MM/yy HH:mm:ss:tt}", myDate);
            dateOpened.Text = formattedDate;
            
            
            calenderMonth.MaxSelectionCount = 100;
            calenderMonth.ShowToday = true;
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIdcard.Checked)
            {
                lblDocno.Text = "ID No.";
                lblDocissuedate.Text = "ID Card Issue Date.";
                lblDocexpirydate.Text = "ID Card Expiry Date";
                IDCard = true;
            }
        }

        private void datePick1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = datePick1.Value;
            datePick2.MinDate = dt;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            firstName = boxFirstname.Text;
            countryTo = boxTo.Text;
            countryFrom = boxFrom.Text;
            lastName = boxLastname.Text;
            documentNo = boxDocno.Text;
            docIssuedate = datePick1.Value.ToString("dd/MM/yy");
            docExpirydate = datePick2.Value.ToString("dd/MM/yy");
            tripStartdate = calenderMonth.SelectionStart.ToString("dd MMMM yyyy");
            tripEnddate = calenderMonth.SelectionEnd.ToString("dd MMMM yyyy");
            baggage = comboBox.Value.ToString();
            
            
            this.Hide();
            dis.Show();

        }
        private void comboBox_ValueChanged(object sender, EventArgs e)
        {
            //comboBox.Value=0;
            comboBox.Increment = 5;
        }

       

        private void rbPassport_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPassport.Checked)
            {
                lblDocno.Text = "Passport No.";
                lblDocissuedate.Text = "Passport Issue Date.";
                lblDocexpirydate.Text = "Passport Expiry Date";
                Passport = true;
            }
        }
    }
}
