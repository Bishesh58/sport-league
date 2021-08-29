using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace esport_leauge
{
    public partial class MainForm : Form
    {
        //forms reference
        private DataModule DM;
        private EventForm frmEvent;
        private ArenaForm frmArena;
        private ChallengeForm frmChallenge;
        private CompetitorForm frmCompetitor;
        private EntryForm frmEntry;
        private EventReportForm frmEventReport;
        private CompetitorReportForm frmCompetitorReport;
       
       
        private Form activeForm;
        public MainForm()
        {
            InitializeComponent();
        }


        
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlFeed.Controls.Add(childForm);
            this.pnlFeed.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule(); //loading data Module form from main form to pass data
            openChildForm(new HomeForm()); //home logo
        }

        private void btnArena_Click(object sender, EventArgs e)
        {
            frmArena = new ArenaForm(DM, this);
            openChildForm(frmArena);
            pnlTop.BackColor = Color.FromArgb(7, 153, 146);

        }
        private void btnEvent_Click(object sender, EventArgs e)
        {
            frmEvent = new EventForm(DM, this);
            openChildForm(frmEvent);
            pnlTop.BackColor = Color.FromArgb(52, 172, 224);


        }

        private void btnChallenge_Click(object sender, EventArgs e)
        {
            frmChallenge = new ChallengeForm(DM, this);
            openChildForm(frmChallenge);
            pnlTop.BackColor = Color.FromArgb(22, 160, 133);
        }

        private void btnCompetitor_Click(object sender, EventArgs e)
        {
            frmCompetitor = new CompetitorForm(DM, this);
            openChildForm(frmCompetitor);
            pnlTop.BackColor = Color.FromArgb(207, 106, 135);
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            frmEntry = new EntryForm(DM, this);
            openChildForm(frmEntry);
            pnlTop.BackColor = Color.FromArgb(112, 111, 211);
        }

        private void btnEventReport_Click(object sender, EventArgs e)
        {
            frmEventReport = new EventReportForm(DM, this);
            openChildForm(frmEventReport);
            pnlTop.BackColor = Color.FromArgb(88, 110, 130);
        }

        private void btnCompetitorReport_Click(object sender, EventArgs e)
        {
            frmCompetitorReport = new CompetitorReportForm(DM, this);
            openChildForm(frmCompetitorReport);
            pnlTop.BackColor = Color.FromArgb(182, 109, 64);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Application.Exit(); //need to change this before submission
            this.Close();
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            openChildForm(new HomeForm());
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //method for top panel drag when mouse is down
        //reference from https://stackoverflow.com/questions/1592876/make-a-borderless-form-movable
        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        //code for for top panel drag
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
    }
}
