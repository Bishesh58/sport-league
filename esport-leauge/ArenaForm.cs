using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
        //bind controls
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
        //form load
        private void ArenaForm_Load(object sender, EventArgs e)
        {
            ReadWriteClass.SetReadonlyControls(grpArena.Controls);
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
            Navigate.addBtn(pnlList, pnlAddArena, grpArena, btnUpdate, btnDelete, btnSaveChanges, btnCancelUpdate);
        }
        //btn update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Navigate.updateBtn(pnlList, btnAdd, btnDelete, btnSaveChanges, btnCancelUpdate);
            ReadWriteClass.SetEditControls(grpArena.Controls);
           
            txtArenaID.Enabled = false;
        }

        //btn delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteArenaRow = DM.dtArena.Rows[currencyManager.Position];
            DataRow[] eventRow = DM.dtEvent.Select("ArenaID = " + txtArenaID.Text);

            if (eventRow.Length != 0)
            {
                MessageBox.Show("You may only delete Arena that has no events", "Error");
            }
            else
            {
                
                
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
               MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    
                    deleteArenaRow.Delete();
                   
                    DM.updateArena();

                   
                    //cmEntry.Position = DM.EntryView.Find(aEntID);

                    MessageBox.Show("Arena deleted Successfully");
                }
            }

        }


        //btn 'Save Arena' to save new data
        private void btnSaveArena_Click(object sender, EventArgs e)
        {
            Navigate.btnSave(pnlList, pnlAddArena, grpArena, btnUpdate, btnDelete, btnSaveChanges, btnCancelUpdate);
            //regular expression for phone number 000-0000
            Regex exp = new Regex(@"\d{3}-\d{4}");

            if (exp.IsMatch(txtNewPhoneNumber.Text))
            {
                handleAddData();
            }
            else
            {
                MessageBox.Show("Invalid phone number, please enter like: 123-4567");
                currencyManager.CancelCurrentEdit();
            }
           
        }


        //btn 'save changes' to update
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            Navigate.btnSaveChanges(pnlList, pnlAddArena, grpArena, btnAdd, btnUpdate, btnDelete, btnSaveChanges, btnCancelUpdate);

            Regex exp = new Regex(@"\d{3}-\d{4}");

            if (exp.IsMatch(txtPhoneNumber.Text))
            {
                handleUpdateData();
            }
            else
            {
                MessageBox.Show("Invalid phone number, please enter like: 123-4567");
                currencyManager.CancelCurrentEdit();
            }
            

            //make controls readonly
            ReadWriteClass.SetReadonlyControls(grpArena.Controls);
        }

        //method handleAddData
        public void handleAddData()
        {
            DataRow newArenaRow = DM.dtArena.NewRow();
            try
            {
                if ((txtNewArenaName.Text == "") || (txtNewStreetAddress.Text == "") || (txtNewSuburb.Text == "") ||
                               (cboNewTxtCity.Text == "") || (txtNewPhoneNumber.Text == ""))
                {
                    MessageBox.Show("You must type in all fields", "Error");
                    currencyManager.CancelCurrentEdit();
                }
                else if (Int32.TryParse(txtNewArenaName.Text, out int val1))
                {
                    MessageBox.Show("Numeric value is not allowed on Arena Name");
                    currencyManager.CancelCurrentEdit();
                }
                else if (Int32.TryParse(txtNewStreetAddress.Text, out int val2))
                {
                    MessageBox.Show("Numeric value is not allowed on Street Address");
                    currencyManager.CancelCurrentEdit();
                }
                else if (Int32.TryParse(txtNewSuburb.Text, out int val3))
                {
                    MessageBox.Show("Numeric value is not allowed on Suburb");
                    currencyManager.CancelCurrentEdit();
                }
                else if (Int32.TryParse(cboNewTxtCity.Text, out int val4))
                {
                    MessageBox.Show("Numeric value is not allowed on City");
                    currencyManager.CancelCurrentEdit();
                }
                
                else
                {
                    newArenaRow["ArenaName"] = txtNewArenaName.Text;
                    newArenaRow["StreetAddress"] = txtNewStreetAddress.Text;
                    newArenaRow["Suburb"] = txtNewSuburb.Text;
                    newArenaRow["City"] = cboNewTxtCity.Text;
                    newArenaRow["PhoneNumber"] = txtNewPhoneNumber.Text;
                    DM.dtArena.Rows.Add(newArenaRow);
                    MessageBox.Show("Arena added successfully", "Success");
                    DM.updateArena();
                    ReadWriteClass.SetReadonlyControls(grpArena.Controls);
                    clearField();
                }
            }
            catch (Exception ex)
            {
                currencyManager.CancelCurrentEdit();
                MessageBox.Show(ex.Message);
            }

       
        }

        //method handle updateData
        public void handleUpdateData()
        {
            DataRow updateArenaRow = DM.dtArena.Rows[currencyManager.Position];

            try
            {
                if ((txtArenaName.Text == "") || (txtStreetAddress.Text == "") || (txtSuburb.Text == "") ||
                               (cboTxtCity.Text == "") || (txtPhoneNumber.Text == ""))
                {
                    MessageBox.Show("You must enter a value for each of the text fields", "Error");
                    currencyManager.CancelCurrentEdit();
                }
                else if (Int32.TryParse(txtArenaName.Text, out int val1))
                {
                    MessageBox.Show("Numeric value is not allowed on Arena Name");
                    currencyManager.CancelCurrentEdit();
                }
                else if (Int32.TryParse(txtStreetAddress.Text, out int val2))
                {
                    MessageBox.Show("Numeric value is not allowed on Street Address");
                    currencyManager.CancelCurrentEdit();
                }
                else if (Int32.TryParse(txtSuburb.Text, out int val3))
                {
                    MessageBox.Show("Numeric value is not allowed on Suburb");
                    currencyManager.CancelCurrentEdit();
                }
                else if (Int32.TryParse(cboTxtCity.Text, out int val4))
                {
                    MessageBox.Show("Numeric value is not allowed on City");
                    currencyManager.CancelCurrentEdit();
                }
            
                else
                {
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
                currencyManager.CancelCurrentEdit();
                MessageBox.Show(ex.Message);
            }
        }

        //btnCancel add
        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            Navigate.btnCancelAdd(pnlList, pnlAddArena, grpArena, btnUpdate, btnDelete);
            currencyManager.CancelCurrentEdit();
            txtArenaID.Visible = true;
            clearField();
        }

        //btnCancel update
        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            Navigate.btnCancelUpdate(pnlList, btnAdd, btnDelete, btnSaveChanges, btnCancelUpdate);
            ReadWriteClass.SetReadonlyControls(grpArena.Controls);
            currencyManager.CancelCurrentEdit();
            txtArenaID.Visible = true;
        }
        //tooltip 1
        private void txtPhoneNumber_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtPhoneNumber, "Enter number on 000-0000 format");
        }
        //tooltip 2
        private void txtNewPhoneNumber_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(txtNewPhoneNumber, "Enter number on 000-0000 format");
        }
        //
        private string txtChangeValue;
        private void txtArenaName_TextChanged(object sender, EventArgs e)
        {
            txtChangeValue = txtArenaName.Text;
        }

        private void clearField()
        {
            txtNewArenaName.Text = "";
            txtNewStreetAddress.Text = "";
            txtNewSuburb.Text = "";
            cboNewTxtCity.Text = "";
            txtNewPhoneNumber.Text = "";
        }

       
    }
}
