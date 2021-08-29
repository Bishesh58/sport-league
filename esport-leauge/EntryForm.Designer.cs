
namespace esport_leauge
{
    partial class EntryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCompetitor = new System.Windows.Forms.DataGridView();
            this.btnAddEntry = new System.Windows.Forms.Button();
            this.btnRemoveEntry = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.cboTxtStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvChallenge = new System.Windows.Forms.DataGridView();
            this.dSnzesl = new esport_leauge.DSnzesl();
            this.dgvEntry = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChallenge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSnzesl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompetitor
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            this.dgvCompetitor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompetitor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCompetitor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCompetitor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompetitor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCompetitor.ColumnHeadersHeight = 29;
            this.dgvCompetitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompetitor.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCompetitor.GridColor = System.Drawing.Color.White;
            this.dgvCompetitor.Location = new System.Drawing.Point(12, 12);
            this.dgvCompetitor.Name = "dgvCompetitor";
            this.dgvCompetitor.ReadOnly = true;
            this.dgvCompetitor.RowHeadersWidth = 20;
            this.dgvCompetitor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCompetitor.RowTemplate.Height = 24;
            this.dgvCompetitor.Size = new System.Drawing.Size(566, 332);
            this.dgvCompetitor.TabIndex = 0;
            this.dgvCompetitor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompetitor_CellClick);
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.btnAddEntry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEntry.FlatAppearance.BorderSize = 0;
            this.btnAddEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEntry.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEntry.ForeColor = System.Drawing.Color.White;
            this.btnAddEntry.Location = new System.Drawing.Point(667, 185);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(236, 54);
            this.btnAddEntry.TabIndex = 54;
            this.btnAddEntry.Text = "Add Entry";
            this.btnAddEntry.UseVisualStyleBackColor = false;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // btnRemoveEntry
            // 
            this.btnRemoveEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.btnRemoveEntry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveEntry.FlatAppearance.BorderSize = 0;
            this.btnRemoveEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRemoveEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveEntry.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveEntry.ForeColor = System.Drawing.Color.White;
            this.btnRemoveEntry.Location = new System.Drawing.Point(667, 255);
            this.btnRemoveEntry.Name = "btnRemoveEntry";
            this.btnRemoveEntry.Size = new System.Drawing.Size(236, 54);
            this.btnRemoveEntry.TabIndex = 55;
            this.btnRemoveEntry.Text = "Remove Entry";
            this.btnRemoveEntry.UseVisualStyleBackColor = false;
            this.btnRemoveEntry.Click += new System.EventHandler(this.btnRemoveEntry_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(584, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 59;
            this.label2.Text = "Event Name:";
            // 
            // txtEventName
            // 
            this.txtEventName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName.Location = new System.Drawing.Point(699, 51);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.ReadOnly = true;
            this.txtEventName.Size = new System.Drawing.Size(222, 30);
            this.txtEventName.TabIndex = 60;
            // 
            // cboTxtStatus
            // 
            this.cboTxtStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTxtStatus.FormattingEnabled = true;
            this.cboTxtStatus.Location = new System.Drawing.Point(699, 87);
            this.cboTxtStatus.Name = "cboTxtStatus";
            this.cboTxtStatus.Size = new System.Drawing.Size(173, 31);
            this.cboTxtStatus.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(631, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 23);
            this.label5.TabIndex = 63;
            this.label5.Text = "Status:";
            // 
            // dgvChallenge
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Lavender;
            this.dgvChallenge.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvChallenge.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvChallenge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChallenge.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChallenge.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvChallenge.ColumnHeadersHeight = 29;
            this.dgvChallenge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChallenge.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvChallenge.GridColor = System.Drawing.Color.White;
            this.dgvChallenge.Location = new System.Drawing.Point(12, 367);
            this.dgvChallenge.Name = "dgvChallenge";
            this.dgvChallenge.ReadOnly = true;
            this.dgvChallenge.RowHeadersWidth = 20;
            this.dgvChallenge.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvChallenge.RowTemplate.Height = 24;
            this.dgvChallenge.Size = new System.Drawing.Size(566, 306);
            this.dgvChallenge.TabIndex = 66;
            this.dgvChallenge.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChallenge_CellClick);
            // 
            // dSnzesl
            // 
            this.dSnzesl.DataSetName = "DSnzesl";
            this.dSnzesl.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvEntry
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Lavender;
            this.dgvEntry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEntry.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvEntry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEntry.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEntry.ColumnHeadersHeight = 29;
            this.dgvEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEntry.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEntry.GridColor = System.Drawing.Color.White;
            this.dgvEntry.Location = new System.Drawing.Point(588, 367);
            this.dgvEntry.Name = "dgvEntry";
            this.dgvEntry.ReadOnly = true;
            this.dgvEntry.RowHeadersWidth = 20;
            this.dgvEntry.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEntry.RowTemplate.Height = 24;
            this.dgvEntry.Size = new System.Drawing.Size(333, 306);
            this.dgvEntry.TabIndex = 67;
            this.dgvEntry.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntry_CellClick);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 685);
            this.Controls.Add(this.dgvEntry);
            this.Controls.Add(this.dgvChallenge);
            this.Controls.Add(this.cboTxtStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.btnRemoveEntry);
            this.Controls.Add(this.btnAddEntry);
            this.Controls.Add(this.dgvCompetitor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EntryForm";
            this.Text = "Entry Maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChallenge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSnzesl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompetitor;
        private System.Windows.Forms.Button btnAddEntry;
        private System.Windows.Forms.Button btnRemoveEntry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.ComboBox cboTxtStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvChallenge;
        private DSnzesl dSnzesl;
        private System.Windows.Forms.DataGridView dgvEntry;
    }
}