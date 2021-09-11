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
    public partial class CompetitorReportForm : Form
    {
        private DataModule DM;
        private MainForm mf;
        public CompetitorReportForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            mf = mnu;
        }

        private void btnDisplayCompetitor_Click(object sender, EventArgs e)
        {
            CurrencyManager cmArena;
            CurrencyManager cmEvent;
            CurrencyManager cmChallenge;
            CurrencyManager cmCompetitor;
            CurrencyManager cmEntry;

            string competitorDetails = "";

            cmArena = (CurrencyManager)this.BindingContext[DM.DSnzesl, "Arena"];
            cmEvent = (CurrencyManager)this.BindingContext[DM.DSnzesl, "Event"];
            cmChallenge = (CurrencyManager)this.BindingContext[DM.DSnzesl, "Challenge"];
            cmCompetitor = (CurrencyManager)this.BindingContext[DM.DSnzesl, "Competitor"];
            cmEntry = (CurrencyManager)this.BindingContext[DM.DSnzesl, "Entry"];

            //loop for each competitor in the competitor table
            foreach (DataRow drCompetitor in DM.dtCompetitor.Rows)
            {
                //get entries for competitor 
                int aEntID = Convert.ToInt32(drCompetitor["CompetitorID"].ToString());
                cmEntry.Position = DM.EntryView.Find(aEntID);
                DataRow drEntry = DM.dtEntry.Rows[cmEntry.Position];

                DataRow[] drEntries = drCompetitor.GetChildRows(DM.dtCompetitor.ChildRelations["FK_COMPETITOR_ENTRY"]);

                //if competitor has entries
                if (drEntries.Length > 0)
                {
                    //output competitor details
                    competitorDetails += "Competitor ID: " + drCompetitor["CompetitorID"] + "\r\n\r\n";
                    competitorDetails += "Username: \t" + drCompetitor["UserName"] + "\r\n";
                    competitorDetails += "Name: \t\t" + drCompetitor["FirstName"] + "\r\n";
                    competitorDetails += "Gender: \t\t" + drCompetitor["Gender"] + "\r\n";
                    competitorDetails += "Date Of Birth: \t" + drCompetitor["DateOfBirth"] + "\r\n";
                    competitorDetails += "Email: \t\t" + drCompetitor["EmailAddress"] + "\r\n\r\n";

                    competitorDetails += "Entries:" + "\r\n\r\n";

                    competitorDetails += "Challenge ID\t" + "Challenge Name\t\t" + "Start Time\t\t\r\n\r\n";

                    //loop for each entry associate with competitor id in entry table

                    foreach (DataRow drCompEntries in drEntries)
                    {
                        int chID = Convert.ToInt32(drCompEntries["ChallengeID"].ToString());
                        cmEntry.Position = DM.EntryView.Find(chID);
                        DataRow drEnt = DM.dtChallenge.Rows[cmEntry.Position];

                        competitorDetails += "" + drEnt["ChallengeID"] + "\t\t" + drEnt["ChallengeName"] + "\t\t\t" + drEnt["StartTime"] + "\r\n\r\n\r\n";

                    }
                    txtReportComp.Text += competitorDetails;
                }

                txtReportComp.Text += "\r\n\r\n\r\n\r\n";
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog2.ShowDialog() == DialogResult.OK)
            {
                printDocument2.Print();
            }
        }
        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtReportComp.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
        }
     

     
    }
}
