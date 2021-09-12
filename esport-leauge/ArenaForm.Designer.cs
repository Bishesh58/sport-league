
namespace esport_leauge
{
    partial class ArenaForm
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
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstArena = new System.Windows.Forms.ListBox();
            this.pnlList = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArenaID = new System.Windows.Forms.TextBox();
            this.txtArenaName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.cboTxtCity = new System.Windows.Forms.ComboBox();
            this.grpArena = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlAddArena = new System.Windows.Forms.Panel();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.btnSaveArena = new System.Windows.Forms.Button();
            this.txtNewStreetAddress = new System.Windows.Forms.TextBox();
            this.cboNewTxtCity = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNewArenaName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNewPhoneNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNewSuburb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlList.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpArena.SuspendLayout();
            this.pnlAddArena.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(469, 494);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 54);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstArena
            // 
            this.lstArena.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstArena.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lstArena.FormattingEnabled = true;
            this.lstArena.ItemHeight = 23;
            this.lstArena.Location = new System.Drawing.Point(0, 0);
            this.lstArena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstArena.Name = "lstArena";
            this.lstArena.Size = new System.Drawing.Size(341, 502);
            this.lstArena.TabIndex = 1;
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.panel2);
            this.pnlList.Controls.Add(this.lstArena);
            this.pnlList.Location = new System.Drawing.Point(44, 46);
            this.pnlList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(341, 502);
            this.pnlList.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnPrevious);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 448);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 54);
            this.panel2.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(226, 0);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(115, 54);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(0, 0);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(115, 54);
            this.btnPrevious.TabIndex = 19;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Arena ID:";
            // 
            // txtArenaID
            // 
            this.txtArenaID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArenaID.Location = new System.Drawing.Point(183, 43);
            this.txtArenaID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArenaID.Name = "txtArenaID";
            this.txtArenaID.Size = new System.Drawing.Size(67, 30);
            this.txtArenaID.TabIndex = 4;
            // 
            // txtArenaName
            // 
            this.txtArenaName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArenaName.Location = new System.Drawing.Point(183, 91);
            this.txtArenaName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArenaName.Name = "txtArenaName";
            this.txtArenaName.Size = new System.Drawing.Size(223, 30);
            this.txtArenaName.TabIndex = 6;
            this.txtArenaName.TextChanged += new System.EventHandler(this.txtArenaName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Arena Name:";
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreetAddress.Location = new System.Drawing.Point(183, 139);
            this.txtStreetAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(265, 30);
            this.txtStreetAddress.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Street Address:";
            // 
            // txtSuburb
            // 
            this.txtSuburb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuburb.Location = new System.Drawing.Point(183, 191);
            this.txtSuburb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(173, 30);
            this.txtSuburb.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Suburb:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "City:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(183, 304);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(173, 30);
            this.txtPhoneNumber.TabIndex = 14;
            this.txtPhoneNumber.MouseHover += new System.EventHandler(this.txtPhoneNumber_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Phone Number:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(589, 494);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 54);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(711, 494);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 54);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
            this.btnSaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Location = new System.Drawing.Point(60, 364);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(236, 54);
            this.btnSaveChanges.TabIndex = 17;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
            this.btnCancelUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelUpdate.FlatAppearance.BorderSize = 0;
            this.btnCancelUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCancelUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelUpdate.ForeColor = System.Drawing.Color.White;
            this.btnCancelUpdate.Location = new System.Drawing.Point(301, 364);
            this.btnCancelUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(115, 54);
            this.btnCancelUpdate.TabIndex = 18;
            this.btnCancelUpdate.Text = "Cancel";
            this.btnCancelUpdate.UseVisualStyleBackColor = false;
            this.btnCancelUpdate.Visible = false;
            this.btnCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
            // 
            // cboTxtCity
            // 
            this.cboTxtCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTxtCity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTxtCity.FormattingEnabled = true;
            this.cboTxtCity.Items.AddRange(new object[] {
            "Auckland"});
            this.cboTxtCity.Location = new System.Drawing.Point(183, 244);
            this.cboTxtCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTxtCity.Name = "cboTxtCity";
            this.cboTxtCity.Size = new System.Drawing.Size(173, 31);
            this.cboTxtCity.TabIndex = 19;
            // 
            // grpArena
            // 
            this.grpArena.Controls.Add(this.txtStreetAddress);
            this.grpArena.Controls.Add(this.cboTxtCity);
            this.grpArena.Controls.Add(this.label1);
            this.grpArena.Controls.Add(this.btnCancelUpdate);
            this.grpArena.Controls.Add(this.txtArenaID);
            this.grpArena.Controls.Add(this.btnSaveChanges);
            this.grpArena.Controls.Add(this.label2);
            this.grpArena.Controls.Add(this.txtArenaName);
            this.grpArena.Controls.Add(this.label3);
            this.grpArena.Controls.Add(this.txtPhoneNumber);
            this.grpArena.Controls.Add(this.label4);
            this.grpArena.Controls.Add(this.label6);
            this.grpArena.Controls.Add(this.txtSuburb);
            this.grpArena.Controls.Add(this.label5);
            this.grpArena.Location = new System.Drawing.Point(409, 46);
            this.grpArena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpArena.Name = "grpArena";
            this.grpArena.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpArena.Size = new System.Drawing.Size(475, 433);
            this.grpArena.TabIndex = 2;
            this.grpArena.TabStop = false;
            this.grpArena.Text = "Arena details:";
            // 
            // pnlAddArena
            // 
            this.pnlAddArena.Controls.Add(this.btnCancelAdd);
            this.pnlAddArena.Controls.Add(this.btnSaveArena);
            this.pnlAddArena.Controls.Add(this.txtNewStreetAddress);
            this.pnlAddArena.Controls.Add(this.cboNewTxtCity);
            this.pnlAddArena.Controls.Add(this.label7);
            this.pnlAddArena.Controls.Add(this.txtNewArenaName);
            this.pnlAddArena.Controls.Add(this.label8);
            this.pnlAddArena.Controls.Add(this.txtNewPhoneNumber);
            this.pnlAddArena.Controls.Add(this.label9);
            this.pnlAddArena.Controls.Add(this.label10);
            this.pnlAddArena.Controls.Add(this.txtNewSuburb);
            this.pnlAddArena.Controls.Add(this.label11);
            this.pnlAddArena.Location = new System.Drawing.Point(913, 46);
            this.pnlAddArena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAddArena.Name = "pnlAddArena";
            this.pnlAddArena.Size = new System.Drawing.Size(488, 433);
            this.pnlAddArena.TabIndex = 17;
            this.pnlAddArena.Visible = false;
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
            this.btnCancelAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelAdd.FlatAppearance.BorderSize = 0;
            this.btnCancelAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCancelAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAdd.ForeColor = System.Drawing.Color.White;
            this.btnCancelAdd.Location = new System.Drawing.Point(296, 311);
            this.btnCancelAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(115, 54);
            this.btnCancelAdd.TabIndex = 31;
            this.btnCancelAdd.Text = "Cancel";
            this.btnCancelAdd.UseVisualStyleBackColor = false;
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // btnSaveArena
            // 
            this.btnSaveArena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
            this.btnSaveArena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveArena.FlatAppearance.BorderSize = 0;
            this.btnSaveArena.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSaveArena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveArena.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveArena.ForeColor = System.Drawing.Color.White;
            this.btnSaveArena.Location = new System.Drawing.Point(55, 311);
            this.btnSaveArena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveArena.Name = "btnSaveArena";
            this.btnSaveArena.Size = new System.Drawing.Size(236, 54);
            this.btnSaveArena.TabIndex = 30;
            this.btnSaveArena.Text = "Save  Arena";
            this.btnSaveArena.UseVisualStyleBackColor = false;
            this.btnSaveArena.Click += new System.EventHandler(this.btnSaveArena_Click);
            // 
            // txtNewStreetAddress
            // 
            this.txtNewStreetAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewStreetAddress.Location = new System.Drawing.Point(191, 69);
            this.txtNewStreetAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewStreetAddress.Name = "txtNewStreetAddress";
            this.txtNewStreetAddress.Size = new System.Drawing.Size(265, 30);
            this.txtNewStreetAddress.TabIndex = 23;
            // 
            // cboNewTxtCity
            // 
            this.cboNewTxtCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNewTxtCity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNewTxtCity.FormattingEnabled = true;
            this.cboNewTxtCity.Items.AddRange(new object[] {
            "Auckland",
            "Hamilton",
            "Tauranga"});
            this.cboNewTxtCity.Location = new System.Drawing.Point(191, 174);
            this.cboNewTxtCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboNewTxtCity.Name = "cboNewTxtCity";
            this.cboNewTxtCity.Size = new System.Drawing.Size(173, 31);
            this.cboNewTxtCity.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Arena Name:";
            // 
            // txtNewArenaName
            // 
            this.txtNewArenaName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewArenaName.Location = new System.Drawing.Point(191, 21);
            this.txtNewArenaName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewArenaName.Name = "txtNewArenaName";
            this.txtNewArenaName.Size = new System.Drawing.Size(223, 30);
            this.txtNewArenaName.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 23);
            this.label8.TabIndex = 22;
            this.label8.Text = "Street Address:";
            // 
            // txtNewPhoneNumber
            // 
            this.txtNewPhoneNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNewPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPhoneNumber.Location = new System.Drawing.Point(191, 234);
            this.txtNewPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewPhoneNumber.Name = "txtNewPhoneNumber";
            this.txtNewPhoneNumber.Size = new System.Drawing.Size(173, 30);
            this.txtNewPhoneNumber.TabIndex = 28;
            this.txtNewPhoneNumber.MouseHover += new System.EventHandler(this.txtNewPhoneNumber_MouseHover);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(72, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 23);
            this.label9.TabIndex = 24;
            this.label9.Text = "Suburb:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 23);
            this.label10.TabIndex = 27;
            this.label10.Text = "Phone Number:";
            // 
            // txtNewSuburb
            // 
            this.txtNewSuburb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewSuburb.Location = new System.Drawing.Point(191, 121);
            this.txtNewSuburb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewSuburb.Name = "txtNewSuburb";
            this.txtNewSuburb.Size = new System.Drawing.Size(173, 30);
            this.txtNewSuburb.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(99, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 23);
            this.label11.TabIndex = 26;
            this.label11.Text = "City:";
            // 
            // ArenaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1435, 741);
            this.Controls.Add(this.pnlAddArena);
            this.Controls.Add(this.grpArena);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ArenaForm";
            this.Text = "Arena Maintenance";
            this.Load += new System.EventHandler(this.ArenaForm_Load);
            this.pnlList.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.grpArena.ResumeLayout(false);
            this.grpArena.PerformLayout();
            this.pnlAddArena.ResumeLayout(false);
            this.pnlAddArena.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstArena;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArenaID;
        private System.Windows.Forms.TextBox txtArenaName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnCancelUpdate;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.ComboBox cboTxtCity;
        private System.Windows.Forms.GroupBox grpArena;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnlAddArena;
        private System.Windows.Forms.Button btnCancelAdd;
        private System.Windows.Forms.Button btnSaveArena;
        private System.Windows.Forms.TextBox txtNewStreetAddress;
        private System.Windows.Forms.ComboBox cboNewTxtCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNewArenaName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNewPhoneNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNewSuburb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}