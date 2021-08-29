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

        
        public void BindControls()
        {
            txtEventID.DataBindings.Add("Text", DM.DSnzesl, "Event.EventID");
            txtEventName.DataBindings.Add("Text", DM.DSnzesl, "Event.EventName");
            cboArenaID.DataBindings.Add("Text", DM.DSnzesl, "Arena.ArenaID");
            cboArenaName.DataBindings.Add("Text", DM.DSnzesl, "Arena.ArenaName");
            cboTxtStatus.DataBindings.Add("Text", DM.DSnzesl, "Event.Status");
            txtCapacity.DataBindings.Add("Text", DM.DSnzesl, "Event.Capacity");

            //fill list with data source
            lstEvent.DataSource = DM.DSnzesl;
            lstEvent.DisplayMember = "Event.EventName";
            lstEvent.ValueMember = "Event.EventName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSnzesl, "Event"];

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
            ReadWriteClass.SetReadonlyControls(grpEvent.Controls);
            txtEventID.Visible = false;
            lblEventID.Visible = false;

        }
        public void handleAddData()
        {
            DataRow neEventRow = DM.dtEvent.NewRow();
            if ((cboArenaID.Text == "") || (txtEventName.Text == "") || (cboArenaName.Text == "") ||
                (cboTxtStatus.Text == "") || (txtCapacity.Text == "") ||(txtEventDate.Text ==""))
            {
                MessageBox.Show("You must type in all fields", "Error");
            }
            else
            {
                neEventRow["EventName"] = txtEventName.Text;
                neEventRow["ArenaID"] = cboArenaID.Text;
             //   neEventRow["ArenaName"] = cboArenaName.Text;
                neEventRow["Status"] = cboTxtStatus.Text;
                neEventRow["Capacity"] = txtCapacity.Text;
                neEventRow["EventDate"] = txtEventDate.Text;

                DM.dtEvent.Rows.Add(neEventRow);
                MessageBox.Show("Event added successfully", "Success");
                DM.updateEvent();
                ReadWriteClass.SetReadonlyControls(grpEvent.Controls);
            }
        }

        public void handleUpdateData()
        {
            DataRow updateEventRow = DM.dtEvent.Rows[currencyManager.Position];
            if ((cboArenaID.Text == "") || (txtEventName.Text == "") || (cboArenaName.Text == "") ||
                (cboTxtStatus.Text == "") || (txtCapacity.Text == "") || (txtEventDate.Text == ""))
            {
                MessageBox.Show("You must type in all fields", "Error");
            }
            else
            {
                updateEventRow["EventName"] = txtEventName.Text;
                updateEventRow["ArenaID"] = cboArenaID.Text;
                updateEventRow["ArenaName"] = cboArenaName.Text;
                updateEventRow["Status"] = cboTxtStatus.Text;
                updateEventRow["Capacity"] = txtCapacity.Text;
                updateEventRow["EventDate"] = txtEventDate.Text;

                currencyManager.EndCurrentEdit();
                DM.updateEvent();
                MessageBox.Show("Event updated successfully", "Success");
                ReadWriteClass.SetReadonlyControls(grpEvent.Controls);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Navigate.cancelBtn(pnlList, btnAdd, btnUpdate, btnDelete, btnSave, btnCancel);
            ReadWriteClass.SetReadonlyControls(grpEvent.Controls);
            txtEventID.Visible = true;
            lblEventID.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Navigate.addBtn(pnlList, btnUpdate, btnDelete, btnSave, btnCancel);
            ReadWriteClass.SetEditControls(grpEvent.Controls);
            isAdding = true;
            isUpdating = false;
            btnSave.Text = "Save Meeting";
            txtEventID.Visible = false;
            lblEventID.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Navigate.updateBtn(pnlList, btnAdd, btnDelete, btnSave, btnCancel);
            ReadWriteClass.SetEditControls(grpEvent.Controls);
            isUpdating = true;
            isAdding = false;
            btnSave.Text = "Save Change";
            txtEventID.Enabled = false;
            cboArenaID.Enabled = false;
            cboArenaName.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteEventRow = DM.dtEvent.Rows[currencyManager.Position];
            DataRow[] arenaRow = DM.dtEvent.Select("EventID = " + txtEventID.Text);

            if (arenaRow.Length != 0)
            {
                MessageBox.Show("You may only delete Event that has arena", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
               MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteEventRow.Delete();
                    DM.updateEvent();
                }
            }
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            ReadWriteClass.SetReadonlyControls(grpEvent.Controls);
        }
    }
}
