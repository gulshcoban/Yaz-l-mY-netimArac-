namespace Yazılım_Test_Aracı
{
    partial class frmInsertProcess
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
            this.lblProcessName = new System.Windows.Forms.Label();
            this.txtProcessName = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblFinishDate = new System.Windows.Forms.Label();
            this.dtpFinishDate = new System.Windows.Forms.DateTimePicker();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCompleteRate = new System.Windows.Forms.Label();
            this.cmbCompleteRate = new System.Windows.Forms.ComboBox();
            this.lblWorkFollowName = new System.Windows.Forms.Label();
            this.txtWorkFollowName = new System.Windows.Forms.TextBox();
            this.lblFromWho = new System.Windows.Forms.Label();
            this.cmbFromWho = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblProcessName
            // 
            this.lblProcessName.AutoSize = true;
            this.lblProcessName.Location = new System.Drawing.Point(12, 25);
            this.lblProcessName.Name = "lblProcessName";
            this.lblProcessName.Size = new System.Drawing.Size(104, 17);
            this.lblProcessName.TabIndex = 0;
            this.lblProcessName.Text = "Process Name:";
            // 
            // txtProcessName
            // 
            this.txtProcessName.Location = new System.Drawing.Point(138, 25);
            this.txtProcessName.Name = "txtProcessName";
            this.txtProcessName.Size = new System.Drawing.Size(202, 22);
            this.txtProcessName.TabIndex = 1;
            this.txtProcessName.Leave += new System.EventHandler(this.txtProcessName_Leave);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(12, 73);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(76, 17);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start Date:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(138, 73);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(202, 22);
            this.dtpStartDate.TabIndex = 3;
            // 
            // lblFinishDate
            // 
            this.lblFinishDate.AutoSize = true;
            this.lblFinishDate.Location = new System.Drawing.Point(12, 123);
            this.lblFinishDate.Name = "lblFinishDate";
            this.lblFinishDate.Size = new System.Drawing.Size(83, 17);
            this.lblFinishDate.TabIndex = 4;
            this.lblFinishDate.Text = "Finish Date:";
            // 
            // dtpFinishDate
            // 
            this.dtpFinishDate.Location = new System.Drawing.Point(138, 123);
            this.dtpFinishDate.Name = "dtpFinishDate";
            this.dtpFinishDate.Size = new System.Drawing.Size(202, 22);
            this.dtpFinishDate.TabIndex = 5;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(402, 25);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(66, 17);
            this.lblDuration.TabIndex = 6;
            this.lblDuration.Text = "Duration:";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(509, 25);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(202, 22);
            this.txtDuration.TabIndex = 7;
            this.txtDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDuration_KeyPress);
            this.txtDuration.Leave += new System.EventHandler(this.txtDuration_Leave);
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(402, 76);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(56, 17);
            this.lblPriority.TabIndex = 8;
            this.lblPriority.Text = "Priority:";
            // 
            // cmbPriority
            // 
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Location = new System.Drawing.Point(509, 73);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(202, 24);
            this.cmbPriority.TabIndex = 9;
            this.cmbPriority.Leave += new System.EventHandler(this.cmbPriority_Leave);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(12, 185);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(49, 17);
            this.lblNotes.TabIndex = 10;
            this.lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(138, 185);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(202, 81);
            this.txtNotes.TabIndex = 11;
            this.txtNotes.Leave += new System.EventHandler(this.txtNotes_Leave);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(13, 296);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 17);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(138, 296);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(206, 90);
            this.txtDescription.TabIndex = 13;
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(401, 310);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(273, 76);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCompleteRate
            // 
            this.lblCompleteRate.AutoSize = true;
            this.lblCompleteRate.Location = new System.Drawing.Point(398, 128);
            this.lblCompleteRate.Name = "lblCompleteRate";
            this.lblCompleteRate.Size = new System.Drawing.Size(105, 17);
            this.lblCompleteRate.TabIndex = 15;
            this.lblCompleteRate.Text = "Complete Rate:";
            // 
            // cmbCompleteRate
            // 
            this.cmbCompleteRate.FormattingEnabled = true;
            this.cmbCompleteRate.Location = new System.Drawing.Point(509, 128);
            this.cmbCompleteRate.Name = "cmbCompleteRate";
            this.cmbCompleteRate.Size = new System.Drawing.Size(202, 24);
            this.cmbCompleteRate.TabIndex = 16;
            this.cmbCompleteRate.Leave += new System.EventHandler(this.cmbCompleteRate_Leave);
            // 
            // lblWorkFollowName
            // 
            this.lblWorkFollowName.AutoSize = true;
            this.lblWorkFollowName.Location = new System.Drawing.Point(374, 185);
            this.lblWorkFollowName.Name = "lblWorkFollowName";
            this.lblWorkFollowName.Size = new System.Drawing.Size(129, 17);
            this.lblWorkFollowName.TabIndex = 17;
            this.lblWorkFollowName.Text = "Work Follow Name:";
            // 
            // txtWorkFollowName
            // 
            this.txtWorkFollowName.Location = new System.Drawing.Point(509, 185);
            this.txtWorkFollowName.Name = "txtWorkFollowName";
            this.txtWorkFollowName.Size = new System.Drawing.Size(202, 22);
            this.txtWorkFollowName.TabIndex = 18;
            this.txtWorkFollowName.Leave += new System.EventHandler(this.txtWorkFollowName_Leave);
            // 
            // lblFromWho
            // 
            this.lblFromWho.AutoSize = true;
            this.lblFromWho.Location = new System.Drawing.Point(398, 249);
            this.lblFromWho.Name = "lblFromWho";
            this.lblFromWho.Size = new System.Drawing.Size(77, 17);
            this.lblFromWho.TabIndex = 19;
            this.lblFromWho.Text = "From Who:";
            // 
            // cmbFromWho
            // 
            this.cmbFromWho.FormattingEnabled = true;
            this.cmbFromWho.Location = new System.Drawing.Point(509, 246);
            this.cmbFromWho.Name = "cmbFromWho";
            this.cmbFromWho.Size = new System.Drawing.Size(202, 24);
            this.cmbFromWho.TabIndex = 20;
            this.cmbFromWho.Leave += new System.EventHandler(this.cmbFromWho_Leave);
            // 
            // frmInsertProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 448);
            this.Controls.Add(this.cmbFromWho);
            this.Controls.Add(this.lblFromWho);
            this.Controls.Add(this.txtWorkFollowName);
            this.Controls.Add(this.lblWorkFollowName);
            this.Controls.Add(this.cmbCompleteRate);
            this.Controls.Add(this.lblCompleteRate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.dtpFinishDate);
            this.Controls.Add(this.lblFinishDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtProcessName);
            this.Controls.Add(this.lblProcessName);
            this.Name = "frmInsertProcess";
            this.Text = "InsertProcess";
            this.Load += new System.EventHandler(this.frmInsertProcess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProcessName;
        private System.Windows.Forms.TextBox txtProcessName;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblFinishDate;
        private System.Windows.Forms.DateTimePicker dtpFinishDate;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCompleteRate;
        private System.Windows.Forms.ComboBox cmbCompleteRate;
        private System.Windows.Forms.Label lblWorkFollowName;
        private System.Windows.Forms.TextBox txtWorkFollowName;
        private System.Windows.Forms.Label lblFromWho;
        private System.Windows.Forms.ComboBox cmbFromWho;
    }
}