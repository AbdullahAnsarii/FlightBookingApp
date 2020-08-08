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
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            if (Form1.IDCard)
            {
                lbldocumentno.Text = "ID Card No.";
            }
            else
            {
                lbldocumentno.Text = "Passport No.";
            }

            fname.Text = Form1.firstName;
            lname.Text = Form1.lastName;
            goingto.Text = Form1.countryTo;
            goingfrom.Text = Form1.countryFrom;
            documentno.Text = Form1.documentNo;
            docissuedate.Text = Form1.docIssuedate;
            docexpirydate.Text = Form1.docExpirydate;
            tripstartdate.Text = Form1.tripStartdate;
            tripenddate.Text = Form1.tripEnddate;
            valuebaggage.Text = Form1.baggage;
            datetimereciept.Text = Form1.formattedDate;
            

        }
    }
}
