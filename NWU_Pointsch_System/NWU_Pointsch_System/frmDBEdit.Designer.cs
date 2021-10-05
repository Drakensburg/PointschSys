
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
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
            this.btnPIRemove = new System.Windows.Forms.Button();
            this.btnPIAdd = new System.Windows.Forms.Button();
            this.lblTypeName = new System.Windows.Forms.Label();
            this.lblWorth = new System.Windows.Forms.Label();
            this.cbConfirm = new System.Windows.Forms.CheckBox();
            this.lblNewType = new System.Windows.Forms.Label();
            this.txtWorth = new System.Windows.Forms.TextBox();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.txtNewType = new System.Windows.Forms.TextBox();
            this.lblDI = new System.Windows.Forms.Label();
            this.cbDI = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cbTpe = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPointsch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbPurpleThing)).BeginInit();
            this.gbPersonalInformation.SuspendLayout();
            this.gbPointschInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPointsch
            // 
            this.dgvPointsch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPointsch.Location = new System.Drawing.Point(197, 12);
            this.dgvPointsch.Name = "dgvPointsch";
            this.dgvPointsch.RowHeadersWidth = 82;
            this.dgvPointsch.RowTemplate.Height = 33;
            this.dgvPointsch.Size = new System.Drawing.Size(1435, 568);
            this.dgvPointsch.TabIndex = 0;
            // 
            // picbPurpleThing
            // 
            this.picbPurpleThing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbPurpleThing.BackgroundImage")));
            this.picbPurpleThing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbPurpleThing.Location = new System.Drawing.Point(-479, -579);
            this.picbPurpleThing.Name = "picbPurpleThing";
            this.picbPurpleThing.Size = new System.Drawing.Size(670, 1942);
            this.picbPurpleThing.TabIndex = 12;
            this.picbPurpleThing.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1511, 852);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 41);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbPersonalInformation
            // 
            this.gbPersonalInformation.Controls.Add(this.label1);
            this.gbPersonalInformation.Controls.Add(this.cbPosition);
            this.gbPersonalInformation.Controls.Add(this.cbAdmin);
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
            this.gbPersonalInformation.Location = new System.Drawing.Point(197, 586);
            this.gbPersonalInformation.Name = "gbPersonalInformation";
            this.gbPersonalInformation.Size = new System.Drawing.Size(687, 260);
            this.gbPersonalInformation.TabIndex = 14;
            this.gbPersonalInformation.TabStop = false;
            this.gbPersonalInformation.Text = "PERSONAL INFORMATION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "POSITION:";
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "STUDENT",
            "STAFF"});
            this.cbPosition.Location = new System.Drawing.Point(444, 137);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(237, 33);
            this.cbPosition.TabIndex = 24;
            this.cbPosition.Text = "SELECT POSITION";
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Location = new System.Drawing.Point(11, 139);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(111, 29);
            this.cbAdmin.TabIndex = 23;
            this.cbAdmin.Text = "ADMIN";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(400, 85);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(38, 25);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "ID:";
            // 
            // lblSNo
            // 
            this.lblSNo.AutoSize = true;
            this.lblSNo.Location = new System.Drawing.Point(22, 85);
            this.lblSNo.Name = "lblSNo";
            this.lblSNo.Size = new System.Drawing.Size(63, 25);
            this.lblSNo.TabIndex = 21;
            this.lblSNo.Text = "SNO:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(319, 33);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(123, 25);
            this.lblSurname.TabIndex = 20;
            this.lblSurname.Text = "SURNAME:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 25);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "NAME:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(444, 82);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(237, 31);
            this.txtID.TabIndex = 18;
            // 
            // txtSNO
            // 
            this.txtSNO.Location = new System.Drawing.Point(91, 82);
            this.txtSNO.Name = "txtSNO";
            this.txtSNO.Size = new System.Drawing.Size(222, 31);
            this.txtSNO.TabIndex = 17;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(444, 30);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(237, 31);
            this.txtSurname.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(91, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 31);
            this.txtName.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 53);
            this.button1.TabIndex = 14;
            this.button1.Text = "REMOVE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(335, 53);
            this.button2.TabIndex = 13;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // gbPointschInformation
            // 
            this.gbPointschInformation.Controls.Add(this.btnPIRemove);
            this.gbPointschInformation.Controls.Add(this.btnPIAdd);
            this.gbPointschInformation.Controls.Add(this.lblTypeName);
            this.gbPointschInformation.Controls.Add(this.lblWorth);
            this.gbPointschInformation.Controls.Add(this.cbConfirm);
            this.gbPointschInformation.Controls.Add(this.lblNewType);
            this.gbPointschInformation.Controls.Add(this.txtWorth);
            this.gbPointschInformation.Controls.Add(this.txtTypeName);
            this.gbPointschInformation.Controls.Add(this.txtNewType);
            this.gbPointschInformation.Controls.Add(this.lblDI);
            this.gbPointschInformation.Controls.Add(this.cbDI);
            this.gbPointschInformation.Controls.Add(this.lblType);
            this.gbPointschInformation.Controls.Add(this.cbTpe);
            this.gbPointschInformation.Location = new System.Drawing.Point(890, 586);
            this.gbPointschInformation.Name = "gbPointschInformation";
            this.gbPointschInformation.Size = new System.Drawing.Size(742, 260);
            this.gbPointschInformation.TabIndex = 15;
            this.gbPointschInformation.TabStop = false;
            this.gbPointschInformation.Text = "POITSCH INFORMATION";
            // 
            // btnPIRemove
            // 
            this.btnPIRemove.Location = new System.Drawing.Point(373, 191);
            this.btnPIRemove.Name = "btnPIRemove";
            this.btnPIRemove.Size = new System.Drawing.Size(357, 53);
            this.btnPIRemove.TabIndex = 12;
            this.btnPIRemove.Text = "REMOVE";
            this.btnPIRemove.UseVisualStyleBackColor = true;
            // 
            // btnPIAdd
            // 
            this.btnPIAdd.Location = new System.Drawing.Point(11, 191);
            this.btnPIAdd.Name = "btnPIAdd";
            this.btnPIAdd.Size = new System.Drawing.Size(357, 53);
            this.btnPIAdd.TabIndex = 11;
            this.btnPIAdd.Text = "ADD";
            this.btnPIAdd.UseVisualStyleBackColor = true;
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Location = new System.Drawing.Point(6, 147);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(141, 25);
            this.lblTypeName.TabIndex = 10;
            this.lblTypeName.Text = "TYPE NAME:";
            // 
            // lblWorth
            // 
            this.lblWorth.AutoSize = true;
            this.lblWorth.Location = new System.Drawing.Point(459, 147);
            this.lblWorth.Name = "lblWorth";
            this.lblWorth.Size = new System.Drawing.Size(97, 25);
            this.lblWorth.TabIndex = 9;
            this.lblWorth.Text = "WORTH:";
            // 
            // cbConfirm
            // 
            this.cbConfirm.AutoSize = true;
            this.cbConfirm.Location = new System.Drawing.Point(242, 111);
            this.cbConfirm.Name = "cbConfirm";
            this.cbConfirm.Size = new System.Drawing.Size(28, 27);
            this.cbConfirm.TabIndex = 8;
            this.cbConfirm.UseVisualStyleBackColor = true;
            // 
            // lblNewType
            // 
            this.lblNewType.AutoSize = true;
            this.lblNewType.Location = new System.Drawing.Point(107, 111);
            this.lblNewType.Name = "lblNewType";
            this.lblNewType.Size = new System.Drawing.Size(129, 25);
            this.lblNewType.TabIndex = 7;
            this.lblNewType.Text = "NEW TYPE:";
            // 
            // txtWorth
            // 
            this.txtWorth.Location = new System.Drawing.Point(562, 144);
            this.txtWorth.Name = "txtWorth";
            this.txtWorth.Size = new System.Drawing.Size(168, 31);
            this.txtWorth.TabIndex = 6;
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(153, 144);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(291, 31);
            this.txtTypeName.TabIndex = 5;
            // 
            // txtNewType
            // 
            this.txtNewType.Enabled = false;
            this.txtNewType.Location = new System.Drawing.Point(276, 107);
            this.txtNewType.Name = "txtNewType";
            this.txtNewType.Size = new System.Drawing.Size(454, 31);
            this.txtNewType.TabIndex = 4;
            // 
            // lblDI
            // 
            this.lblDI.AutoSize = true;
            this.lblDI.Location = new System.Drawing.Point(6, 33);
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
            this.cbDI.Location = new System.Drawing.Point(276, 30);
            this.cbDI.Name = "cbDI";
            this.cbDI.Size = new System.Drawing.Size(454, 33);
            this.cbDI.TabIndex = 2;
            this.cbDI.Text = "SELECT A D/I";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(196, 72);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(74, 25);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "TYPE:";
            // 
            // cbTpe
            // 
            this.cbTpe.FormattingEnabled = true;
            this.cbTpe.Items.AddRange(new object[] {
            "INFRACTION",
            "DISCIPLINE"});
            this.cbTpe.Location = new System.Drawing.Point(276, 69);
            this.cbTpe.Name = "cbTpe";
            this.cbTpe.Size = new System.Drawing.Size(454, 33);
            this.cbTpe.TabIndex = 0;
            this.cbTpe.Text = "SELECT A TYPE";
            // 
            // frmDBEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1641, 904);
            this.Controls.Add(this.gbPointschInformation);
            this.Controls.Add(this.gbPersonalInformation);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picbPurpleThing);
            this.Controls.Add(this.dgvPointsch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDBEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Edit";
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
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbTpe;
        private System.Windows.Forms.Button btnPIRemove;
        private System.Windows.Forms.Button btnPIAdd;
        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.Label lblWorth;
        private System.Windows.Forms.CheckBox cbConfirm;
        private System.Windows.Forms.Label lblNewType;
        private System.Windows.Forms.TextBox txtWorth;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.TextBox txtNewType;
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
        private System.Windows.Forms.CheckBox cbAdmin;
    }
}