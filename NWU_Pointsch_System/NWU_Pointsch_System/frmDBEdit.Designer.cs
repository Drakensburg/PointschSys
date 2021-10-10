
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.dgvPointsch.Location = new System.Drawing.Point(98, 6);
            this.dgvPointsch.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPointsch.Name = "dgvPointsch";
            this.dgvPointsch.RowHeadersWidth = 82;
            this.dgvPointsch.RowTemplate.Height = 33;
            this.dgvPointsch.Size = new System.Drawing.Size(718, 295);
            this.dgvPointsch.TabIndex = 0;
            // 
            // picbPurpleThing
            // 
            this.picbPurpleThing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbPurpleThing.BackgroundImage")));
            this.picbPurpleThing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbPurpleThing.Location = new System.Drawing.Point(-240, -301);
            this.picbPurpleThing.Margin = new System.Windows.Forms.Padding(2);
            this.picbPurpleThing.Name = "picbPurpleThing";
            this.picbPurpleThing.Size = new System.Drawing.Size(335, 1010);
            this.picbPurpleThing.TabIndex = 12;
            this.picbPurpleThing.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(756, 443);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(60, 21);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbPersonalInformation
            // 
            this.gbPersonalInformation.Controls.Add(this.lblCampus);
            this.gbPersonalInformation.Controls.Add(this.comboBox1);
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
            this.gbPersonalInformation.Location = new System.Drawing.Point(98, 305);
            this.gbPersonalInformation.Margin = new System.Windows.Forms.Padding(2);
            this.gbPersonalInformation.Name = "gbPersonalInformation";
            this.gbPersonalInformation.Padding = new System.Windows.Forms.Padding(2);
            this.gbPersonalInformation.Size = new System.Drawing.Size(344, 135);
            this.gbPersonalInformation.TabIndex = 14;
            this.gbPersonalInformation.TabStop = false;
            this.gbPersonalInformation.Text = "PERSONAL INFORMATION";
            // 
            // lblCampus
            // 
            this.lblCampus.AutoSize = true;
            this.lblCampus.Location = new System.Drawing.Point(0, 74);
            this.lblCampus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCampus.Name = "lblCampus";
            this.lblCampus.Size = new System.Drawing.Size(55, 13);
            this.lblCampus.TabIndex = 27;
            this.lblCampus.Text = "CAMPUS:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Potchefstroom",
            "Mafikeng",
            "Vaal"});
            this.comboBox1.Location = new System.Drawing.Point(58, 73);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 21);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.Text = "SELECT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
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
            this.cbPosition.Location = new System.Drawing.Point(222, 71);
            this.cbPosition.Margin = new System.Windows.Forms.Padding(2);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(120, 21);
            this.cbPosition.TabIndex = 24;
            this.cbPosition.Text = "SELECT";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(200, 44);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "ID:";
            // 
            // lblSNo
            // 
            this.lblSNo.AutoSize = true;
            this.lblSNo.Location = new System.Drawing.Point(23, 44);
            this.lblSNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSNo.Name = "lblSNo";
            this.lblSNo.Size = new System.Drawing.Size(33, 13);
            this.lblSNo.TabIndex = 21;
            this.lblSNo.Text = "SNO:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(160, 17);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(64, 13);
            this.lblSurname.TabIndex = 20;
            this.lblSurname.Text = "SURNAME:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 20);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "NAME:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(222, 43);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(120, 20);
            this.txtID.TabIndex = 18;
            // 
            // txtSNO
            // 
            this.txtSNO.Location = new System.Drawing.Point(58, 43);
            this.txtSNO.Margin = new System.Windows.Forms.Padding(2);
            this.txtSNO.Name = "txtSNO";
            this.txtSNO.Size = new System.Drawing.Size(101, 20);
            this.txtSNO.TabIndex = 17;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(222, 16);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(120, 20);
            this.txtSurname.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(58, 16);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(101, 20);
            this.txtName.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 99);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "REMOVE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 99);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 28);
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
            this.gbPointschInformation.Location = new System.Drawing.Point(445, 305);
            this.gbPointschInformation.Margin = new System.Windows.Forms.Padding(2);
            this.gbPointschInformation.Name = "gbPointschInformation";
            this.gbPointschInformation.Padding = new System.Windows.Forms.Padding(2);
            this.gbPointschInformation.Size = new System.Drawing.Size(371, 135);
            this.gbPointschInformation.TabIndex = 15;
            this.gbPointschInformation.TabStop = false;
            this.gbPointschInformation.Text = "POITSCH INFORMATION";
            // 
            // btnPIRemove
            // 
            this.btnPIRemove.Location = new System.Drawing.Point(186, 99);
            this.btnPIRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnPIRemove.Name = "btnPIRemove";
            this.btnPIRemove.Size = new System.Drawing.Size(178, 28);
            this.btnPIRemove.TabIndex = 12;
            this.btnPIRemove.Text = "REMOVE";
            this.btnPIRemove.UseVisualStyleBackColor = true;
            // 
            // btnPIAdd
            // 
            this.btnPIAdd.Location = new System.Drawing.Point(6, 99);
            this.btnPIAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnPIAdd.Name = "btnPIAdd";
            this.btnPIAdd.Size = new System.Drawing.Size(178, 28);
            this.btnPIAdd.TabIndex = 11;
            this.btnPIAdd.Text = "ADD";
            this.btnPIAdd.UseVisualStyleBackColor = true;
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Location = new System.Drawing.Point(3, 78);
            this.lblTypeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(72, 13);
            this.lblTypeName.TabIndex = 10;
            this.lblTypeName.Text = "TYPE NAME:";
            // 
            // lblWorth
            // 
            this.lblWorth.AutoSize = true;
            this.lblWorth.Location = new System.Drawing.Point(228, 78);
            this.lblWorth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWorth.Name = "lblWorth";
            this.lblWorth.Size = new System.Drawing.Size(52, 13);
            this.lblWorth.TabIndex = 9;
            this.lblWorth.Text = "WORTH:";
            // 
            // cbConfirm
            // 
            this.cbConfirm.AutoSize = true;
            this.cbConfirm.Location = new System.Drawing.Point(121, 58);
            this.cbConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.cbConfirm.Name = "cbConfirm";
            this.cbConfirm.Size = new System.Drawing.Size(15, 14);
            this.cbConfirm.TabIndex = 8;
            this.cbConfirm.UseVisualStyleBackColor = true;
            // 
            // lblNewType
            // 
            this.lblNewType.AutoSize = true;
            this.lblNewType.Location = new System.Drawing.Point(54, 58);
            this.lblNewType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewType.Name = "lblNewType";
            this.lblNewType.Size = new System.Drawing.Size(67, 13);
            this.lblNewType.TabIndex = 7;
            this.lblNewType.Text = "NEW TYPE:";
            // 
            // txtWorth
            // 
            this.txtWorth.Location = new System.Drawing.Point(281, 75);
            this.txtWorth.Margin = new System.Windows.Forms.Padding(2);
            this.txtWorth.Name = "txtWorth";
            this.txtWorth.Size = new System.Drawing.Size(86, 20);
            this.txtWorth.TabIndex = 6;
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(76, 75);
            this.txtTypeName.Margin = new System.Windows.Forms.Padding(2);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(148, 20);
            this.txtTypeName.TabIndex = 5;
            // 
            // txtNewType
            // 
            this.txtNewType.Enabled = false;
            this.txtNewType.Location = new System.Drawing.Point(138, 56);
            this.txtNewType.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewType.Name = "txtNewType";
            this.txtNewType.Size = new System.Drawing.Size(229, 20);
            this.txtNewType.TabIndex = 4;
            // 
            // lblDI
            // 
            this.lblDI.AutoSize = true;
            this.lblDI.Location = new System.Drawing.Point(3, 17);
            this.lblDI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDI.Name = "lblDI";
            this.lblDI.Size = new System.Drawing.Size(139, 13);
            this.lblDI.TabIndex = 3;
            this.lblDI.Text = "DISCIPLINE/INFRACTION:";
            // 
            // cbDI
            // 
            this.cbDI.FormattingEnabled = true;
            this.cbDI.Items.AddRange(new object[] {
            "INFRACTION",
            "DISCIPLINE"});
            this.cbDI.Location = new System.Drawing.Point(138, 16);
            this.cbDI.Margin = new System.Windows.Forms.Padding(2);
            this.cbDI.Name = "cbDI";
            this.cbDI.Size = new System.Drawing.Size(229, 21);
            this.cbDI.TabIndex = 2;
            this.cbDI.Text = "SELECT A D/I";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(98, 37);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(38, 13);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "TYPE:";
            // 
            // cbTpe
            // 
            this.cbTpe.FormattingEnabled = true;
            this.cbTpe.Items.AddRange(new object[] {
            "INFRACTION",
            "DISCIPLINE"});
            this.cbTpe.Location = new System.Drawing.Point(138, 36);
            this.cbTpe.Margin = new System.Windows.Forms.Padding(2);
            this.cbTpe.Name = "cbTpe";
            this.cbTpe.Size = new System.Drawing.Size(229, 21);
            this.cbTpe.TabIndex = 0;
            this.cbTpe.Text = "SELECT A TYPE";
            // 
            // frmDBEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(831, 474);
            this.Controls.Add(this.gbPointschInformation);
            this.Controls.Add(this.gbPersonalInformation);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picbPurpleThing);
            this.Controls.Add(this.dgvPointsch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label lblCampus;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}