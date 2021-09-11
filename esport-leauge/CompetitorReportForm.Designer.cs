
namespace esport_leauge
{
    partial class CompetitorReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompetitorReportForm));
            this.btnDisplayCompetitor = new System.Windows.Forms.Button();
            this.txtReportComp = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDisplayCompetitor
            // 
            this.btnDisplayCompetitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(109)))), ((int)(((byte)(64)))));
            this.btnDisplayCompetitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisplayCompetitor.FlatAppearance.BorderSize = 0;
            this.btnDisplayCompetitor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDisplayCompetitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayCompetitor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayCompetitor.ForeColor = System.Drawing.Color.White;
            this.btnDisplayCompetitor.Location = new System.Drawing.Point(338, 534);
            this.btnDisplayCompetitor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDisplayCompetitor.Name = "btnDisplayCompetitor";
            this.btnDisplayCompetitor.Size = new System.Drawing.Size(202, 54);
            this.btnDisplayCompetitor.TabIndex = 39;
            this.btnDisplayCompetitor.Text = "Display Competitor Report";
            this.btnDisplayCompetitor.UseVisualStyleBackColor = false;
            this.btnDisplayCompetitor.Click += new System.EventHandler(this.btnDisplayCompetitor_Click);
            // 
            // txtReportComp
            // 
            this.txtReportComp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReportComp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReportComp.Location = new System.Drawing.Point(74, 81);
            this.txtReportComp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtReportComp.Multiline = true;
            this.txtReportComp.Name = "txtReportComp";
            this.txtReportComp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReportComp.Size = new System.Drawing.Size(603, 421);
            this.txtReportComp.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtReportComp);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 520);
            this.panel1.TabIndex = 40;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(109)))), ((int)(((byte)(64)))));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(545, 534);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(142, 54);
            this.btnPrint.TabIndex = 41;
            this.btnPrint.Text = "Print competitor";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Document = this.printDocument2;
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog2";
            this.printPreviewDialog2.Visible = false;
            // 
            // CompetitorReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 595);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDisplayCompetitor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CompetitorReportForm";
            this.Text = "Competitor Report Maintenance";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayCompetitor;
        private System.Windows.Forms.TextBox txtReportComp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
    }
}