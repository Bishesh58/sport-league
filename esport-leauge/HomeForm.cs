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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            lbInfo.Text = "How to Navigate: " +"\nClick on logo (Esport League) to return to home" +
                "\nClick hold and drag on top banner bar to move form around!" +
                "\nEach buttons will take to their respective forms," +
                "\nHover over numberic textbox to see tooltip";
        }
    }
}
