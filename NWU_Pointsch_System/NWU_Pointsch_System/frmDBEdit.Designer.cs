
namespace NWU_Pointsch_System
{
    partial class frmDBEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDBEdit));
            this.dgvPointsch = new System.Windows.Forms.DataGridView();
            this.picbPurpleThing = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbPersonalInformation = new System.Windows.Forms.GroupBox();
            this.lblCampus = new System.Windows.Forms.Label();
            this.cbCampus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblSNo = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtSNO = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbPointschInformation = new System.Windows.Forms.GroupBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPIRemove = new System.Windows.Forms.Button();
            this.btnPIAdd = new System.Windows.Forms.Button();
            this.lblTypeName = new System.Windows.Forms.Label();
            this.lblWorth = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.lblDI = new System.Windows.Forms.Label();
            this.cbDI = new System.Windows.Forms.ComboBox();
            this.btnGridStudents = new System.Windows.Forms.Button();
            this.btnGridStaff = new System.Windows.Forms.Button();
            this.btnGridDis = new System.Windows.Forms.Button();
            this.btnGridInf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPointsch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbPurpleThing)).BeginInit();
            this.gbPersonalInformation.SuspendLayout();
            this.gbPointschInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPointsch
            // 
            this.dgvPointsch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPointsch.Location = new System.Drawing.Point(196, 12);
            this.dgvPointsch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPointsch.Name = "dgvPointsch";
            this.dgvPointsch.RowHeadersWidth = 82;
            this.dgvPointsch.RowTemplate.Height = 33;
            this.dgvPointsch.Size = new System.Drawing.Size(1436, 567);
            this.dgvPointsch.TabIndex = 0;
            // 
            // picbPurpleThing
            // 
            this.picbPurpleThing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbPurpleThing.BackgroundImage")));
            this.picbPurpleThing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbPurpleThing.Location = new System.Drawing.Point(-480, -579);
            this.picbPurpleThing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picbPurpleThing.Name = "picbPurpleThing";
            this.picbPurpleThing.Size = new System.Drawing.Size(670, 1942);
            this.picbPurpleThing.TabIndex = 12;
            this.picbPurpleThing.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1516, 854);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 54);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbPersonalInformation
            // 
            this.gbPersonalInformation.Controls.Add(this.lblCampus);
            this.gbPersonalInformation.Controls.Add(this.cbCampus);
            this.gbPersonalInformation.Controls.Add(this.label1);
            this.gbPersonalInformation.Controls.Add(this.cbPosition);
            this.gbPersonalInformation.Controls.Add(this.lblID);
            this.gbPersonalInformation.Controls.Add(this.lblSNo);
            this.gbPersonalInformation.Controls.Add(this.lblSurname);
            this.gbPersonalInformation.Controls.Add(this.lblName);
            this.gbPersonalInformation.Controls.Add(this.txtID);
            this.gbPersonalInformation.Controls.Add(this.txtSNO);
            this.gbPersonalInformation.Controls.Add(this.txtSurname);
            this.gbPersonalInformation.Controls.Add(this.txtName);
            this.gbPersonalInformation.Controls.Add(this.button1);
            this.gbPersonalInformation.Controls.Add(this.button2);
            this.gbPersonalInformation.Location = new System.Drawing.Point(196, 587);
            this.gbPersonalInformation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPersonalInformation.Name = "gbPersonalInformation";
            this.gbPersonalInformation.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPersonalInformation.Size = new System.Drawing.Size(688, 260);
            this.gbPersonalInformation.TabIndex = 14;
            this.gbPersonalInformation.TabStop = false;
            this.gbPersonalInformation.Text = "PERSONAL INFORMATION";
            // 
            // lblCampus
            // 
            this.lblCampus.AutoSize = true;
            this.lblCampus.Location = new System.Drawing.Point(0, 142);
            this.lblCampus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCampus.Name = "lblCampus";
            this.lblCampus.Size = new System.Drawing.Size(108, 25);
            this.lblCampus.TabIndex = 27;
            this.lblCampus.Text = "CAMPUS:";
            // 
            // cbCampus
            // 
            this.cbCampus.FormattingEnabled = true;
            this.cbCampus.Items.AddRange(new object[] {
            "Potchefstroom",
            "Mafikeng",
            "Vaal"});
            this.cbCampus.Location = new System.Drawing.Point(116, 140);
            this.cbCampus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCampus.Name = "cbCampus";
            this.cbCampus.Size = new System.Drawing.Size(198, 33);
            this.cbCampus.TabIndex = 26;
            this.cbCampus.Text = "SELECT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "POSITION:";
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "Student",
            "Admin",
            "Staff"});
            this.cbPosition.Location = new System.Drawing.Point(444, 137);
            this.cbPosition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(236, 33);
            this.cbPosition.TabIndex = 24;
            this.cbPosition.Text = "SELECT";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(400, 85);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(38, 25);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "ID:";
            // 
            // lblSNo
            // 
            this.lblSNo.AutoSize = true;
            this.lblSNo.Location = new System.Drawing.Point(46, 85);
            this.lblSNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSNo.Name = "lblSNo";
            this.lblSNo.Size = new System.Drawing.Size(63, 25);
            this.lblSNo.TabIndex = 21;
            this.lblSNo.Text = "SNO:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(320, 33);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(123, 25);
            this.lblSurname.TabIndex = 20;
            this.lblSurname.Text = "SURNAME:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 38);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 25);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "NAME:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(444, 83);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(236, 31);
            this.txtID.TabIndex = 18;
            // 
            // txtSNO
            // 
            this.txtSNO.Location = new System.Drawing.Point(116, 83);
            this.txtSNO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSNO.Name = "txtSNO";
            this.txtSNO.Size = new System.Drawing.Size(198, 31);
            this.txtSNO.TabIndex = 17;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(444, 31);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(236, 31);
            this.txtSurname.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(116, 31);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(198, 31);
            this.txtName.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 190);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 54);
            this.button1.TabIndex = 14;
            this.button1.Text = "REMOVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 190);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(336, 54);
            this.button2.TabIndex = 13;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbPointschInformation
            // 
            this.gbPointschInformation.Controls.Add(this.txtMax);
            this.gbPointschInformation.Controls.Add(this.label2);
            this.gbPointschInformation.Controls.Add(this.btnPIRemove);
            this.gbPointschInformation.Controls.Add(this.btnPIAdd);
            this.gbPointschInformation.Controls.Add(this.lblTypeName);
            this.gbPointschInformation.Controls.Add(this.lblWorth);
            this.gbPointschInformation.Controls.Add(this.txtMin);
            this.gbPointschInformation.Controls.Add(this.txtTypeName);
            this.gbPointschInformation.Controls.Add(this.lblDI);
            this.gbPointschInformation.Controls.Add(this.cbDI);
            this.gbPointschInformation.Location = new System.Drawing.Point(890, 587);
            this.gbPointschInformation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPointschInformation.Name = "gbPointschInformation";
            this.gbPointschInformation.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPointschInformation.Size = new System.Drawing.Size(742, 260);
            this.gbPointschInformation.TabIndex = 15;
            this.gbPointschInformation.TabStop = false;
            this.gbPointschInformation.Text = "POITSCH INFORMATION";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(488, 150);
            this.txtMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(242, 31);
            this.txtMax.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "MAX:";
            // 
            // btnPIRemove
            // 
            this.btnPIRemove.Location = new System.Drawing.Point(372, 190);
            this.btnPIRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPIRemove.Name = "btnPIRemove";
            this.btnPIRemove.Size = new System.Drawing.Size(356, 54);
            this.btnPIRemove.TabIndex = 12;
            this.btnPIRemove.Text = "REMOVE";
            this.btnPIRemove.UseVisualStyleBackColor = true;
            this.btnPIRemove.Click += new System.EventHandler(this.btnPIRemove_Click);
            // 
            // btnPIAdd
            // 
            this.btnPIAdd.Location = new System.Drawing.Point(12, 190);
            this.btnPIAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPIAdd.Name = "btnPIAdd";
            this.btnPIAdd.Size = new System.Drawing.Size(356, 54);
            this.btnPIAdd.TabIndex = 11;
            this.btnPIAdd.Text = "ADD";
            this.btnPIAdd.UseVisualStyleBackColor = true;
            this.btnPIAdd.Click += new System.EventHandler(this.btnPIAdd_Click);
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Location = new System.Drawing.Point(8, 75);
            this.lblTypeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(425, 25);
            this.lblTypeName.TabIndex = 10;
            this.lblTypeName.Text = "TYPE NAME (if removing only fill this field):";
            // 
            // lblWorth
            // 
            this.lblWorth.AutoSize = true;
            this.lblWorth.Location = new System.Drawing.Point(82, 156);
            this.lblWorth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorth.Name = "lblWorth";
            this.lblWorth.Size = new System.Drawing.Size(56, 25);
            this.lblWorth.TabIndex = 9;
            this.lblWorth.Text = "MIN:";
            this.lblWorth.Click += new System.EventHandler(this.lblWorth_Click);
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(150, 150);
            this.txtMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(214, 31);
            this.txtMin.TabIndex = 6;
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(276, 104);
            this.txtTypeName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(454, 31);
            this.txtTypeName.TabIndex = 5;
            // 
            // lblDI
            // 
            this.lblDI.AutoSize = true;
            this.lblDI.Location = new System.Drawing.Point(6, 33);
            this.lblDI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDI.Name = "lblDI";
            this.lblDI.Size = new System.Drawing.Size(264, 25);
            this.lblDI.TabIndex = 3;
            this.lblDI.Text = "DISCIPLINE/INFRACTION:";
            // 
            // cbDI
            // 
            this.cbDI.FormattingEnabled = true;
            this.cbDI.Items.AddRange(new object[] {
            "INFRACTION",
            "DISCIPLINE"});
            this.cbDI.Location = new System.Drawing.Point(276, 31);
            this.cbDI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDI.Name = "cbDI";
            this.cbDI.Size = new System.Drawing.Size(454, 33);
            this.cbDI.TabIndex = 2;
            this.cbDI.Text = "SELECT A D/I";
            // 
            // btnGridStudents
            // 
            this.btnGridStudents.Location = new System.Drawing.Point(480, 854);
            this.btnGridStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGridStudents.Name = "btnGridStudents";
            this.btnGridStudents.Size = new System.Drawing.Size(242, 54);
            this.btnGridStudents.TabIndex = 28;
            this.btnGridStudents.Text = "DISPLAY STUDENTS";
            this.btnGridStudents.UseVisualStyleBackColor = true;
            this.btnGridStudents.Click += new System.EventHandler(this.btnGridStudents_Click);
            // 
            // btnGridStaff
            // 
            this.btnGridStaff.Location = new System.Drawing.Point(730, 854);
            this.btnGridStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGridStaff.Name = "btnGridStaff";
            this.btnGridStaff.Size = new System.Drawing.Size(222, 54);
            this.btnGridStaff.TabIndex = 29;
            this.btnGridStaff.Text = "DISPLAY STAFF";
            this.btnGridStaff.UseVisualStyleBackColor = true;
            this.btnGridStaff.Click += new System.EventHandler(this.btnGridStaff_Click);
            // 
            // btnGridDis
            // 
            this.btnGridDis.Location = new System.Drawing.Point(960, 854);
            this.btnGridDis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGridDis.Name = "btnGridDis";
            this.btnGridDis.Size = new System.Drawing.Size(253, 54);
            this.btnGridDis.TabIndex = 30;
            this.btnGridDis.Text = "DISPLAY DISCIPLINES";
            this.btnGridDis.UseVisualStyleBackColor = true;
            this.btnGridDis.Click += new System.EventHandler(this.btnGridDis_Click);
            // 
            // btnGridInf
            // 
            this.btnGridInf.Location = new System.Drawing.Point(1221, 854);
            this.btnGridInf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGridInf.Name = "btnGridInf";
            this.btnGridInf.Size = new System.Drawing.Size(265, 54);
            this.btnGridInf.TabIndex = 31;
            this.btnGridInf.Text = "DISPLAY INFRACTIONS";
            this.btnGridInf.UseVisualStyleBackColor = true;
            this.btnGridInf.Click += new System.EventHandler(this.btnGridInf_Click);
            // 
            // frmDBEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1662, 924);
            this.Controls.Add(this.btnGridInf);
            this.Controls.Add(this.btnGridDis);
            this.Controls.Add(this.btnGridStaff);
            this.Controls.Add(this.btnGridStudents);
            this.Controls.Add(this.gbPointschInformation);
            this.Controls.Add(this.gbPersonalInformation);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picbPurpleThing);
            this.Controls.Add(this.dgvPointsch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDBEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Edit";
            this.Load += new System.EventHandler(this.frmDBEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPointsch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbPurpleThing)).EndInit();
            this.gbPersonalInformation.ResumeLayout(false);
            this.gbPersonalInformation.PerformLayout();
            this.gbPointschInformation.ResumeLayout(false);
            this.gbPointschInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPointsch;
        private System.Windows.Forms.PictureBox picbPurpleThing;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gbPersonalInformation;
        private System.Windows.Forms.GroupBox gbPointschInformation;
        private System.Windows.Forms.Label lblDI;
        private System.Windows.Forms.ComboBox cbDI;
        private System.Windows.Forms.Button btnPIRemove;
        private System.Windows.Forms.Button btnPIAdd;
        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.Label lblWorth;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblSNo;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtSNO;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Label lblCampus;
        private System.Windows.Forms.ComboBox cbCampus;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGridStudents;
        private System.Windows.Forms.Button btnGridStaff;
        private System.Windows.Forms.Button btnGridDis;
        private System.Windows.Forms.Button btnGridInf;
    }
}