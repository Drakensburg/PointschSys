
namespace NWU_Pointsch_System
{
    partial class frmStadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStadmin));
            this.picbPurpleThing = new System.Windows.Forms.PictureBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.picbLogo = new System.Windows.Forms.PictureBox();
            this.gbPS = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblInfraction = new System.Windows.Forms.Label();
            this.lblDiscipline = new System.Windows.Forms.Label();
            this.lblPos = new System.Windows.Forms.Label();
            this.lblNeg = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.picbSoSA = new System.Windows.Forms.PictureBox();
            this.picbStatus = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.gbInfraction = new System.Windows.Forms.GroupBox();
            this.lbInfraction = new System.Windows.Forms.ListBox();
            this.gbDiscipline = new System.Windows.Forms.GroupBox();
            this.lbDiscipline = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnRemoveInfraction = new System.Windows.Forms.Button();
            this.btnAddInfraction = new System.Windows.Forms.Button();
            this.btnRemoveDiscipline = new System.Windows.Forms.Button();
            this.btnAddDiscipline = new System.Windows.Forms.Button();
            this.btnEditDB = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblSno = new System.Windows.Forms.Label();
            this.lblSnoPhys = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbPurpleThing)).BeginInit();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbLogo)).BeginInit();
            this.gbPS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbSoSA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbStatus)).BeginInit();
            this.gbDetail.SuspendLayout();
            this.gbInfraction.SuspendLayout();
            this.gbDiscipline.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbPurpleThing
            // 
            this.picbPurpleThing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbPurpleThing.BackgroundImage")));
            this.picbPurpleThing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbPurpleThing.Location = new System.Drawing.Point(-523, -422);
            this.picbPurpleThing.Name = "picbPurpleThing";
            this.picbPurpleThing.Size = new System.Drawing.Size(670, 1942);
            this.picbPurpleThing.TabIndex = 12;
            this.picbPurpleThing.TabStop = false;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.lblSnoPhys);
            this.gbInfo.Controls.Add(this.lblSno);
            this.gbInfo.Controls.Add(this.picbLogo);
            this.gbInfo.Controls.Add(this.gbPS);
            this.gbInfo.Controls.Add(this.picbSoSA);
            this.gbInfo.Controls.Add(this.picbStatus);
            this.gbInfo.Controls.Add(this.lblName);
            this.gbInfo.Controls.Add(this.lblSurname);
            this.gbInfo.Location = new System.Drawing.Point(149, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(923, 296);
            this.gbInfo.TabIndex = 13;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "INFORMATION";
            // 
            // picbLogo
            // 
            this.picbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbLogo.BackgroundImage")));
            this.picbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbLogo.Image = ((System.Drawing.Image)(resources.GetObject("picbLogo.Image")));
            this.picbLogo.Location = new System.Drawing.Point(804, 16);
            this.picbLogo.Name = "picbLogo";
            this.picbLogo.Size = new System.Drawing.Size(113, 109);
            this.picbLogo.TabIndex = 8;
            this.picbLogo.TabStop = false;
            // 
            // gbPS
            // 
            this.gbPS.Controls.Add(this.lblTotal);
            this.gbPS.Controls.Add(this.lblInfraction);
            this.gbPS.Controls.Add(this.lblDiscipline);
            this.gbPS.Controls.Add(this.lblPos);
            this.gbPS.Controls.Add(this.lblNeg);
            this.gbPS.Controls.Add(this.lblSum);
            this.gbPS.Location = new System.Drawing.Point(463, 163);
            this.gbPS.Name = "gbPS";
            this.gbPS.Size = new System.Drawing.Size(460, 126);
            this.gbPS.TabIndex = 7;
            this.gbPS.TabStop = false;
            this.gbPS.Text = "POINTSCHS GIVEN:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(356, 27);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(86, 25);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "TOTAL:";
            // 
            // lblInfraction
            // 
            this.lblInfraction.AutoSize = true;
            this.lblInfraction.Location = new System.Drawing.Point(169, 27);
            this.lblInfraction.Name = "lblInfraction";
            this.lblInfraction.Size = new System.Drawing.Size(158, 25);
            this.lblInfraction.TabIndex = 9;
            this.lblInfraction.Text = "INFRACTIONS:";
            // 
            // lblDiscipline
            // 
            this.lblDiscipline.AutoSize = true;
            this.lblDiscipline.Location = new System.Drawing.Point(6, 27);
            this.lblDiscipline.Name = "lblDiscipline";
            this.lblDiscipline.Size = new System.Drawing.Size(146, 25);
            this.lblDiscipline.TabIndex = 8;
            this.lblDiscipline.Text = "DISCIPLINES:";
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPos.Location = new System.Drawing.Point(23, 63);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(114, 61);
            this.lblPos.TabIndex = 7;
            this.lblPos.Text = "000";
            // 
            // lblNeg
            // 
            this.lblNeg.AutoSize = true;
            this.lblNeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeg.Location = new System.Drawing.Point(189, 63);
            this.lblNeg.Name = "lblNeg";
            this.lblNeg.Size = new System.Drawing.Size(114, 61);
            this.lblNeg.TabIndex = 6;
            this.lblNeg.Text = "000";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.ForeColor = System.Drawing.Color.Purple;
            this.lblSum.Location = new System.Drawing.Point(340, 63);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(114, 61);
            this.lblSum.TabIndex = 5;
            this.lblSum.Text = "000";
            // 
            // picbSoSA
            // 
            this.picbSoSA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbSoSA.BackgroundImage")));
            this.picbSoSA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbSoSA.Location = new System.Drawing.Point(6, 30);
            this.picbSoSA.Name = "picbSoSA";
            this.picbSoSA.Size = new System.Drawing.Size(259, 259);
            this.picbSoSA.TabIndex = 0;
            this.picbSoSA.TabStop = false;
            // 
            // picbStatus
            // 
            this.picbStatus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbStatus.BackgroundImage")));
            this.picbStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbStatus.Location = new System.Drawing.Point(280, 118);
            this.picbStatus.Name = "picbStatus";
            this.picbStatus.Size = new System.Drawing.Size(171, 171);
            this.picbStatus.TabIndex = 3;
            this.picbStatus.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(274, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(106, 33);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "NAME:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(274, 82);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(167, 33);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "SURNAME:";
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.gbInfraction);
            this.gbDetail.Controls.Add(this.gbDiscipline);
            this.gbDetail.Location = new System.Drawing.Point(149, 335);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(923, 376);
            this.gbDetail.TabIndex = 14;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "PREVIOUSLY GIVEN:";
            // 
            // gbInfraction
            // 
            this.gbInfraction.Controls.Add(this.lbInfraction);
            this.gbInfraction.Location = new System.Drawing.Point(6, 30);
            this.gbInfraction.Name = "gbInfraction";
            this.gbInfraction.Size = new System.Drawing.Size(911, 169);
            this.gbInfraction.TabIndex = 7;
            this.gbInfraction.TabStop = false;
            this.gbInfraction.Text = "INFRACTIONS:";
            // 
            // lbInfraction
            // 
            this.lbInfraction.FormattingEnabled = true;
            this.lbInfraction.ItemHeight = 25;
            this.lbInfraction.Location = new System.Drawing.Point(6, 30);
            this.lbInfraction.Name = "lbInfraction";
            this.lbInfraction.Size = new System.Drawing.Size(899, 129);
            this.lbInfraction.TabIndex = 0;
            // 
            // gbDiscipline
            // 
            this.gbDiscipline.Controls.Add(this.lbDiscipline);
            this.gbDiscipline.Location = new System.Drawing.Point(6, 205);
            this.gbDiscipline.Name = "gbDiscipline";
            this.gbDiscipline.Size = new System.Drawing.Size(911, 166);
            this.gbDiscipline.TabIndex = 8;
            this.gbDiscipline.TabStop = false;
            this.gbDiscipline.Text = "DISCIPLINES:";
            // 
            // lbDiscipline
            // 
            this.lbDiscipline.FormattingEnabled = true;
            this.lbDiscipline.ItemHeight = 25;
            this.lbDiscipline.Location = new System.Drawing.Point(6, 30);
            this.lbDiscipline.Name = "lbDiscipline";
            this.lbDiscipline.Size = new System.Drawing.Size(899, 129);
            this.lbDiscipline.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReport);
            this.groupBox1.Controls.Add(this.btnRemoveInfraction);
            this.groupBox1.Controls.Add(this.btnAddInfraction);
            this.groupBox1.Controls.Add(this.btnRemoveDiscipline);
            this.groupBox1.Controls.Add(this.btnAddDiscipline);
            this.groupBox1.Location = new System.Drawing.Point(149, 730);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(923, 300);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DISCIPLINARY TOOLS:";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(12, 215);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(899, 62);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "REPORT";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnRemoveInfraction
            // 
            this.btnRemoveInfraction.Location = new System.Drawing.Point(497, 125);
            this.btnRemoveInfraction.Name = "btnRemoveInfraction";
            this.btnRemoveInfraction.Size = new System.Drawing.Size(408, 62);
            this.btnRemoveInfraction.TabIndex = 4;
            this.btnRemoveInfraction.Text = "REMOVE INFRACTION";
            this.btnRemoveInfraction.UseVisualStyleBackColor = true;
            this.btnRemoveInfraction.Click += new System.EventHandler(this.btnRemoveInfraction_Click);
            // 
            // btnAddInfraction
            // 
            this.btnAddInfraction.Location = new System.Drawing.Point(12, 125);
            this.btnAddInfraction.Name = "btnAddInfraction";
            this.btnAddInfraction.Size = new System.Drawing.Size(452, 62);
            this.btnAddInfraction.TabIndex = 3;
            this.btnAddInfraction.Text = "ADD INFRACTION";
            this.btnAddInfraction.UseVisualStyleBackColor = true;
            this.btnAddInfraction.Click += new System.EventHandler(this.btnAddInfraction_Click);
            // 
            // btnRemoveDiscipline
            // 
            this.btnRemoveDiscipline.Location = new System.Drawing.Point(497, 30);
            this.btnRemoveDiscipline.Name = "btnRemoveDiscipline";
            this.btnRemoveDiscipline.Size = new System.Drawing.Size(408, 62);
            this.btnRemoveDiscipline.TabIndex = 2;
            this.btnRemoveDiscipline.Text = "REMOVE DISCIPLINE";
            this.btnRemoveDiscipline.UseVisualStyleBackColor = true;
            this.btnRemoveDiscipline.Click += new System.EventHandler(this.btnRemoveDiscipline_Click);
            // 
            // btnAddDiscipline
            // 
            this.btnAddDiscipline.Location = new System.Drawing.Point(12, 30);
            this.btnAddDiscipline.Name = "btnAddDiscipline";
            this.btnAddDiscipline.Size = new System.Drawing.Size(452, 62);
            this.btnAddDiscipline.TabIndex = 0;
            this.btnAddDiscipline.Text = "ADD DISCIPLINE";
            this.btnAddDiscipline.UseVisualStyleBackColor = true;
            this.btnAddDiscipline.Click += new System.EventHandler(this.btnAddDiscipline_Click);
            // 
            // btnEditDB
            // 
            this.btnEditDB.Location = new System.Drawing.Point(161, 1046);
            this.btnEditDB.Name = "btnEditDB";
            this.btnEditDB.Size = new System.Drawing.Size(235, 50);
            this.btnEditDB.TabIndex = 5;
            this.btnEditDB.Text = "EDIT DATABASE";
            this.btnEditDB.UseVisualStyleBackColor = true;
            this.btnEditDB.Click += new System.EventHandler(this.btnEditDB_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(929, 1046);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(137, 50);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblSno
            // 
            this.lblSno.AutoSize = true;
            this.lblSno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSno.Location = new System.Drawing.Point(468, 118);
            this.lblSno.Name = "lblSno";
            this.lblSno.Size = new System.Drawing.Size(86, 33);
            this.lblSno.TabIndex = 9;
            this.lblSno.Text = "SNO:";
            // 
            // lblSnoPhys
            // 
            this.lblSnoPhys.AutoSize = true;
            this.lblSnoPhys.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnoPhys.Location = new System.Drawing.Point(560, 118);
            this.lblSnoPhys.Name = "lblSnoPhys";
            this.lblSnoPhys.Size = new System.Drawing.Size(94, 33);
            this.lblSnoPhys.TabIndex = 12;
            this.lblSnoPhys.Text = "[SNO]";
            // 
            // frmStadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 1108);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnEditDB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.picbPurpleThing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmStadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Member";
            ((System.ComponentModel.ISupportInitialize)(this.picbPurpleThing)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbLogo)).EndInit();
            this.gbPS.ResumeLayout(false);
            this.gbPS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbSoSA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbStatus)).EndInit();
            this.gbDetail.ResumeLayout(false);
            this.gbInfraction.ResumeLayout(false);
            this.gbDiscipline.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbPurpleThing;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.PictureBox picbLogo;
        private System.Windows.Forms.GroupBox gbPS;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblInfraction;
        private System.Windows.Forms.Label lblDiscipline;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Label lblNeg;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.PictureBox picbSoSA;
        private System.Windows.Forms.PictureBox picbStatus;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.GroupBox gbInfraction;
        private System.Windows.Forms.ListBox lbInfraction;
        private System.Windows.Forms.GroupBox gbDiscipline;
        private System.Windows.Forms.ListBox lbDiscipline;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnRemoveInfraction;
        private System.Windows.Forms.Button btnAddInfraction;
        private System.Windows.Forms.Button btnRemoveDiscipline;
        private System.Windows.Forms.Button btnAddDiscipline;
        private System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.Label lblSno;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblSurname;
        public System.Windows.Forms.Label lblSnoPhys;
        public System.Windows.Forms.Button btnEditDB;
    }
}