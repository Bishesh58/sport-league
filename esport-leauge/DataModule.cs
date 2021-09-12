using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace esport_leauge
{
    public partial class DataModule : Form
    {

        //reference tables
        public DataTable dtArena;
        public DataTable dtEvent;
        public DataTable dtChallenge;
        public DataTable dtCompetitor;
        public DataTable dtEntry;

        //reference views
        public DataView ArenaView;
        public DataView EventView;
        public DataView ChallengeView;
        public DataView CompetitorView;
        public DataView EntryView;


        public DataModule()
        {
            InitializeComponent();
            //fill data adapters with dataset
            DSnzesl.EnforceConstraints = false;
            daArena.Fill(DSnzesl);
            daEvent.Fill(DSnzesl);
            daChallenge.Fill(DSnzesl);
            daCompetitor.Fill(DSnzesl);
            daEntry.Fill(DSnzesl);

            //assign data tables name
            dtArena = DSnzesl.Tables["Arena"];
            dtEvent = DSnzesl.Tables["Event"];
            dtChallenge = DSnzesl.Tables["Challenge"];
            dtCompetitor = DSnzesl.Tables["Competitor"];
            dtEntry = DSnzesl.Tables["Entry"];

            //views
            ArenaView = new DataView(dtArena);
            ArenaView.Sort = "ArenaID";
            EventView = new DataView(dtEvent);
            EventView.Sort = "EventID";
            ChallengeView = new DataView(dtChallenge);
            ChallengeView.Sort = "ChallengeID";
            CompetitorView = new DataView(dtCompetitor);
            CompetitorView.Sort = "CompetitorID";
            EntryView = new DataView(dtEntry);
            EntryView.Sort = "ChallengeID";
            DSnzesl.EnforceConstraints = true;
        }

        public void updateArena()
        {
            daArena.Update(dtArena);
        }
        public void updateEvent()
        {
            daEvent.Update(dtEvent);
        }
        public void updateChallenge()
        {
            daChallenge.Update(dtChallenge);
        }
        public void updateCompetitor()
        {
            daCompetitor.Update(dtCompetitor);
        }
        public void updateEntry()
        {
            daEntry.Update(dtEntry);
        }

        private void daArena_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", dbConnection);
            if(e.StatementType == StatementType.Insert) 
            { 
                newID = (int)idCMD.ExecuteScalar();
                e.Row["ArenaID"] = newID;
            }
        }

        private void daChallenge_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", dbConnection);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["ChallengeID"] = newID;
            }
        }

        private void daCompetitor_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", dbConnection);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["CompetitorID"] = newID;
            }
        }

        private void daEvent_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", dbConnection);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["EventID"] = newID;
            }
        }
    }
}
 