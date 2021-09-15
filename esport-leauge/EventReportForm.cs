using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace esport_leauge
{
    public partial class EventReportForm : Form
    {
        private DataModule DM;
        private MainForm mf;
       

        public EventReportForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            mf = mnu;
        }


        private void btnDisplayReport_Click(object sender, EventArgs e)
        {
            CurrencyManager cmArena;
            CurrencyManager cmEvent;
            CurrencyManager cmChallenge;
            CurrencyManager cmCompetitor;
            CurrencyManager cmEntry;

            string eventDetails = "";

            cmArena = (CurrencyManager)this.BindingContext[DM.DSnzesl, "Arena"];
            cmEvent = (CurrencyManager)this.BindingContext[DM.DSnzesl, "Event"];
            cmChallenge = (CurrencyManager)this.BindingContext[DM.DSnzesl, "Challenge"];
          

            foreach(DataRow drEvent in DM.dtEvent.Rows)
            {
                //get arena for event 
                int aID = Convert.ToInt32(drEvent["ArenaID"].ToString());
                cmArena.Position = DM.ArenaView.Find(aID);
                DataRow drArena = DM.dtArena.Rows[cmArena.Position];
                //output event details
                eventDetails += "Event ID: " + drEvent["EventID"] + "\r\n\r\n";
                eventDetails += drEvent["EventName"] + "\r\n";
                eventDetails += drArena["ArenaName"] + "\r\n";
                eventDetails += drArena["StreetAddress"] + "\r\n";
                eventDetails += drArena["Suburb"] + "\r\n";
                eventDetails += drArena["City"] + "\r\n\r\n";
                eventDetails += "Event Date: " + drEvent["EventDate"] + "\r\n\r\n";
                
                eventDetails +="Challenges:" + "\r\n\r\n";
               
                

                //get challenges
                int aChallengeID = Convert.ToInt32(drEvent["EventID"].ToString());
                cmChallenge.Position = DM.ChallengeView.Find(aChallengeID);
                DataRow drChallenge = DM.dtChallenge.Rows[cmChallenge.Position];
                
                DataRow[] drChallenges = drEvent.GetChildRows(DM.dtEvent.ChildRelations["FK_EVENT_CHALLENGE"]);
               
                
                if(drChallenges.Length > 0)
                {
                    eventDetails += "ID\t\t" + "Name\t\t\t" + "Time\t\t\r\n";
                    foreach (DataRow drEventChallenge in drChallenges)
                    {
                        int chID = Convert.ToInt32(drEventChallenge["ChallengeID"].ToString());
                        cmChallenge.Position = DM.ChallengeView.Find(chID);
                        DataRow drchallenge = DM.dtChallenge.Rows[cmChallenge.Position];

                        eventDetails += "" + drchallenge["ChallengeID"] + "\t\t" + drchallenge["ChallengeName"] + "\t\t" + drchallenge["StartTime"] + "\r\n";
                       
                    }
                   eventDetails += "\r\n\r\n\r\n";
                   eventDetails += "\r\n\r\n\r\n";
                   eventDetails += "\r\n\r\n\r\n";
                }
            }
            txtReport.Text += eventDetails;
            txtReport.Text += "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";


        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtReport.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
        }
    }
}
