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
    public partial class ChallengeForm : Form
    {
        private DataModule DM;
        private MainForm mf;
        private CurrencyManager currencyManager;
        public ChallengeForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            mf = mnu;
            BindControls();
        }
        
        public void BindControls()
        {
            txtChallengeID.DataBindings.Add("Text", DM.DSnzesl, "Challenge.ChallengeID");
            txtChallengeName.DataBindings.Add("Text", DM.DSnzesl, "Challenge.ChallengeName");
            cboEventID.DataBindings.Add("Text", DM.DSnzesl, "Event.EventID");
            cboEventName.DataBindings.Add("Text", DM.DSnzesl, "Event.EventName");
            txtStartTime.DataBindings.Add("Text", DM.DSnzesl, "Challenge.StartTime");
            cboStatus.DataBindings.Add("Text", DM.DSnzesl, "Challenge.Status");
            txtCapacity.DataBindings.Add("Text", DM.DSnzesl, "Challenge.Capacity");
            //fill list with data source
            lstChallenge.DataSource = DM.DSnzesl;
            lstChallenge.DisplayMember = "Challenge.ChallengeID";
            lstChallenge.ValueMember = "Challenge.ChallengeID";
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSnzesl, "Challenge"];

        }



        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Navigate.prev(currencyManager);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Navigate.next(currencyManager);
        }

        private bool isAdding;
        private bool isUpdating;
        private void btnSave_Click(object sender, EventArgs e)
        {
            Navigate.saveBtn(pnlList, btnAdd, btnUpdate, btnDelete, btnSave, btnCancel);
            btnComplete.Enabled = true;
            btnFinished.Enabled = true;
            txtChallengeID.Visible = true;
            lblChallengeID.Visible = true;
            lblEventID.Visible = true; cboEventID.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Navigate.cancelBtn(pnlList, btnAdd, btnUpdate, btnDelete, btnSave, btnCancel);
            ReadWriteClass.SetReadonlyControls(grpChallenge.Controls);
            btnComplete.Enabled = true;
            btnFinished.Enabled = true;
            txtChallengeID.Visible = true;
            lblChallengeID.Visible = true;
            lblEventID.Visible = true; cboEventID.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Navigate.addBtn(pnlList, btnUpdate, btnDelete, btnSave, btnCancel);
            ReadWriteClass.SetEditControls(grpChallenge.Controls);
            btnComplete.Enabled = false;
            btnFinished.Enabled = false;
            btnSave.Text = "Add Challenge";
            txtChallengeID.Visible = false;
            lblChallengeID.Visible = false;
            
            /* 
             txtChallengeID.Text = null;
             DataRow newChallengeRow = DM.dtChallenge.NewRow();
             if ((txtChallengeName.Text == "") || (cboEventID.Text == "") || (cboEventName.Text == "") ||
                 (txtStartTime.Text == "") || (txtCapacity.Text == ""))
             {
                 MessageBox.Show("You must type in a all fields", "Error");
             }
             else
             {
                 newChallengeRow["ChallengeName"] = txtChallengeName.Text;
                 newChallengeRow["EventID"] = cboEventID.Text;
               // ***this need to change***
               //  newChallengeRow["EventName"] = cboEventName.Text; 
                 newChallengeRow["StartTime"] = txtStartTime.Text;
                 newChallengeRow["Capacity"] = Convert.ToDouble(txtCapacity.Text);

                 DM.dtChallenge.Rows.Add(newChallengeRow);
                 MessageBox.Show("Arena added successfully", "Success");
                 DM.updateChallenge();
             }

             */
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Navigate.updateBtn(pnlList, btnAdd, btnDelete, btnSave, btnCancel);
            ReadWriteClass.SetEditControls(grpChallenge.Controls);
            isUpdating = true;
            isAdding = false;
            btnSave.Text = "Save Changes";
            btnComplete.Enabled = false;
            btnFinished.Enabled = false;
            txtChallengeID.Visible = true; txtChallengeID.Enabled = false;
            lblEventID.Visible = false; cboEventID.Visible = false; 
            lblChallengeID.Visible = true;
            cboEventName.Enabled = false;
            cboStatus.Enabled = false;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnComplete_Click(object sender, EventArgs e)
        {

        }

        private void btnFinished_Click(object sender, EventArgs e)
        {

        }

        private void ChallengeForm_Load(object sender, EventArgs e)
        {
            ReadWriteClass.SetReadonlyControls(grpChallenge.Controls);
        }
    }
}
