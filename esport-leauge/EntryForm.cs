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
    public partial class EntryForm : Form
    {
        private DataModule DM;
        private MainForm mf;
        private CurrencyManager cmChallenge;
        private CurrencyManager cmCompetitor;
        private CurrencyManager cmEvent;
        private CurrencyManager cmEntry;
        private CurrencyManager cmEntryChallenge;
        private DataTable dt = new DataTable();
        private CurrencyManager cmDt;
        public EntryForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            mf = mnu;
            cmChallenge = (CurrencyManager)this.BindingContext[DM.DSnzesl, "Challenge"];
            cmCompetitor = (CurrencyManager)this.BindingContext[DM.DSnzesl, "Competitor"];
            cmEvent = (CurrencyManager)this.BindingContext[DM.DSnzesl, "Event"];
            cmEntry = (CurrencyManager)this.BindingContext[DM.DSnzesl, "Entry"];
            cmDt = (CurrencyManager)this.BindingContext[dt];
            cmEntryChallenge = (CurrencyManager)this.BindingContext[DM.DSnzesl, "Challenge.FK_CHALLENGE_ENTRY"];
            BindControls();
        }

        public void BindControls()
        {
            dgvCompetitor.DataSource = DM.DSnzesl;
            dgvCompetitor.DataMember = "Competitor";

            dgvChallenge.DataSource = DM.DSnzesl;
            dgvChallenge.DataMember = "Challenge";

            dgvEntry.DataSource = DM.DSnzesl;
            dgvEntry.DataMember = "Entry";
        }

        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            try
            {
                if(DM.dtChallenge.Rows[cmChallenge.Position]["Status"].ToString()== "Scheduled")
                {
                    DataRow newEntry = DM.dtEntry.NewRow();
                    newEntry["CompetitorID"] = dgvCompetitor["CompetitorID", cmCompetitor.Position].Value;
                    newEntry["ChallengeID"] = dgvChallenge["ChallengeID", cmChallenge.Position].Value;
                    newEntry["Status"] = cboTxtStatus.Text;

                    DM.DSnzesl.Tables["Entry"].Rows.Add(newEntry);
                    DM.updateEntry();
                }
                else
                {
                    MessageBox.Show("Competitors can only be entered to scheduled challenges", "Error");
                }
            }
            catch (ConstraintException)
            {

                MessageBox.Show("This entry has already been allocated", "Error");
            }
        }

        private void btnRemoveEntry_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow deleteEntryRow = DM.dtEntry.Rows[cmEntry.Position];
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteEntryRow.Delete();
                    DM.updateEntry();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Can not delete Entry", "Error");
            }
        }

        private void dgvChallenge_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvChallenge.CurrentRow.Selected = true;
            // txtEventName.Text = dgvChallenge.Rows[e.RowIndex].Cells["ChallengeID"].Value.ToString();
            try
            {
                txtEventName.Text = DM.dtEvent.Rows[cmChallenge.Position]["EventName"].ToString();

                cboTxtStatus.Text = DM.dtChallenge.Rows[cmChallenge.Position]["Status"].ToString();
                cboTxtStatus.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvCompetitor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCompetitor.CurrentRow.Selected = true;
            cboTxtStatus.Enabled = true;
        }

        private void dgvEntry_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEntry.CurrentRow.Selected = true;
        }

       
    }
}
