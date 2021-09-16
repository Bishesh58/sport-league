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
        private CurrencyManager cmEntry;
        public ChallengeForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            mf = mnu;
            BindControls();
        }
        //bind controls
        public void BindControls()
        {
            txtChallengeID.DataBindings.Add("Text", DM.DSnzesl, "Challenge.ChallengeID");
            txtChallengeName.DataBindings.Add("Text", DM.DSnzesl, "Challenge.ChallengeName");
            cboEventID.DataBindings.Add("Text", DM.DSnzesl, "Challenge.EventID");
            //cboEventName.DataBindings.Add("Text", DM.DSnzesl, "Event.EventName");
            
            txtStartTime.DataBindings.Add("Text", DM.DSnzesl, "Challenge.StartTime");
            cboStatus.DataBindings.Add("Text", DM.DSnzesl, "Challenge.Status");
            txtCapacity.DataBindings.Add("Text", DM.DSnzesl, "Challenge.Capacity");

            //fill Event ID 
            cboEventID.DataSource = DM.DSnzesl;
            cboEventID.DisplayMember = "Event.EventID";
            cboEventID.ValueMember = "Event.EventID";

            cboEventName.DataSource = DM.DSnzesl;
            cboEventName.DisplayMember = "Event.EventName";
            cboEventName.ValueMember = "Event.EventID";

            //fill newEvent ID 
            cboNewEventID.DataSource = DM.DSnzesl;
            cboNewEventID.DisplayMember = "Event.EventID";
            cboNewEventID.ValueMember = "Event.EventID";
            //fill newEventName
            cboNewEventName.DataSource = DM.DSnzesl;
            cboNewEventName.DisplayMember = "Event.EventName";
            cboNewEventName.ValueMember = "Event.EventName";
            //fill list with data source
            lstChallenge.DataSource = DM.DSnzesl;
            lstChallenge.DisplayMember = "Challenge.ChallengeID";
            lstChallenge.ValueMember = "Challenge.ChallengeID";
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSnzesl, "Challenge"];
           

        }

        //form load
        private void ChallengeForm_Load(object sender, EventArgs e)
        {
            ReadWriteClass.SetReadonlyControls(grpChallenge.Controls);
        }


        //btn previous
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Navigate.prev(currencyManager);
        }

        //btn next
        private void btnNext_Click(object sender, EventArgs e)
        {
            Navigate.next(currencyManager);
        }
       
        //btn add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Navigate.addBtn(pnlList, pnlAddChallenge, grpChallenge, btnUpdate, btnDelete, btnSaveChanges, btnCancelUpdate);
           
            btnComplete.Enabled = false;
            btnFinished.Enabled = false;
             
        }

        //btn update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Navigate.updateBtn(pnlList, btnAdd, btnDelete, btnSaveChanges, btnCancelUpdate);
            ReadWriteClass.SetEditControls(grpChallenge.Controls);

            btnComplete.Enabled = false;
            btnFinished.Enabled = false;
            
            txtChallengeID.Visible = true; 
            txtChallengeID.Enabled = false;
            cboEventID.Enabled = false;
            lblChallengeID.Visible = true;
            cboEventName.Enabled = false;
            cboStatus.Enabled = false;

        }

        //btn delete
        private void btnDelete_Click(object sender, EventArgs e)
        {

            DataRow deleteChallengeRow = DM.dtChallenge.Rows[currencyManager.Position];
            DataRow[] entryRow = DM.dtEntry.Select("ChallengeID = " + txtChallengeID.Text);

            if (entryRow.Length != 0)
            {
                MessageBox.Show("You may only delete Challenge that have no entries", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
               MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteChallengeRow.Delete();
                    DM.updateChallenge();
                    MessageBox.Show("Challenge deleted Successfully");
                }
            }
        }

        //btn 'Save challenge' to save new data
        private void btnSaveChallenge_Click(object sender, EventArgs e)
        {
            Navigate.btnSave(pnlList, pnlAddChallenge, grpChallenge, btnUpdate, btnDelete, btnSaveChanges, btnCancelUpdate);
            handleAddData();
        }

        //btn 'save changes' to update
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            Navigate.btnSaveChanges(pnlList, pnlAddChallenge, grpChallenge, btnAdd, btnUpdate, btnDelete, btnSaveChanges, btnCancelUpdate);

            handleUpdateData();

            //make controls readonly
            ReadWriteClass.SetReadonlyControls(grpChallenge.Controls);
        }

        //method handleAddData
        private void handleAddData()
        {
            DataRow newChallengeRow = DM.dtChallenge.NewRow();
            try
            {
                if ((txtNewChallengeName.Text == "") || cboNewStatus.Text == "")
                {
                    MessageBox.Show("You must type in a all fields", "Error");
                    currencyManager.CancelCurrentEdit();
                }
                else if (Int32.TryParse(txtNewChallengeName.Text, out int val1))
                {
                    MessageBox.Show("Numeric value is not allowed on UserName");
                    currencyManager.CancelCurrentEdit();
                }
                else if (!(txtNewCapacity.Value > 1 && txtNewCapacity.Value < 40))
                {
                    MessageBox.Show("Please enter value between 1 to 40");
                }
                
                else
                {
                    newChallengeRow["ChallengeName"] = txtNewChallengeName.Text;
                    newChallengeRow["EventID"] = DM.dtEvent.Rows[cboNewEventID.SelectedIndex]["EventID"];
                    newChallengeRow["StartTime"] = txtNewStartTime.Text;
                    newChallengeRow["Status"] = cboNewStatus.Text;
                    newChallengeRow["Capacity"] = Convert.ToDouble(txtNewCapacity.Text);

                    DM.dtChallenge.Rows.Add(newChallengeRow);
                    MessageBox.Show("Arena added successfully", "Success");
                    DM.updateChallenge();
                    ReadWriteClass.SetReadonlyControls(grpChallenge.Controls);
                    clearField();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                currencyManager.CancelCurrentEdit();
            }
        }

        //method handle updateData
        private void handleUpdateData()
        {
            DataRow updateChallengeRow = DM.dtChallenge.Rows[currencyManager.Position];
            try
            {
                if ((txtChallengeName.Text == "") || (cboEventID.Text == "") || (cboEventName.Text == "") ||
                    (txtStartTime.Text == "") || (txtCapacity.Text == ""))
                {
                    currencyManager.CancelCurrentEdit();
                    MessageBox.Show("You must type in a all fields", "Error");
                }
                else if (Int32.TryParse(txtChallengeName.Text, out int val1))
                {
                    MessageBox.Show("Numeric value is not allowed on Challenge Name");
                    currencyManager.CancelCurrentEdit();
                }
                else if (!(txtCapacity.Value > 1 && txtNewCapacity.Value < 40))
                {
                    MessageBox.Show("Please enter value between 1 to 40");
                }
                else
                {
                    updateChallengeRow["ChallengeName"] = txtChallengeName.Text;
                    updateChallengeRow["StartTime"] = txtStartTime.Text;
                    updateChallengeRow["Capacity"] = Convert.ToDouble(txtNewCapacity.Text);
                   
                    DM.updateChallenge();
                    MessageBox.Show("Challenge updated successfully", "Success");
                    ReadWriteClass.SetReadonlyControls(grpChallenge.Controls);
                    clearField();
                }
            }
            catch (Exception ex)
            {
                currencyManager.CancelCurrentEdit();
                MessageBox.Show(ex.Message);
            }
        }

        //btnCancel add
        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            Navigate.btnCancelAdd(pnlList, pnlAddChallenge, grpChallenge, btnUpdate, btnDelete);
            currencyManager.CancelCurrentEdit();
            btnComplete.Enabled = true;
            btnFinished.Enabled = true;
            clearField();
        }

        //btnCancel update
        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            Navigate.btnCancelUpdate(pnlList, btnAdd, btnDelete, btnSaveChanges, btnCancelUpdate);
            ReadWriteClass.SetReadonlyControls(grpChallenge.Controls);
            currencyManager.CancelCurrentEdit();
            btnComplete.Enabled = true;
            btnFinished.Enabled = true;
          
        }

        //btn complete
        private void btnComplete_Click(object sender, EventArgs e)
        {
            DataRow challengeRowToComplete = DM.dtChallenge.Rows[currencyManager.Position];
            string arenaStatus = challengeRowToComplete["Status"].ToString();

            //cmEntry.Position = DM.EntryView.Find(aChallengeID);
           //DataRow drEntry = DM.dtEntry.Rows[cmEntry.Position];

            if (arenaStatus.Equals("Finished") == true)
            {
                challengeRowToComplete["Status"] = "Completed";
                DM.updateChallenge();

                cmEntry = (CurrencyManager)this.BindingContext[DM.DSnzesl, "Entry"];
                int aChallengeID = Convert.ToInt32(challengeRowToComplete["ChallengeID"].ToString());
                cmEntry.Position = DM.EntryView.Find(aChallengeID);
                DataRow drEnt = DM.dtEntry.Rows[cmEntry.Position];

                DataRow[] drEntries = challengeRowToComplete.GetChildRows(DM.dtChallenge.ChildRelations["FK_CHALLENGE_ENTRY"]);
                if(drEntries.Length > 0)
                {
                    foreach (DataRow drE in drEntries)
                    {
                        drE.Delete();
                    }
                }
                
                DM.updateEntry();
                MessageBox.Show("Challenge marked as Completed");
            }
            else
            {
                MessageBox.Show("Only finished challenges can be marked as completed");
            }
        }
        //btn finished
        private void btnFinished_Click(object sender, EventArgs e)
        {
            DataRow challengeRowToFinish = DM.dtChallenge.Rows[currencyManager.Position];
            string arenaStatus = challengeRowToFinish["Status"].ToString();
            if (arenaStatus.Equals("Scheduled") == true)
            {
                challengeRowToFinish["Status"] = "Finished";
                DM.updateChallenge();

                MessageBox.Show("Challenge marked as finished");
            }
            else
            {
                MessageBox.Show("Only scheduled challenges can be marked as Finished!");
            }
           
        }

        private void clearField()
        {
            txtNewChallengeName.Text = "";
            cboNewStatus.Text = "";
        }
       
    }
}
