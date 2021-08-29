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
    public partial class ArenaForm : Form
    {
        private DataModule DM;
        private MainForm Mf;
        CurrencyManager currencyManager;
        public ArenaForm(DataModule dm, MainForm mn)
        {
            InitializeComponent();
            DM = dm;
            Mf = mn;
            BindControls();
        }
        public void BindControls()
        {
            txtArenaID.DataBindings.Add("Text", DM.DSnzesl, "Arena.ArenaID");
            txtArenaName.DataBindings.Add("Text", DM.DSnzesl, "Arena.ArenaName");
            txtStreetAddress.DataBindings.Add("Text", DM.DSnzesl, "Arena.StreetAddress");
            txtSuburb.DataBindings.Add("Text", DM.DSnzesl, "Arena.Suburb");
            cboTxtCity.DataBindings.Add("Text", DM.DSnzesl, "Arena.City");
            txtPhoneNumber.DataBindings.Add("Text", DM.DSnzesl, "Arena.PhoneNumber");
            //fill list with data source
            lstArena.DataSource = DM.DSnzesl;
            lstArena.DisplayMember = "Arena.ArenaName";
            lstArena.ValueMember = "Arena.ArenaName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSnzesl, "Arena"];

        }


        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Navigate.prev(currencyManager);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Navigate.next(currencyManager);
        }

        private bool isAdding = false;
        private bool isUpdating = false;
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
            ReadWriteClass.SetReadonlyControls(grpArena.Controls);

        }
        public void handleAddData()
        {
            try
            {
                if ((txtArenaName.Text == "") || (txtStreetAddress.Text == "") || (txtSuburb.Text == "") ||
                               (cboTxtCity.Text == "") || (txtPhoneNumber.Text == ""))
                {
                    MessageBox.Show("You must type in a all fields", "Error");
                    currencyManager.CancelCurrentEdit();
                }
                else
                {
                    DataRow newArenaRow = DM.dtArena.NewRow();
                    newArenaRow["ArenaName"] = txtArenaName.Text;
                    newArenaRow["StreetAddress"] = txtStreetAddress.Text;
                    newArenaRow["Suburb"] = txtSuburb.Text;
                    newArenaRow["City"] = cboTxtCity.Text;
                    newArenaRow["PhoneNumber"] = txtPhoneNumber.Text;

                    DM.dtArena.Rows.Add(newArenaRow);
                    MessageBox.Show("Arena added successfully", "Success");
                    DM.updateArena();
                    ReadWriteClass.SetReadonlyControls(grpArena.Controls);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }


        public void handleUpdateData()
        {
      
            try
            {
                if ((txtArenaName.Text == "") || (txtStreetAddress.Text == "") || (txtSuburb.Text == "") ||
                               (cboTxtCity.Text == "") || (txtPhoneNumber.Text == ""))
                {
                    MessageBox.Show("You must enter a value for each of the text fields", "Error");
                    currencyManager.CancelCurrentEdit();
                }
                else
                {
                   
                    DataRow updateArenaRow = DM.dtArena.Rows[currencyManager.Position];
                    updateArenaRow["ArenaName"] = txtArenaName.Text;
                    updateArenaRow["StreetAddress"] = txtStreetAddress.Text;
                    updateArenaRow["Suburb"] = txtSuburb.Text;
                    updateArenaRow["City"] = cboTxtCity.Text;
                    updateArenaRow["PhoneNumber"] = txtPhoneNumber.Text;

                    currencyManager.EndCurrentEdit();
                    DM.updateArena();
                    MessageBox.Show("Arena updated successfully", "Success");
                    ReadWriteClass.SetReadonlyControls(grpArena.Controls);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Navigate.cancelBtn(pnlList, btnAdd, btnUpdate, btnDelete, btnSave, btnCancel);
            ReadWriteClass.SetReadonlyControls(grpArena.Controls);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Navigate.addBtn(pnlList, btnUpdate, btnDelete, btnSave, btnCancel);
            ReadWriteClass.SetEditControls(grpArena.Controls);
            isAdding = true;
            isUpdating = false;
            btnSave.Text = "Save";
            txtArenaID.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Navigate.updateBtn(pnlList, btnAdd, btnDelete, btnSave, btnCancel);
            ReadWriteClass.SetEditControls(grpArena.Controls);
            isUpdating = true;
            isAdding = false;
            btnSave.Text = "Save Change";
            txtArenaID.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteArenaRow = DM.dtArena.Rows[currencyManager.Position];
            DataRow[] eventRow = DM.dtEvent.Select("ArenaID = " + txtArenaID.Text);

            if (eventRow.Length != 0)
            {
                MessageBox.Show("You may only delete Arena that has events", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
               MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteArenaRow.Delete();
                    DM.updateArena();
                }
            }

        }

        private void ArenaForm_Load(object sender, EventArgs e)
        {
            ReadWriteClass.SetReadonlyControls(grpArena.Controls);
        }

        //handling phone number format & valid data
        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string s = txtPhoneNumber.Text;
                if (s.Length == 7)
                {
                    double sAsD = double.Parse(s);
                    txtPhoneNumber.Text = string.Format("{0:###-####}", sAsD).ToString();
                }
                if (txtPhoneNumber.Text.Length > 1)
                {
                    txtPhoneNumber.SelectionStart = txtPhoneNumber.Text.Length;
                    txtPhoneNumber.SelectionLength = 0;
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Maximum numbers reached, enter valid number");
            }
            catch (Exception)
            {

                MessageBox.Show("Please valid number only");
            }


        }

        private void txtPhoneNumber_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtPhoneNumber, "only numbers allowed");
        }



        /* //text num
        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        */
    }
}
