
namespace NWU_Pointsch_System
{
    partial class frmProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfile));
            this.picbSoSA = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.picbStatus = new System.Windows.Forms.PictureBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.lblSnoPhys = new System.Windows.Forms.Label();
            this.lblSno = new System.Windows.Forms.Label();
            this.picbLogo = new System.Windows.Forms.PictureBox();
            this.gbPS = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblInfraction = new System.Windows.Forms.Label();
            this.lblDiscipline = new System.Windows.Forms.Label();
            this.lblPos = new System.Windows.Forms.Label();
            this.lblNeg = new System.Windows.Forms.Label();
            this.gbInfraction = new System.Windows.Forms.GroupBox();
            this.lbInfraction = new System.Windows.Forms.ListBox();
            this.gbDiscipline = new System.Windows.Forms.GroupBox();
            this.lbDiscipline = new System.Windows.Forms.ListBox();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.picbPurpleThing = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbSoSA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbStatus)).BeginInit();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbLogo)).BeginInit();
            this.gbPS.SuspendLayout();
            this.gbInfraction.SuspendLayout();
            this.gbDiscipline.SuspendLayout();
            this.gbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbPurpleThing)).BeginInit();
            this.SuspendLayout();
            // 
            // picbSoSA
            // 
            this.picbSoSA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbSoSA.BackgroundImage")));
            this.picbSoSA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbSoSA.Location = new System.Drawing.Point(3, 16);
            this.picbSoSA.Margin = new System.Windows.Forms.Padding(2);
            this.picbSoSA.Name = "picbSoSA";
            this.picbSoSA.Size = new System.Drawing.Size(130, 135);
            this.picbSoSA.TabIndex = 0;
            this.picbSoSA.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(137, 16);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 18);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "NAME:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(137, 43);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(87, 18);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "SURNAME:";
            // 
            // picbStatus
            // 
            this.picbStatus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbStatus.BackgroundImage")));
            this.picbStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbStatus.Location = new System.Drawing.Point(140, 61);
            this.picbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.picbStatus.Name = "picbStatus";
            this.picbStatus.Size = new System.Drawing.Size(86, 89);
            this.picbStatus.TabIndex = 3;
            this.picbStatus.TabStop = false;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.ForeColor = System.Drawing.Color.Purple;
            this.lblSum.Location = new System.Drawing.Point(170, 33);
            this.lblSum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(59, 31);
            this.lblSum.TabIndex = 5;
            this.lblSum.Text = "000";
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
            this.gbInfo.Location = new System.Drawing.Point(76, 6);
            this.gbInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gbInfo.Size = new System.Drawing.Size(462, 154);
            this.gbInfo.TabIndex = 6;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "INFORMATION";
            // 
            // lblSnoPhys
            // 
            this.lblSnoPhys.AutoSize = true;
            this.lblSnoPhys.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnoPhys.Location = new System.Drawing.Point(270, 61);
            this.lblSnoPhys.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSnoPhys.Name = "lblSnoPhys";
            this.lblSnoPhys.Size = new System.Drawing.Size(49, 18);
            this.lblSnoPhys.TabIndex = 11;
            this.lblSnoPhys.Text = "[SNO]";
            // 
            // lblSno
            // 
            this.lblSno.AutoSize = true;
            this.lblSno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSno.Location = new System.Drawing.Point(228, 61);
            this.lblSno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSno.Name = "lblSno";
            this.lblSno.Size = new System.Drawing.Size(45, 18);
            this.lblSno.TabIndex = 10;
            this.lblSno.Text = "SNO:";
            // 
            // picbLogo
            // 
            this.picbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbLogo.BackgroundImage")));
            this.picbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbLogo.Image = ((System.Drawing.Image)(resources.GetObject("picbLogo.Image")));
            this.picbLogo.Location = new System.Drawing.Point(402, 8);
            this.picbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picbLogo.Name = "picbLogo";
            this.picbLogo.Size = new System.Drawing.Size(56, 57);
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
            this.gbPS.Location = new System.Drawing.Point(232, 87);
            this.gbPS.Margin = new System.Windows.Forms.Padding(2);
            this.gbPS.Name = "gbPS";
            this.gbPS.Padding = new System.Windows.Forms.Padding(2);
            this.gbPS.Size = new System.Drawing.Size(230, 63);
            this.gbPS.TabIndex = 7;
            this.gbPS.TabStop = false;
            this.gbPS.Text = "POINTSCHS:SCORE";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(178, 14);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 13);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "TOTAL:";
            // 
            // lblInfraction
            // 
            this.lblInfraction.AutoSize = true;
            this.lblInfraction.Location = new System.Drawing.Point(84, 14);
            this.lblInfraction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfraction.Name = "lblInfraction";
            this.lblInfraction.Size = new System.Drawing.Size(82, 13);
            this.lblInfraction.TabIndex = 9;
            this.lblInfraction.Text = "INFRACTIONS:";
            // 
            // lblDiscipline
            // 
            this.lblDiscipline.AutoSize = true;
            this.lblDiscipline.Location = new System.Drawing.Point(3, 14);
            this.lblDiscipline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiscipline.Name = "lblDiscipline";
            this.lblDiscipline.Size = new System.Drawing.Size(76, 13);
            this.lblDiscipline.TabIndex = 8;
            this.lblDiscipline.Text = "DISCIPLINES:";
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPos.Location = new System.Drawing.Point(12, 33);
            this.lblPos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(59, 31);
            this.lblPos.TabIndex = 7;
            this.lblPos.Text = "000";
            // 
            // lblNeg
            // 
            this.lblNeg.AutoSize = true;
            this.lblNeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeg.Location = new System.Drawing.Point(94, 33);
            this.lblNeg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNeg.Name = "lblNeg";
            this.lblNeg.Size = new System.Drawing.Size(59, 31);
            this.lblNeg.TabIndex = 6;
            this.lblNeg.Text = "000";
            // 
            // gbInfraction
            // 
            this.gbInfraction.Controls.Add(this.lbInfraction);
            this.gbInfraction.Location = new System.Drawing.Point(3, 16);
            this.gbInfraction.Margin = new System.Windows.Forms.Padding(2);
            this.gbInfraction.Name = "gbInfraction";
            this.gbInfraction.Padding = new System.Windows.Forms.Padding(2);
            this.gbInfraction.Size = new System.Drawing.Size(456, 177);
            this.gbInfraction.TabIndex = 7;
            this.gbInfraction.TabStop = false;
            this.gbInfraction.Text = "INFRACTIONS:";
            // 
            // lbInfraction
            // 
            this.lbInfraction.FormattingEnabled = true;
            this.lbInfraction.Location = new System.Drawing.Point(3, 16);
            this.lbInfraction.Margin = new System.Windows.Forms.Padding(2);
            this.lbInfraction.Name = "lbInfraction";
            this.lbInfraction.Size = new System.Drawing.Size(452, 160);
            this.lbInfraction.TabIndex = 0;
            // 
            // gbDiscipline
            // 
            this.gbDiscipline.Controls.Add(this.lbDiscipline);
            this.gbDiscipline.Location = new System.Drawing.Point(3, 196);
            this.gbDiscipline.Margin = new System.Windows.Forms.Padding(2);
            this.gbDiscipline.Name = "gbDiscipline";
            this.gbDiscipline.Padding = new System.Windows.Forms.Padding(2);
            this.gbDiscipline.Size = new System.Drawing.Size(456, 177);
            this.gbDiscipline.TabIndex = 8;
            this.gbDiscipline.TabStop = false;
            this.gbDiscipline.Text = "DISCIPLINES:";
            // 
            // lbDiscipline
            // 
            this.lbDiscipline.FormattingEnabled = true;
            this.lbDiscipline.Location = new System.Drawing.Point(3, 16);
            this.lbDiscipline.Margin = new System.Windows.Forms.Padding(2);
            this.lbDiscipline.Name = "lbDiscipline";
            this.lbDiscipline.Size = new System.Drawing.Size(452, 160);
            this.lbDiscipline.TabIndex = 1;
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.gbInfraction);
            this.gbDetail.Controls.Add(this.gbDiscipline);
            this.gbDetail.Location = new System.Drawing.Point(76, 163);
            this.gbDetail.Margin = new System.Windows.Forms.Padding(2);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Padding = new System.Windows.Forms.Padding(2);
            this.gbDetail.Size = new System.Drawing.Size(462, 377);
            this.gbDetail.TabIndex = 9;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "DETAILS:";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(478, 544);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(60, 26);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // picbPurpleThing
            // 
            this.picbPurpleThing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbPurpleThing.BackgroundImage")));
            this.picbPurpleThing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbPurpleThing.Location = new System.Drawing.Point(-262, -218);
            this.picbPurpleThing.Margin = new System.Windows.Forms.Padding(2);
            this.picbPurpleThing.Name = "picbPurpleThing";
            this.picbPurpleThing.Size = new System.Drawing.Size(335, 1010);
            this.picbPurpleThing.TabIndex = 11;
            this.picbPurpleThing.TabStop = false;
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(542, 575);
            this.Controls.Add(this.picbPurpleThing);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.gbInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile:";
            ((System.ComponentModel.ISupportInitialize)(this.picbSoSA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbStatus)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbLogo)).EndInit();
            this.gbPS.ResumeLayout(false);
            this.gbPS.PerformLayout();
            this.gbInfraction.ResumeLayout(false);
            this.gbDiscipline.ResumeLayout(false);
            this.gbDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbPurpleThing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbSoSA;
        private System.Windows.Forms.PictureBox picbStatus;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.GroupBox gbPS;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblInfraction;
        private System.Windows.Forms.Label lblDiscipline;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Label lblNeg;
        private System.Windows.Forms.GroupBox gbInfraction;
        private System.Windows.Forms.ListBox lbInfraction;
        private System.Windows.Forms.GroupBox gbDiscipline;
        private System.Windows.Forms.ListBox lbDiscipline;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.PictureBox picbPurpleThing;
        private System.Windows.Forms.PictureBox picbLogo;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.Label lblSnoPhys;
        public System.Windows.Forms.Label lblSno;
    }
}