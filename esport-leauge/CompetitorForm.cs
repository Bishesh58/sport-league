using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esport_leauge
{
    public partial class CompetitorForm : Form
    {
        private DataModule DM;
        private MainForm mf;
        private CurrencyManager currencyManager;
        public CompetitorForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            mf = mnu;
            BindControls();
        }

        

        public void BindControls()
        {
            txtCompetitorID.DataBindings.Add("Text", DM.DSnzesl, "Competitor.CompetitorID");
            txtUserName.DataBindings.Add("Text", DM.DSnzesl, "Competitor.UserName");
            txtFirstName.DataBindings.Add("Text", DM.DSnzesl, "Competitor.FirstName");
            txtLastName.DataBindings.Add("Text", DM.DSnzesl, "Competitor.LastName");
            // radioButton.DataBindings.Add("Text", DM.DSnzesl, "Competitor.CompetitorID");
            txtDateOfBirth.DataBindings.Add("Text", DM.DSnzesl, "Competitor.DateOfBirth");
            txtEmail.DataBindings.Add("Text", DM.DSnzesl, "Competitor.EmailAddress");
            //fill list with data source
            lstCompetitor.DataSource = DM.DSnzesl;
            lstCompetitor.DisplayMember = "Competitor.UserName";
            lstCompetitor.ValueMember = "Competitor.UserName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSnzesl, "Competitor"];

        }



        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Navigate.prev(currencyManager);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Navigate.next(currencyManager);
        }
        //bool
        private bool isAdding;
        private bool isUpdating;
        private void btnSave_Click(object sender, EventArgs e)
        {
            Navigate.saveBtn(pnlList, btnAdd, btnUpdate, btnDelete, btnSave, btnCancel);
            lblCompetitor.Visible = true; txtCompetitorID.Visible = true;
            //save button to handle different methods
            if (isAdding == true)
            {
                handleAddData();
            }
            else
            {
                handleUpdateData();
            }
            //make controls readonly
            ReadWriteClass.SetReadonlyControls(grpCompetitor.Controls);


        }

        public void handleAddData()
        {
            txtCompetitorID.Text = null;
            DataRow newCompetitorRow = DM.dtCompetitor.NewRow();

            //need to work for radio button
            if ((txtUserName.Text == "") || (txtFirstName.Text == "") || (txtLastName.Text == "") ||
                (txtDateOfBirth.Text == "") || (txtEmail.Text == ""))
            {
                MessageBox.Show("You must type in a all fields", "Error");
            }
            else
            {
                newCompetitorRow["UserName"] = txtUserName.Text;
                newCompetitorRow["FirstName"] = txtFirstName.Text;
                newCompetitorRow["LastName"] = txtLastName.Text;
                // ***need to work on gender***
                //  newChallengeRow[""] = radio.Text; 
                newCompetitorRow["DateOfBirth"] = txtDateOfBirth.Text;
                newCompetitorRow["EmailAddress"] = txtEmail.Text;

                DM.dtCompetitor.Rows.Add(newCompetitorRow);
                MessageBox.Show("Competitor added successfully", "Success");
                DM.updateCompetitor();
            }
        }
        public void handleUpdateData()
        {
            txtCompetitorID.Text = null;
            DataRow updateCompetitorRow = DM.dtCompetitor.Rows[currencyManager.Position];

            //need to work for radio button
            if ((txtUserName.Text == "") || (txtFirstName.Text == "") || (txtLastName.Text == "") ||
                (txtDateOfBirth.Text == "") || (txtEmail.Text == ""))
            {
                MessageBox.Show("You must type in a all fields", "Error");
            }
            else
            {
                updateCompetitorRow["UserName"] = txtUserName.Text;
                updateCompetitorRow["FirstName"] = txtFirstName.Text;
                updateCompetitorRow["LastName"] = txtLastName.Text;
                // ***need to work on gender***
                //  newChallengeRow[""] = radio.Text; 
                updateCompetitorRow["DateOfBirth"] = txtDateOfBirth.Text;
                updateCompetitorRow["EmailAddress"] = txtEmail.Text;

                currencyManager.EndCurrentEdit();
                DM.updateCompetitor();
                MessageBox.Show("Competitors updated successfully", "Success");
                ReadWriteClass.SetReadonlyControls(grpCompetitor.Controls);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Navigate.cancelBtn(pnlList, btnAdd, btnUpdate, btnDelete, btnSave, btnCancel);
            ReadWriteClass.SetReadonlyControls(grpCompetitor.Controls);
            lblCompetitor.Visible = true; txtCompetitorID.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Navigate.addBtn(pnlList, btnUpdate, btnDelete, btnSave, btnCancel);
            ReadWriteClass.SetEditControls(grpCompetitor.Controls);
            isAdding = true;
            isUpdating = false;
            btnSave.Text = "Save Competitor";
            lblCompetitor.Visible = false; txtCompetitorID.Visible = false;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Navigate.updateBtn(pnlList, btnAdd, btnDelete, btnSave, btnCancel);
            ReadWriteClass.SetEditControls(grpCompetitor.Controls);
            isUpdating = true;
            isAdding = false;
            btnSave.Text = "Save Changes";
            lblCompetitor.Visible = false; txtCompetitorID.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void CompetitorForm_Load(object sender, EventArgs e)
        {
            ReadWriteClass.SetReadonlyControls(grpCompetitor.Controls);
        }
    }
}
