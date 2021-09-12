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
    public partial class EventForm : Form
    {
        private DataModule DM;
        private MainForm mf;
        private CurrencyManager currencyManager;
        public EventForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            mf = mnu;
            BindControls();
        }
        
        //bind controls
        public void BindControls()
        {
            txtEventID.DataBindings.Add("Text", DM.DSnzesl, "Event.EventID");
            txtEventName.DataBindings.Add("Text", DM.DSnzesl, "Event.EventName");
            txtEventDate.DataBindings.Add("Text", DM.DSnzesl, "Event.EventDate");
            cboArenaID.DataBindings.Add("Text", DM.DSnzesl, "Event.ArenaID");
            cboTxtStatus.DataBindings.Add("Text", DM.DSnzesl, "Event.Status");
            txtCapacity.DataBindings.Add("Text", DM.DSnzesl, "Event.Capacity");

            //fill Arena ID 
            cboArenaID.DataSource = DM.DSnzesl;
            cboArenaID.DisplayMember = "Arena.ArenaID";
            cboArenaID.ValueMember = "Arena.ArenaID";
            //fill ArenaName 
            cboArenaName.DataSource = DM.DSnzesl;
            cboArenaName.DisplayMember = "Arena.ArenaName";
            cboArenaName.ValueMember = "Arena.ArenaID";
            //fill newArena ID
            cboNewArenaID.DataSource = DM.DSnzesl;
            cboNewArenaID.DisplayMember = "Arena.ArenaID";
            cboNewArenaID.ValueMember = "Arena.ArenaID";
            //fill newArenaName
            cboNewArenaName.DataSource = DM.DSnzesl;
            cboNewArenaName.DisplayMember = "Arena.ArenaName";
            cboNewArenaName.ValueMember = "Arena.ArenaID";
            //fill list with data source
            lstEvent.DataSource = DM.DSnzesl;
            lstEvent.DisplayMember = "Event.EventName";
            lstEvent.ValueMember = "Event.EventName";

            currencyManager = (CurrencyManager)this.BindingContext[DM.DSnzesl, "Event"];
           
        }
        //form load
        private void EventForm_Load(object sender, EventArgs e)
        {
            ReadWriteClass.SetReadonlyControls(grpEvent.Controls);
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
            Navigate.addBtn(pnlList, pnlAddEvent, grpEvent, btnUpdate, btnDelete, btnSaveChanges, btnCancelUpdate);
        }

        //btn update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Navigate.updateBtn(pnlList, btnAdd, btnDelete, btnSaveChanges, btnCancelUpdate);
            ReadWriteClass.SetEditControls(grpEvent.Controls);
           
            txtEventID.Enabled = false;
            cboArenaID.Enabled = false;
            cboArenaName.Enabled = false;
        }

        //btn delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteEventRow = DM.dtEvent.Rows[currencyManager.Position];
            DataRow[] challengeRow = DM.dtChallenge.Select("EventID = " + txtEventID.Text);

            if (challengeRow.Length != 0)
            {
                MessageBox.Show("You may only delete Event that have no challenges", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
               MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteEventRow.Delete();
                    DM.updateEvent();
                    MessageBox.Show("Event deleted Successfully");
                }
            }
        }


        //btn 'save event' to save new data
        private void btnSaveEvent_Click(object sender, EventArgs e)
        {
            Navigate.btnSave(pnlList, pnlAddEvent, grpEvent, btnUpdate, btnDelete, btnSaveChanges, btnCancelUpdate);
            handleAddData();
        }

        //btn 'save changes' to update
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            Navigate.btnSaveChanges(pnlList, pnlAddEvent, grpEvent, btnAdd, btnUpdate, btnDelete, btnSaveChanges, btnCancelUpdate);
            
            handleUpdateData();

            //make controls readonly
            ReadWriteClass.SetReadonlyControls(grpEvent.Controls);
        }
        
        //method handleAddData
        public void handleAddData()
        {
            DataRow neEventRow = DM.dtEvent.NewRow();
            try
            {
                if ((txtNewEventName.Text == "") || (cboNewTxtStatus.Text == "") ||
               (txtNewCapacity.Text == "") || (txtNewEventDate.Text == ""))
                {
                    MessageBox.Show("You must type in all fields", "Error");
                    currencyManager.CancelCurrentEdit();
                }
                else if (Int32.TryParse(txtNewEventName.Text, out int val1))
                {
                    MessageBox.Show("Numeric value is not allowed on Event Name");
                    currencyManager.CancelCurrentEdit();

                }
                else if (Int32.TryParse(cboNewTxtStatus.Text, out int val2))
                {
                    MessageBox.Show("Numeric value is not allowed on status");
                    currencyManager.CancelCurrentEdit();
                }
                else if (!(txtNewCapacity.Value > 100 && txtNewCapacity.Value < 5000))
                {
                    MessageBox.Show("Please enter value between 100 to 5000");
                }
                else
                {
                    neEventRow["EventName"] = txtNewEventName.Text;
                    neEventRow["ArenaID"] = DM.dtArena.Rows[cboArenaID.SelectedIndex]["ArenaID"];
                    // neEventRow["ArenaName"] = DM.dtArena.Rows[cboArenaName.SelectedIndex]["ArenaName"];
                    neEventRow["Status"] = cboNewTxtStatus.Text;
                    neEventRow["Capacity"] = txtNewCapacity.Text;
                    neEventRow["EventDate"] = txtNewEventDate.Text;

                    DM.dtEvent.Rows.Add(neEventRow);
                    MessageBox.Show("Event added successfully", "Success");
                    DM.updateEvent();
                    ReadWriteClass.SetReadonlyControls(grpEvent.Controls);
                    clearField();
                }
            }
            catch (Exception ex)
            {

                currencyManager.CancelCurrentEdit();
                MessageBox.Show(ex.Message);
            }

           
           
        }

        //method handleUpdaeData
        public void handleUpdateData()
        {
            DataRow updateEventRow = DM.dtEvent.Rows[currencyManager.Position];
            try
            {
                if ((cboArenaID.Text == "") || (txtEventName.Text == "") || (cboArenaName.Text == "") ||
               (cboTxtStatus.Text == "") || (txtCapacity.Text == "") || (txtEventDate.Text == ""))
                {
                    currencyManager.CancelCurrentEdit();
                    MessageBox.Show("You must type in all fields", "Error");
                   
                }
                else if (Int32.TryParse(txtEventName.Text, out int val1))
                {
                    currencyManager.CancelCurrentEdit();
                    MessageBox.Show("Numeric value is not allowed on Event Name");
                }
                else if (Int32.TryParse(cboTxtStatus.Text, out int val2))
                {
                    currencyManager.CancelCurrentEdit();
                    MessageBox.Show("Numeric value is not allowed on status");
                }
                else if (!(txtCapacity.Value > 100 && txtNewCapacity.Value < 5000))
                {
                    currencyManager.CancelCurrentEdit();
                    MessageBox.Show("Please enter value between 100 to 5000");
                   
                }
                else
                {
                    updateEventRow["EventName"] = txtEventName.Text;
                    updateEventRow["Status"] = cboTxtStatus.Text;
                    updateEventRow["Capacity"] = txtCapacity.Text;
                    updateEventRow["EventDate"] = txtEventDate.Text;

                    currencyManager.EndCurrentEdit();
                    DM.updateEvent();
                    MessageBox.Show("Event updated successfully", "Success");
                    ReadWriteClass.SetReadonlyControls(grpEvent.Controls);
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
            Navigate.btnCancelAdd(pnlList, pnlAddEvent, grpEvent, btnUpdate, btnDelete);
            currencyManager.CancelCurrentEdit();
            txtEventID.Visible = true;
            lblEventID.Visible = true;
            clearField();


        }

        //btnCancel update
        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            Navigate.btnCancelUpdate(pnlList, btnAdd, btnDelete, btnSaveChanges, btnCancelUpdate);
            ReadWriteClass.SetReadonlyControls(grpEvent.Controls);
            currencyManager.CancelCurrentEdit();
            txtEventID.Visible = true;
            lblEventID.Visible = true;
          
        }

        private void clearField()
        {
            txtNewEventName.Text = "";
        }

    }
}
