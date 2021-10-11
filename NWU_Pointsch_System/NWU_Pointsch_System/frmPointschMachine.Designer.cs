
namespace NWU_Pointsch_System
{
    partial class frmPointschMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPointschMachine));
            this.picbPurpleThing = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblAction = new System.Windows.Forms.GroupBox();
            this.gbAction = new System.Windows.Forms.GroupBox();
            this.lblMinMax = new System.Windows.Forms.Label();
            this.txtPointschValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbActionType = new System.Windows.Forms.ComboBox();
            this.lblStudentDetail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentNum = new System.Windows.Forms.TextBox();
            this.btnGetStudent = new System.Windows.Forms.Button();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbPurpleThing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.lblAction.SuspendLayout();
            this.gbAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbPurpleThing
            // 
            this.picbPurpleThing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbPurpleThing.BackgroundImage")));
            this.picbPurpleThing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbPurpleThing.Location = new System.Drawing.Point(-472, -571);
            this.picbPurpleThing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picbPurpleThing.Name = "picbPurpleThing";
            this.picbPurpleThing.Size = new System.Drawing.Size(670, 1942);
            this.picbPurpleThing.TabIndex = 13;
            this.picbPurpleThing.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1408, -571);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 1942);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1392, -558);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 1942);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(1376, -546);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 1942);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1248, 762);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 54);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblAction
            // 
            this.lblAction.Controls.Add(this.gbAction);
            this.lblAction.Controls.Add(this.lblStudentDetail);
            this.lblAction.Controls.Add(this.label2);
            this.lblAction.Controls.Add(this.txtStudentNum);
            this.lblAction.Controls.Add(this.btnGetStudent);
            this.lblAction.Location = new System.Drawing.Point(204, 12);
            this.lblAction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblAction.Name = "lblAction";
            this.lblAction.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblAction.Size = new System.Drawing.Size(1160, 742);
            this.lblAction.TabIndex = 19;
            this.lblAction.TabStop = false;
            this.lblAction.Text = "ACTION:";
            // 
            // gbAction
            // 
            this.gbAction.Controls.Add(this.txtDescription);
            this.gbAction.Controls.Add(this.lblMinMax);
            this.gbAction.Controls.Add(this.txtPointschValue);
            this.gbAction.Controls.Add(this.label1);
            this.gbAction.Controls.Add(this.label4);
            this.gbAction.Controls.Add(this.label3);
            this.gbAction.Controls.Add(this.cmbActionType);
            this.gbAction.Location = new System.Drawing.Point(12, 135);
            this.gbAction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAction.Name = "gbAction";
            this.gbAction.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAction.Size = new System.Drawing.Size(1144, 600);
            this.gbAction.TabIndex = 5;
            this.gbAction.TabStop = false;
            this.gbAction.Text = "ACTION DETAILS:";
            // 
            // lblMinMax
            // 
            this.lblMinMax.AutoSize = true;
            this.lblMinMax.Location = new System.Drawing.Point(358, 127);
            this.lblMinMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinMax.Name = "lblMinMax";
            this.lblMinMax.Size = new System.Drawing.Size(0, 25);
            this.lblMinMax.TabIndex = 6;
            this.lblMinMax.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtPointschValue
            // 
            this.txtPointschValue.Location = new System.Drawing.Point(208, 121);
            this.txtPointschValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPointschValue.Name = "txtPointschValue";
            this.txtPointschValue.Size = new System.Drawing.Size(212, 31);
            this.txtPointschValue.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "POINTSCH:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "DESCRIPTION:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "ACTION TYPE:";
            // 
            // cmbActionType
            // 
            this.cmbActionType.FormattingEnabled = true;
            this.cmbActionType.Location = new System.Drawing.Point(208, 50);
            this.cmbActionType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbActionType.Name = "cmbActionType";
            this.cmbActionType.Size = new System.Drawing.Size(900, 33);
            this.cmbActionType.TabIndex = 0;
            this.cmbActionType.SelectedIndexChanged += new System.EventHandler(this.cmbActionType_SelectedIndexChanged);
            // 
            // lblStudentDetail
            // 
            this.lblStudentDetail.AutoSize = true;
            this.lblStudentDetail.Location = new System.Drawing.Point(6, 85);
            this.lblStudentDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentDetail.Name = "lblStudentDetail";
            this.lblStudentDetail.Size = new System.Drawing.Size(0, 25);
            this.lblStudentDetail.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "STUDENT NO:";
            // 
            // txtStudentNum
            // 
            this.txtStudentNum.Location = new System.Drawing.Point(176, 38);
            this.txtStudentNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStudentNum.Name = "txtStudentNum";
            this.txtStudentNum.Size = new System.Drawing.Size(256, 31);
            this.txtStudentNum.TabIndex = 2;
            // 
            // btnGetStudent
            // 
            this.btnGetStudent.Location = new System.Drawing.Point(444, 33);
            this.btnGetStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetStudent.Name = "btnGetStudent";
            this.btnGetStudent.Size = new System.Drawing.Size(184, 48);
            this.btnGetStudent.TabIndex = 1;
            this.btnGetStudent.Text = "GET STUDENT";
            this.btnGetStudent.UseVisualStyleBackColor = true;
            this.btnGetStudent.Click += new System.EventHandler(this.btnGetStudent_Click);
            // 
            // btnFinalize
            // 
            this.btnFinalize.Location = new System.Drawing.Point(204, 762);
            this.btnFinalize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(144, 54);
            this.btnFinalize.TabIndex = 1;
            this.btnFinalize.Text = "FINALIZE";
            this.btnFinalize.UseVisualStyleBackColor = true;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(43, 206);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(1094, 387);
            this.txtDescription.TabIndex = 7;
            // 
            // frmPointschMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1416, 827);
            this.Controls.Add(this.btnFinalize);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picbPurpleThing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPointschMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pointsch Machine";
            this.Load += new System.EventHandler(this.frmPointschMachine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbPurpleThing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.lblAction.ResumeLayout(false);
            this.lblAction.PerformLayout();
            this.gbAction.ResumeLayout(false);
            this.gbAction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbPurpleThing;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox lblAction;
        private System.Windows.Forms.GroupBox gbAction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbActionType;
        private System.Windows.Forms.Label lblStudentDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudentNum;
        private System.Windows.Forms.Button btnGetStudent;
        private System.Windows.Forms.Button btnFinalize;
        private System.Windows.Forms.TextBox txtPointschValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMinMax;
        private System.Windows.Forms.TextBox txtDescription;
    }
}