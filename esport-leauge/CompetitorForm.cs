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


        //bind controls
        public void BindControls()
        {
            txtCompetitorID.DataBindings.Add("Text", DM.DSnzesl, "Competitor.CompetitorID");
            txtUserName.DataBindings.Add("Text", DM.DSnzesl, "Competitor.UserName");
            txtFirstName.DataBindings.Add("Text", DM.DSnzesl, "Competitor.FirstName");
            txtLastName.DataBindings.Add("Text", DM.DSnzesl, "Competitor.LastName");
            cboTextGender.DataBindings.Add("Text", DM.DSnzesl, "Competitor.Gender");//for updating current gender
            txtDateOfBirth.DataBindings.Add("Text", DM.DSnzesl, "Competitor.DateOfBirth");
            txtEmail.DataBindings.Add("Text", DM.DSnzesl, "Competitor.EmailAddress");
            cboNewTextGender.DataBindings.Add("Text", DM.DSnzesl, "Competitor.Gender");//for adding new gender
            //fill list with data source
            lstCompetitor.DataSource = DM.DSnzesl;
            lstCompetitor.DisplayMember = "Competitor.UserName";
            lstCompetitor.ValueMember = "Competitor.UserName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSnzesl, "Competitor"];
        }

        //form load
        private void CompetitorForm_Load(object sender, EventArgs e)
        {
            ReadWriteClass.SetReadonlyControls(grpCompetitor.Controls);
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
            Navigate.addBtn(pnlList, pnlAddCompetitor, grpCompetitor, btnUpdate, btnDelete, btnSaveChanges, btnCancelUpdate);
        }
        //btn update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Navigate.updateBtn(pnlList, btnAdd, btnDelete, btnSaveChanges, btnCancelUpdate);
            ReadWriteClass.SetEditControls(grpCompetitor.Controls);

            lblCompetitor.Visible = false; txtCompetitorID.Visible = false;
        }
        //btn delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteCompetitorRow = DM.dtCompetitor.Rows[currencyManager.Position];
            DataRow[] entryRow = DM.dtEntry.Select("CompetitorID = " + txtCompetitorID.Text);

            if (entryRow.Length != 0)
            {
                MessageBox.Show("You may only delete Competitor that have no entries", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
               MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteCompetitorRow.Delete();
                    DM.updateCompetitor();
                    MessageBox.Show("Competitor deleted Successfully");
                   
                }
            }
        }
        //btn 'Save Competitor' to save new data
        private void btnSaveCompetitor_Click(object sender, EventArgs e)
        {
            Navigate.btnSave(pnlList, pnlAddCompetitor, grpCompetitor, btnUpdate, btnDelete, btnSaveChanges, btnCancelUpdate);
            
            //this code is referended from :https://stackoverflow.com/questions/1558538/e-mail-validation-on-windows-form
            Regex exp = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            //check for email validity
            if (exp.IsMatch(txtNewEmail.Text))
            {
                handleAddData();
            }
            else
            {
                MessageBox.Show("Email is not on right format! Please enter valid email.");
                currencyManager.CancelCurrentEdit();
            }

        }

        //btn 'Save Changes' to update
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            Navigate.btnSaveChanges(pnlList, pnlAddCompetitor, grpCompetitor, btnAdd, btnUpdate, btnDelete, btnSaveChanges, btnCancelUpdate);
            //check for email validity
            Regex exp = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

            if (exp.IsMatch(txtEmail.Text))
            {
                handleUpdateData();
            }
            else
            {
                MessageBox.Show("Email is not on right format! Please enter valid email.");
                currencyManager.CancelCurrentEdit();
            }

            //make controls readonly
            ReadWriteClass.SetReadonlyControls(grpCompetitor.Controls);
        }

        //method handleAddData
        public void handleAddData()
        {
            DataRow newCompetitorRow = DM.dtCompetitor.NewRow();
            try
            {   
                if ((txtNewUserName.Text == "") || (txtNewFirstName.Text == "") || (txtNewLastName.Text == "") ||
                    (txtNewDateOfBirth.Text == "") || (txtNewEmail.Text == "") || (cboNewTextGender.Text == ""))
                {
                    MessageBox.Show("You must type in a all fields", "Error");
                }
                else if (Int32.TryParse(txtNewUserName.Text, out int val1))
                {
                    MessageBox.Show("Numeric value is not allowed on UserName");
                    currencyManager.CancelCurrentEdit();
                }
                else if (Int32.TryParse(txtNewFirstName.Text, out int val2))
                {
                    MessageBox.Show("Numeric value is not allowed on FirstName");
                    currencyManager.CancelCurrentEdit();
                }
                else if (Int32.TryParse(txtNewLastName.Text, out int val3))
                {
                    MessageBox.Show("Numeric value is not allowed on LastName");
                    currencyManager.CancelCurrentEdit();
                }
                else if (Int32.TryParse(txtNewDateOfBirth.Text, out int val4))
                {
                    MessageBox.Show("Numeric value is not allowed on Date Of Birth");
                    currencyManager.CancelCurrentEdit();
                }
                else if (Int32.TryParse(txtNewEmail.Text, out int val5))
                {
                    MessageBox.Show("Numeric value is not allowed on Email");
                    currencyManager.CancelCurrentEdit();
                }
                else if (Int32.TryParse(cboNewTextGender.Text, out int val6))
                {
                    MessageBox.Show("Numeric value is not allowed on Gender");
                    currencyManager.CancelCurrentEdit();
                }
                else
                {
                    newCompetitorRow["UserName"] = txtNewUserName.Text;
                    newCompetitorRow["FirstName"] = txtNewFirstName.Text;
                    newCompetitorRow["LastName"] = txtNewLastName.Text;
                    newCompetitorRow["Gender"] = cboNewTextGender.Text; 
                    newCompetitorRow["DateOfBirth"] = txtNewDateOfBirth.Text;
                    newCompetitorRow["EmailAddress"] = txtNewEmail.Text;

                    DM.dtCompetitor.Rows.Add(newCompetitorRow);
                    MessageBox.Show("Competitor added successfully", "Success");
                    DM.updateCompetitor();
                    ReadWriteClass.SetReadonlyControls(grpCompetitor.Controls);
                    clearField();
                }
            }
            catch (FormatException fex)
            {
                MessageBox.Show(fex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            
        }

        //method handleUpdateData
        public void handleUpdateData()
        {
            DataRow updateCompetitorRow = DM.dtCompetitor.Rows[currencyManager.Position];
            try
            {
                //need to work for radio button
                if ((txtUserName.Text == "") || (txtFirstName.Text == "") || (txtLastName.Text == "") ||
                    (txtDateOfBirth.Text == "") || (txtEmail.Text == ""))
                {
                    MessageBox.Show("You must type in a all fields", "Error");
                }
                else if (Int32.TryParse(txtUserName.Text, out int val1))
                {
                    MessageBox.Show("Numeric value is not allowed on UserName");
                    currencyManager.CancelCurrentEdit();
                }
                else if (Int32.TryParse(txtFirstName.Text, out int val2))
                {
                    MessageBox.Show("Numeric value is not allowed on FirstName");
                    currencyManager.CancelCurrentEdit();
                }
                else if (Int32.TryParse(txtLastName.Text, out int val3))
                {
                    MessageBox.Show("Numeric value is not allowed on LastName");
                    currencyManager.CancelCurrentEdit();
                }
                
                else if (Int32.TryParse(txtEmail.Text, out int val5))
                {
                    MessageBox.Show("Numeric value is not allowed on Email");
                    currencyManager.CancelCurrentEdit();
                }
                
                else
                {
                    updateCompetitorRow["UserName"] = txtUserName.Text;
                    updateCompetitorRow["FirstName"] = txtFirstName.Text;
                    updateCompetitorRow["LastName"] = txtLastName.Text;
                    updateCompetitorRow["Gender"] = cboTextGender.Text;
                    updateCompetitorRow["DateOfBirth"] = txtDateOfBirth.Text;
                    updateCompetitorRow["EmailAddress"] = txtEmail.Text;
                    
                    DM.updateCompetitor();
                    MessageBox.Show("Competitors updated successfully", "Success");
                    ReadWriteClass.SetReadonlyControls(grpCompetitor.Controls);
                    clearField();
                }
            }
            catch (Exception ex)
            {
                currencyManager.CancelCurrentEdit();
                MessageBox.Show(ex.Message);
            }
            
        }

        //btn Cancel add
        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            Navigate.btnCancelAdd(pnlList, pnlAddCompetitor, grpCompetitor, btnUpdate, btnDelete);
            currencyManager.CancelCurrentEdit();
            clearField();
        }

        //btn Cancel update
        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            Navigate.btnCancelUpdate(pnlList, btnAdd, btnDelete, btnSaveChanges, btnCancelUpdate);
            ReadWriteClass.SetReadonlyControls(grpCompetitor.Controls);
            currencyManager.CancelCurrentEdit();
            lblCompetitor.Visible = true; txtCompetitorID.Visible = true;
        }

        private void clearField()
        {
             txtNewUserName.Text = "";
             txtNewFirstName.Text = "";
            txtNewLastName.Text = "";
            // ***need to work on gender***
             txtNewDateOfBirth.Text = "";
             txtNewEmail.Text = "";
            
        }

       
    }
}
